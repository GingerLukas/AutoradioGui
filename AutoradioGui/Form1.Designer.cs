namespace AutoradioGui
{
    partial class Form1
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
            this._btnSelectFolder = new System.Windows.Forms.Button();
            this._rtbResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // _btnSelectFolder
            // 
            this._btnSelectFolder.Location = new System.Drawing.Point(20, 16);
            this._btnSelectFolder.Name = "_btnSelectFolder";
            this._btnSelectFolder.Size = new System.Drawing.Size(106, 38);
            this._btnSelectFolder.TabIndex = 0;
            this._btnSelectFolder.Text = "Select Folder";
            this._btnSelectFolder.UseVisualStyleBackColor = true;
            this._btnSelectFolder.Click += new System.EventHandler(this._btnSelectFolder_Click);
            // 
            // _rtbResult
            // 
            this._rtbResult.Location = new System.Drawing.Point(18, 72);
            this._rtbResult.Name = "_rtbResult";
            this._rtbResult.Size = new System.Drawing.Size(770, 366);
            this._rtbResult.TabIndex = 1;
            this._rtbResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._rtbResult);
            this.Controls.Add(this._btnSelectFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RichTextBox _rtbResult;

        private System.Windows.Forms.Button _btnSelectFolder;

        #endregion
    }
}