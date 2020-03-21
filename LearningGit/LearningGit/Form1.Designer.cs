namespace LearningGit
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textField = new System.Windows.Forms.RichTextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textField
            // 
            this.textField.Location = new System.Drawing.Point(293, 74);
            this.textField.Name = "textField";
            this.textField.Size = new System.Drawing.Size(421, 318);
            this.textField.TabIndex = 0;
            this.textField.Text = "";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(61, 74);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(153, 42);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show Hello World";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(61, 157);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(153, 44);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open new window";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.textField);
            this.Name = "Form1";
            this.Text = "Learning git";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textField;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button openButton;
    }
}

