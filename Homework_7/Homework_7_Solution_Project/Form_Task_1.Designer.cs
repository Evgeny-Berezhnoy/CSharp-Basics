
namespace Homework_7_Solution_Project
{
    partial class Form_Task_1
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
            this.TextBox_Number_User = new System.Windows.Forms.TextBox();
            this.Label_Number_User = new System.Windows.Forms.Label();
            this.RichTextBox_Assignment = new System.Windows.Forms.RichTextBox();
            this.RichTextBox_Parameters = new System.Windows.Forms.RichTextBox();
            this.Button_Number_User_Plus = new System.Windows.Forms.Button();
            this.Button_Number_User_Double = new System.Windows.Forms.Button();
            this.Button_Number_User_Revert = new System.Windows.Forms.Button();
            this.Button_Restart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_Number_User
            // 
            this.TextBox_Number_User.Location = new System.Drawing.Point(102, 180);
            this.TextBox_Number_User.Name = "TextBox_Number_User";
            this.TextBox_Number_User.ReadOnly = true;
            this.TextBox_Number_User.Size = new System.Drawing.Size(96, 20);
            this.TextBox_Number_User.TabIndex = 0;
            // 
            // Label_Number_User
            // 
            this.Label_Number_User.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Number_User.AutoSize = true;
            this.Label_Number_User.Location = new System.Drawing.Point(9, 183);
            this.Label_Number_User.Name = "Label_Number_User";
            this.Label_Number_User.Size = new System.Drawing.Size(87, 13);
            this.Label_Number_User.TabIndex = 1;
            this.Label_Number_User.Text = "Текущее число:";
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
            this.RichTextBox_Assignment.Size = new System.Drawing.Size(780, 61);
            this.RichTextBox_Assignment.TabIndex = 3;
            this.RichTextBox_Assignment.Text = "Вас приветствует игра \"Удваиватель\"!\n\nВаша задача - получить заданное число от 1 " +
    "до 100 путем использования предложенных операций.";
            // 
            // RichTextBox_Parameters
            // 
            this.RichTextBox_Parameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBox_Parameters.BackColor = System.Drawing.SystemColors.Control;
            this.RichTextBox_Parameters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox_Parameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBox_Parameters.ForeColor = System.Drawing.Color.Red;
            this.RichTextBox_Parameters.Location = new System.Drawing.Point(12, 91);
            this.RichTextBox_Parameters.Name = "RichTextBox_Parameters";
            this.RichTextBox_Parameters.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RichTextBox_Parameters.Size = new System.Drawing.Size(771, 61);
            this.RichTextBox_Parameters.TabIndex = 4;
            this.RichTextBox_Parameters.Text = "Требуется получить число: N\nЗа число шагов: M\nТекущее число шагов: L";
            // 
            // Button_Number_User_Plus
            // 
            this.Button_Number_User_Plus.Location = new System.Drawing.Point(204, 180);
            this.Button_Number_User_Plus.Name = "Button_Number_User_Plus";
            this.Button_Number_User_Plus.Size = new System.Drawing.Size(120, 20);
            this.Button_Number_User_Plus.TabIndex = 5;
            this.Button_Number_User_Plus.Text = "Добавить 1";
            this.Button_Number_User_Plus.UseVisualStyleBackColor = true;
            this.Button_Number_User_Plus.Click += new System.EventHandler(this.Button_Number_User_Plus_Click);
            // 
            // Button_Number_User_Double
            // 
            this.Button_Number_User_Double.Location = new System.Drawing.Point(204, 206);
            this.Button_Number_User_Double.Name = "Button_Number_User_Double";
            this.Button_Number_User_Double.Size = new System.Drawing.Size(120, 20);
            this.Button_Number_User_Double.TabIndex = 6;
            this.Button_Number_User_Double.Text = "Умножить на  2";
            this.Button_Number_User_Double.UseVisualStyleBackColor = true;
            this.Button_Number_User_Double.Click += new System.EventHandler(this.Button_Number_User_Double_Click);
            // 
            // Button_Number_User_Revert
            // 
            this.Button_Number_User_Revert.Location = new System.Drawing.Point(204, 232);
            this.Button_Number_User_Revert.Name = "Button_Number_User_Revert";
            this.Button_Number_User_Revert.Size = new System.Drawing.Size(120, 20);
            this.Button_Number_User_Revert.TabIndex = 7;
            this.Button_Number_User_Revert.Text = "Откат";
            this.Button_Number_User_Revert.UseVisualStyleBackColor = true;
            this.Button_Number_User_Revert.Click += new System.EventHandler(this.Button_Number_User_Revert_Click);
            // 
            // Button_Restart
            // 
            this.Button_Restart.Location = new System.Drawing.Point(693, 12);
            this.Button_Restart.Name = "Button_Restart";
            this.Button_Restart.Size = new System.Drawing.Size(99, 19);
            this.Button_Restart.TabIndex = 8;
            this.Button_Restart.Text = "Начать заново";
            this.Button_Restart.UseVisualStyleBackColor = true;
            this.Button_Restart.Click += new System.EventHandler(this.Button_Restart_Click);
            // 
            // Form_Task_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 267);
            this.Controls.Add(this.Button_Restart);
            this.Controls.Add(this.Button_Number_User_Revert);
            this.Controls.Add(this.Button_Number_User_Double);
            this.Controls.Add(this.Button_Number_User_Plus);
            this.Controls.Add(this.RichTextBox_Parameters);
            this.Controls.Add(this.RichTextBox_Assignment);
            this.Controls.Add(this.Label_Number_User);
            this.Controls.Add(this.TextBox_Number_User);
            this.Name = "Form_Task_1";
            this.Text = "Домашняя работа №7 - Задание №1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Number_User;
        private System.Windows.Forms.Label Label_Number_User;
        private System.Windows.Forms.RichTextBox RichTextBox_Assignment;
        private System.Windows.Forms.RichTextBox RichTextBox_Parameters;
        private System.Windows.Forms.Button Button_Number_User_Plus;
        private System.Windows.Forms.Button Button_Number_User_Double;
        private System.Windows.Forms.Button Button_Number_User_Revert;
        private System.Windows.Forms.Button Button_Restart;
    }
}