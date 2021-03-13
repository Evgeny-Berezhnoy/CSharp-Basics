
namespace Homework_7_Solution_Project
{
    partial class Form_Task_2
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
            this.Button_Restart = new System.Windows.Forms.Button();
            this.RichTextBox_Parameters = new System.Windows.Forms.RichTextBox();
            this.RichTextBox_Assignment = new System.Windows.Forms.RichTextBox();
            this.Label_Number_User = new System.Windows.Forms.Label();
            this.TextBox_Number_User = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Restart
            // 
            this.Button_Restart.Location = new System.Drawing.Point(604, 12);
            this.Button_Restart.Name = "Button_Restart";
            this.Button_Restart.Size = new System.Drawing.Size(99, 19);
            this.Button_Restart.TabIndex = 16;
            this.Button_Restart.Text = "Начать заново";
            this.Button_Restart.UseVisualStyleBackColor = true;
            this.Button_Restart.Click += new System.EventHandler(this.Button_Restart_Click);
            // 
            // RichTextBox_Parameters
            // 
            this.RichTextBox_Parameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBox_Parameters.BackColor = System.Drawing.SystemColors.Control;
            this.RichTextBox_Parameters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox_Parameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBox_Parameters.ForeColor = System.Drawing.Color.Black;
            this.RichTextBox_Parameters.Location = new System.Drawing.Point(12, 91);
            this.RichTextBox_Parameters.Name = "RichTextBox_Parameters";
            this.RichTextBox_Parameters.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RichTextBox_Parameters.Size = new System.Drawing.Size(681, 20);
            this.RichTextBox_Parameters.TabIndex = 12;
            this.RichTextBox_Parameters.Text = "Осталось попыток: N";
            // 
            // RichTextBox_Assignment
            // 
            this.RichTextBox_Assignment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBox_Assignment.BackColor = System.Drawing.SystemColors.Control;
            this.RichTextBox_Assignment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox_Assignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBox_Assignment.Location = new System.Drawing.Point(12, 12);
            this.RichTextBox_Assignment.Name = "RichTextBox_Assignment";
            this.RichTextBox_Assignment.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RichTextBox_Assignment.Size = new System.Drawing.Size(690, 61);
            this.RichTextBox_Assignment.TabIndex = 11;
            this.RichTextBox_Assignment.Text = "Вас приветствует игра \"Угадайка\"!\n\nВаша задача - угадать заданное число от 1 до 1" +
    "00 за 10 попыток.";
            // 
            // Label_Number_User
            // 
            this.Label_Number_User.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Number_User.AutoSize = true;
            this.Label_Number_User.Location = new System.Drawing.Point(9, 130);
            this.Label_Number_User.Name = "Label_Number_User";
            this.Label_Number_User.Size = new System.Drawing.Size(87, 13);
            this.Label_Number_User.TabIndex = 10;
            this.Label_Number_User.Text = "Текущее число:";
            // 
            // TextBox_Number_User
            // 
            this.TextBox_Number_User.Location = new System.Drawing.Point(102, 127);
            this.TextBox_Number_User.Name = "TextBox_Number_User";
            this.TextBox_Number_User.Size = new System.Drawing.Size(96, 20);
            this.TextBox_Number_User.TabIndex = 9;
            this.TextBox_Number_User.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_Number_User_KeyUp);
            // 
            // Form_Task_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 274);
            this.Controls.Add(this.Button_Restart);
            this.Controls.Add(this.RichTextBox_Parameters);
            this.Controls.Add(this.RichTextBox_Assignment);
            this.Controls.Add(this.Label_Number_User);
            this.Controls.Add(this.TextBox_Number_User);
            this.MaximumSize = new System.Drawing.Size(726, 313);
            this.MinimumSize = new System.Drawing.Size(726, 313);
            this.Name = "Form_Task_2";
            this.Text = "Домашняя работа №7 - Задание №2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Restart;
        private System.Windows.Forms.RichTextBox RichTextBox_Parameters;
        private System.Windows.Forms.RichTextBox RichTextBox_Assignment;
        private System.Windows.Forms.Label Label_Number_User;
        private System.Windows.Forms.TextBox TextBox_Number_User;
    }
}