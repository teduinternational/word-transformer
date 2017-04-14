namespace Dictionary
{
    partial class FrmDictionary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnImport = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnTransform = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lstBoxPath = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblBuildTime = new System.Windows.Forms.Label();
            this.lblTransformTime = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSaveDict = new System.Windows.Forms.Button();
            this.btnLoadDict = new System.Windows.Forms.Button();
            this.bwTransformer = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(27, 13);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(27, 60);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(193, 20);
            this.txtSource.TabIndex = 1;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(27, 86);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(193, 20);
            this.txtDestination.TabIndex = 2;
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(27, 112);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(75, 23);
            this.btnTransform.TabIndex = 3;
            this.btnTransform.Text = "Transform";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(120, 13);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(335, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // lstBoxPath
            // 
            this.lstBoxPath.FormattingEnabled = true;
            this.lstBoxPath.Location = new System.Drawing.Point(268, 60);
            this.lstBoxPath.Name = "lstBoxPath";
            this.lstBoxPath.Size = new System.Drawing.Size(175, 173);
            this.lstBoxPath.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total cost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Build dict:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Transform:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(410, 246);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCost.TabIndex = 9;
            // 
            // lblBuildTime
            // 
            this.lblBuildTime.AutoSize = true;
            this.lblBuildTime.Location = new System.Drawing.Point(83, 165);
            this.lblBuildTime.Name = "lblBuildTime";
            this.lblBuildTime.Size = new System.Drawing.Size(0, 13);
            this.lblBuildTime.TabIndex = 10;
            // 
            // lblTransformTime
            // 
            this.lblTransformTime.AutoSize = true;
            this.lblTransformTime.Location = new System.Drawing.Point(83, 191);
            this.lblTransformTime.Name = "lblTransformTime";
            this.lblTransformTime.Size = new System.Drawing.Size(0, 13);
            this.lblTransformTime.TabIndex = 11;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnSaveDict
            // 
            this.btnSaveDict.Location = new System.Drawing.Point(23, 236);
            this.btnSaveDict.Name = "btnSaveDict";
            this.btnSaveDict.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDict.TabIndex = 12;
            this.btnSaveDict.Text = "Save Dict";
            this.btnSaveDict.UseVisualStyleBackColor = true;
            this.btnSaveDict.Click += new System.EventHandler(this.btnSaveDict_Click);
            // 
            // btnLoadDict
            // 
            this.btnLoadDict.Location = new System.Drawing.Point(104, 236);
            this.btnLoadDict.Name = "btnLoadDict";
            this.btnLoadDict.Size = new System.Drawing.Size(75, 23);
            this.btnLoadDict.TabIndex = 13;
            this.btnLoadDict.Text = "Load dict";
            this.btnLoadDict.UseVisualStyleBackColor = true;
            this.btnLoadDict.Click += new System.EventHandler(this.btnLoadDict_Click);
            // 
            // bwTransformer
            // 
            this.bwTransformer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwTransformer_DoWork);
            // 
            // FrmDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 278);
            this.Controls.Add(this.btnLoadDict);
            this.Controls.Add(this.btnSaveDict);
            this.Controls.Add(this.lblTransformTime);
            this.Controls.Add(this.lblBuildTime);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxPath);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnImport);
            this.Name = "FrmDictionary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox lstBoxPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblBuildTime;
        private System.Windows.Forms.Label lblTransformTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSaveDict;
        private System.Windows.Forms.Button btnLoadDict;
        private System.ComponentModel.BackgroundWorker bwTransformer;
    }
}

