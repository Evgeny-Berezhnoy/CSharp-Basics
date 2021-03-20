
namespace Questions_Application
{
    partial class Form_Task_3
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
            this.Button_Convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Convert
            // 
            this.Button_Convert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Convert.Location = new System.Drawing.Point(0, 0);
            this.Button_Convert.Name = "Button_Convert";
            this.Button_Convert.Size = new System.Drawing.Size(381, 53);
            this.Button_Convert.TabIndex = 0;
            this.Button_Convert.Text = "Конвертировать";
            this.Button_Convert.UseVisualStyleBackColor = true;
            this.Button_Convert.Click += new System.EventHandler(this.Button_Convert_Click);
            // 
            // Form_Task_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 53);
            this.Controls.Add(this.Button_Convert);
            this.Name = "Form_Task_3";
            this.Text = "Домашняя работа №8 - Задание №3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Convert;
    }
}