namespace AsyncBooksLab
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
            label1 = new Label();
            txtFile = new TextBox();
            lstReport = new ListBox();
            btnBrowse = new Button();
            btnExit = new Button();
            btnSubmit = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 51);
            label1.Name = "label1";
            label1.Size = new Size(38, 25);
            label1.TabIndex = 0;
            label1.Text = "File";
            // 
            // txtFile
            // 
            txtFile.Location = new Point(148, 51);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(308, 31);
            txtFile.TabIndex = 1;
            // 
            // lstReport
            // 
            lstReport.FormattingEnabled = true;
            lstReport.Location = new Point(88, 115);
            lstReport.Name = "lstReport";
            lstReport.Size = new Size(613, 229);
            lstReport.TabIndex = 2;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(562, 49);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(112, 34);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(166, 378);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(480, 378);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(btnExit);
            Controls.Add(btnBrowse);
            Controls.Add(lstReport);
            Controls.Add(txtFile);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFile;
        private ListBox lstReport;
        private Button btnBrowse;
        private Button btnExit;
        private Button btnSubmit;
        private OpenFileDialog openFileDialog1;
    }
}
