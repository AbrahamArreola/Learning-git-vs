namespace LearningGit
{
    partial class Form2
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
            this.passButton = new System.Windows.Forms.Button();
            this.msgText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // passButton
            // 
            this.passButton.Location = new System.Drawing.Point(221, 142);
            this.passButton.Name = "passButton";
            this.passButton.Size = new System.Drawing.Size(125, 48);
            this.passButton.TabIndex = 0;
            this.passButton.Text = "Pass text";
            this.passButton.UseVisualStyleBackColor = true;
            this.passButton.Click += new System.EventHandler(this.passButton_Click);
            // 
            // msgText
            // 
            this.msgText.Location = new System.Drawing.Point(140, 68);
            this.msgText.Name = "msgText";
            this.msgText.Size = new System.Drawing.Size(287, 22);
            this.msgText.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 285);
            this.Controls.Add(this.msgText);
            this.Controls.Add(this.passButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button passButton;
        private System.Windows.Forms.TextBox msgText;
    }
}