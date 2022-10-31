
namespace XMLtoCSV
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CSVFilePath = new System.Windows.Forms.TextBox();
            this.XMLFilePath = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CSVFilePath);
            this.groupBox1.Controls.Add(this.XMLFilePath);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.openButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Info";
            // 
            // CSVFilePath
            // 
            this.CSVFilePath.Location = new System.Drawing.Point(138, 82);
            this.CSVFilePath.Name = "CSVFilePath";
            this.CSVFilePath.ReadOnly = true;
            this.CSVFilePath.Size = new System.Drawing.Size(215, 29);
            this.CSVFilePath.TabIndex = 3;
            // 
            // XMLFilePath
            // 
            this.XMLFilePath.Location = new System.Drawing.Point(138, 32);
            this.XMLFilePath.Name = "XMLFilePath";
            this.XMLFilePath.ReadOnly = true;
            this.XMLFilePath.Size = new System.Drawing.Size(215, 29);
            this.XMLFilePath.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(13, 78);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 34);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(13, 28);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(110, 34);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 155);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "XML to CSV - Vanlalruata Hnamte";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CSVFilePath;
        private System.Windows.Forms.TextBox XMLFilePath;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
    }
}

