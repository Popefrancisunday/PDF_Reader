namespace PDF_Reader
{
    partial class Pdf_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pdf_form));
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.Open_file = new System.Windows.Forms.Button();
            this.Other_files = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(24, 68);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(701, 364);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // Open_file
            // 
            this.Open_file.BackColor = System.Drawing.SystemColors.Highlight;
            this.Open_file.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_file.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Open_file.Location = new System.Drawing.Point(24, 12);
            this.Open_file.Name = "Open_file";
            this.Open_file.Size = new System.Drawing.Size(126, 37);
            this.Open_file.TabIndex = 1;
            this.Open_file.Text = "Open pdf File";
            this.Open_file.UseVisualStyleBackColor = false;
            this.Open_file.Click += new System.EventHandler(this.Open_file_Click);
            // 
            // Other_files
            // 
            this.Other_files.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Other_files.BackColor = System.Drawing.SystemColors.Highlight;
            this.Other_files.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Other_files.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Other_files.Location = new System.Drawing.Point(610, 12);
            this.Other_files.Name = "Other_files";
            this.Other_files.Size = new System.Drawing.Size(115, 36);
            this.Other_files.TabIndex = 2;
            this.Other_files.Text = "Other Files";
            this.Other_files.UseVisualStyleBackColor = false;
            this.Other_files.Click += new System.EventHandler(this.Other_files_Click);
            // 
            // Pdf_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(749, 444);
            this.Controls.Add(this.Other_files);
            this.Controls.Add(this.Open_file);
            this.Controls.Add(this.axAcroPDF1);
            this.MinimumSize = new System.Drawing.Size(765, 483);
            this.Name = "Pdf_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Reader";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button Open_file;
        private System.Windows.Forms.Button Other_files;
    }
}

