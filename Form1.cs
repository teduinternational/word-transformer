using Dictionary.Algorithm;
using Dictionary.Entities;
using Dictionary.Helpers;
using Newtonsoft.Json;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class FrmDictionary : Form
    {
        HashSet<string> words = new HashSet<string>();
        //HashSet<Edge> edges = new HashSet<Edge>();
        Dictionary<string, Dictionary<string, int>> dictionary = new Dictionary<string, Dictionary<string, int>>();
        Stopwatch watcher = new Stopwatch();


        public FrmDictionary()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                progressBar1.Maximum = 100;
                progressBar1.Step = 1;
                progressBar1.Value = 0;
                watcher.Start();
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ExcelPackage package = new ExcelPackage(new FileInfo(openFileDialog1.FileName));
            ExcelWorksheet workSheet = package.Workbook.Worksheets.FirstOrDefault();
            if (workSheet != null)
            {
                //read from Excel
                var start = workSheet.Dimension.Start;
                var end = workSheet.Dimension.End;
                for (int row = start.Row + 1; row <= end.Row; row++)
                {
                    words.Add(workSheet.Cells[row, 1].Text);
                }
                Dictionary<string, int> totalChild;
                //loop for all words
                for (int i = 0; i < words.Count; i++)
                {
                    totalChild = new Dictionary<string, int>();
                    //Insert operator
                    var added = TransformHelper.AddLetter(words, words.ElementAt(i));
                    for (int j = 0; j < added.Count; j++)
                    {
                        totalChild.Add(added[j], added[j].Length);
                    }


                    //Replace operator
                    var replaces = TransformHelper.ReplaceLetter(words, words.ElementAt(i));
                    for (int j = 0; j < replaces.Count; j++)
                    {
                        totalChild.Add(replaces[j], 1);
                    }

                    //Remove operator
                    var removes = TransformHelper.RemoveLetter(words, words.ElementAt(i));
                    for (int j = 0; j < removes.Count; j++)
                    {
                        totalChild.Add(removes[j], removes[j].Length);
                    }

                    dictionary.Add(words.ElementAt(i), totalChild);

                    //Output
                    Trace.WriteLine($"Word: {words.ElementAt(i)} - i: {i} - edges count: {dictionary.Count}");
                }

            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //build dictionary

            watcher.Stop();
            progressBar1.Value = 100;
            lblBuildTime.Text = watcher.Elapsed.Minutes.ToString() + " minutes.";
            MessageBox.Show($"Dictionary has built. There are {dictionary.Count} vertices.");
        }

        private void btnSaveDict_Click(object sender, EventArgs e)
        {
            using (StreamWriter outputFile = new StreamWriter(@"Dict.txt"))
            {
                var data = JsonConvert.SerializeObject(dictionary);
                outputFile.Write(data);
                MessageBox.Show("Save dictionary successful.");

            }

        }

        private void btnLoadDict_Click(object sender, EventArgs e)
        {
            using (StreamReader inputFile = new StreamReader(@"Dict.txt"))
            {
                dictionary = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, int>>>(inputFile.ReadToEnd());
                MessageBox.Show("Loading dictionary successful.");
            }
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            bwTransformer.RunWorkerAsync();
        }

        private void bwTransformer_DoWork(object sender, DoWorkEventArgs e)
        {
            watcher.Reset();
            watcher.Start();
            lstBoxPath.Invoke(new Action(() => lstBoxPath.Items.Clear()));

            var results = RijkstraImpl.FindShortestPath(dictionary, txtSource.Text, txtDestination.Text);
            if (results != null && results.Count > 0)
            {

                foreach (var item in results)
                {
                    lstBoxPath.Invoke(new Action(() => lstBoxPath.Items.Add(item.Key + " - (+" + item.Value + ")")));
                }
                watcher.Stop();
                lblTotalCost.Invoke(new Action(() => lblTotalCost.Text = results.Max(x => x.Value).ToString()));
                lblTransformTime.Invoke(new Action(() => lblTransformTime.Text = watcher.Elapsed.Seconds + " s"));

            }
            else
            {
                MessageBox.Show("Cannot find the path.");
            }

        }


    }
}