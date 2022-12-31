namespace CSVProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCSV = new System.Windows.Forms.DataGridView();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheckComplaint = new System.Windows.Forms.Button();
            this.btnIssueSimilarity = new System.Windows.Forms.Button();
            this.setThreadCount = new System.Windows.Forms.Button();
            this.txtThreshold = new System.Windows.Forms.TextBox();
            this.btnThreshold = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtThreadCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaAçToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaAçToolStripMenuItem
            // 
            this.dosyaAçToolStripMenuItem.Name = "dosyaAçToolStripMenuItem";
            this.dosyaAçToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.dosyaAçToolStripMenuItem.Text = "Dosya Aç";
            this.dosyaAçToolStripMenuItem.Click += new System.EventHandler(this.dosyaAçToolStripMenuItem_Click);
            // 
            // dgvCSV
            // 
            this.dgvCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCSV.Location = new System.Drawing.Point(0, 0);
            this.dgvCSV.Name = "dgvCSV";
            this.dgvCSV.RowTemplate.Height = 25;
            this.dgvCSV.Size = new System.Drawing.Size(218, 252);
            this.dgvCSV.TabIndex = 1;
            // 
            // dgvResult
            // 
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.Location = new System.Drawing.Point(0, 0);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowTemplate.Height = 25;
            this.dgvResult.Size = new System.Drawing.Size(442, 252);
            this.dgvResult.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCheckComplaint);
            this.panel1.Controls.Add(this.btnIssueSimilarity);
            this.panel1.Controls.Add(this.setThreadCount);
            this.panel1.Controls.Add(this.txtThreshold);
            this.panel1.Controls.Add(this.btnThreshold);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.txtThreadCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(664, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 335);
            this.panel1.TabIndex = 3;
            // 
            // btnCheckComplaint
            // 
            this.btnCheckComplaint.Location = new System.Drawing.Point(3, 305);
            this.btnCheckComplaint.Name = "btnCheckComplaint";
            this.btnCheckComplaint.Size = new System.Drawing.Size(165, 23);
            this.btnCheckComplaint.TabIndex = 7;
            this.btnCheckComplaint.Text = "Check Complaint";
            this.btnCheckComplaint.UseVisualStyleBackColor = true;
            this.btnCheckComplaint.Click += new System.EventHandler(this.btnCheckComplaint_Click);
            // 
            // btnIssueSimilarity
            // 
            this.btnIssueSimilarity.Location = new System.Drawing.Point(3, 276);
            this.btnIssueSimilarity.Name = "btnIssueSimilarity";
            this.btnIssueSimilarity.Size = new System.Drawing.Size(165, 23);
            this.btnIssueSimilarity.TabIndex = 6;
            this.btnIssueSimilarity.Text = "Check Issue Similarity";
            this.btnIssueSimilarity.UseVisualStyleBackColor = true;
            this.btnIssueSimilarity.Click += new System.EventHandler(this.btnIssueSimilarity_Click);
            // 
            // setThreadCount
            // 
            this.setThreadCount.Location = new System.Drawing.Point(3, 50);
            this.setThreadCount.Name = "setThreadCount";
            this.setThreadCount.Size = new System.Drawing.Size(165, 23);
            this.setThreadCount.TabIndex = 5;
            this.setThreadCount.Text = "Set Thread Count";
            this.setThreadCount.UseVisualStyleBackColor = true;
            this.setThreadCount.Click += new System.EventHandler(this.setThreadCount_Click);
            // 
            // txtThreshold
            // 
            this.txtThreshold.Location = new System.Drawing.Point(3, 218);
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(165, 23);
            this.txtThreshold.TabIndex = 4;
            this.txtThreshold.Text = "Threshold Value";
            this.txtThreshold.TextChanged += new System.EventHandler(this.txtThreshold_TextChanged);
            // 
            // btnThreshold
            // 
            this.btnThreshold.Location = new System.Drawing.Point(3, 247);
            this.btnThreshold.Name = "btnThreshold";
            this.btnThreshold.Size = new System.Drawing.Size(165, 23);
            this.btnThreshold.TabIndex = 3;
            this.btnThreshold.Text = "Product Similarity";
            this.btnThreshold.UseVisualStyleBackColor = true;
            this.btnThreshold.Click += new System.EventHandler(this.btnThreshold_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 79);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(165, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtThreadCount
            // 
            this.txtThreadCount.Location = new System.Drawing.Point(3, 21);
            this.txtThreadCount.Name = "txtThreadCount";
            this.txtThreadCount.Size = new System.Drawing.Size(165, 23);
            this.txtThreadCount.TabIndex = 1;
            this.txtThreadCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thread Count";
            // 
            // lstLog
            // 
            this.lstLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 15;
            this.lstLog.Location = new System.Drawing.Point(0, 0);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(664, 79);
            this.lstLog.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstLog);
            this.splitContainer1.Size = new System.Drawing.Size(664, 335);
            this.splitContainer1.SplitterDistance = 252;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvCSV);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvResult);
            this.splitContainer2.Size = new System.Drawing.Size(664, 252);
            this.splitContainer2.SplitterDistance = 218;
            this.splitContainer2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 359);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CSVProject";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaAçToolStripMenuItem;
        private DataGridView dgvCSV;
        private DataGridView dgvResult;
        private Panel panel1;
        private Button btnStart;
        private TextBox txtThreadCount;
        private Label label1;
        private Button btnThreshold;
        private TextBox txtThreshold;
        private ListBox lstLog;
        private SplitContainer splitContainer1;
        private Button setThreadCount;
        private SplitContainer splitContainer2;
        private Button btnIssueSimilarity;
        private Button btnCheckComplaint;
    }
}