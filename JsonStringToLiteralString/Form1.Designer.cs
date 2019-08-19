namespace JsonStringToLiteralString
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
            this.copyToClipboard = new System.Windows.Forms.Button();
            this.formattedLiteralText = new System.Windows.Forms.TextBox();
            this.convertJsonToLiteralString = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // copyToClipboard
            // 
            this.copyToClipboard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.copyToClipboard.Location = new System.Drawing.Point(0, 622);
            this.copyToClipboard.Name = "copyToClipboard";
            this.copyToClipboard.Size = new System.Drawing.Size(1164, 30);
            this.copyToClipboard.TabIndex = 3;
            this.copyToClipboard.Text = "Copy to Clipboard";
            this.copyToClipboard.UseVisualStyleBackColor = true;
            this.copyToClipboard.Click += new System.EventHandler(this.CopyToClipboard_Click);
            // 
            // formattedLiteralText
            // 
            this.formattedLiteralText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formattedLiteralText.Location = new System.Drawing.Point(0, 451);
            this.formattedLiteralText.Multiline = true;
            this.formattedLiteralText.Name = "formattedLiteralText";
            this.formattedLiteralText.Size = new System.Drawing.Size(1164, 171);
            this.formattedLiteralText.TabIndex = 7;
            // 
            // convertJsonToLiteralString
            // 
            this.convertJsonToLiteralString.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.convertJsonToLiteralString.Location = new System.Drawing.Point(0, 421);
            this.convertJsonToLiteralString.Name = "convertJsonToLiteralString";
            this.convertJsonToLiteralString.Size = new System.Drawing.Size(1164, 30);
            this.convertJsonToLiteralString.TabIndex = 8;
            this.convertJsonToLiteralString.Text = "Convert To Literal String";
            this.convertJsonToLiteralString.UseVisualStyleBackColor = true;
            this.convertJsonToLiteralString.Click += new System.EventHandler(this.ConvertJsonToLiteralString_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBox.Location = new System.Drawing.Point(0, 0);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(1164, 421);
            this.inputTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 652);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.convertJsonToLiteralString);
            this.Controls.Add(this.formattedLiteralText);
            this.Controls.Add(this.copyToClipboard);
            this.Name = "Form1";
            this.Text = "Convert Json to Literal String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button copyToClipboard;
        private System.Windows.Forms.TextBox formattedLiteralText;
        private System.Windows.Forms.Button convertJsonToLiteralString;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}

