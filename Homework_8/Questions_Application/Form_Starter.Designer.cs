
namespace Questions_Application
{
    partial class Form_Starter
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
            this.Link_Task_1 = new System.Windows.Forms.LinkLabel();
            this.Link_Task_2 = new System.Windows.Forms.LinkLabel();
            this.Link_Task_3 = new System.Windows.Forms.LinkLabel();
            this.Info = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Link_Task_1
            // 
            this.Link_Task_1.AutoSize = true;
            this.Link_Task_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Link_Task_1.Location = new System.Drawing.Point(59, 43);
            this.Link_Task_1.Name = "Link_Task_1";
            this.Link_Task_1.Size = new System.Drawing.Size(555, 24);
            this.Link_Task_1.TabIndex = 0;
            this.Link_Task_1.TabStop = true;
            this.Link_Task_1.Text = "Задание №1 - Редактирование файлов игр \"Верю - не верю\"";
            this.Link_Task_1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Task_1_LinkClicked);
            // 
            // Link_Task_2
            // 
            this.Link_Task_2.AutoSize = true;
            this.Link_Task_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Link_Task_2.Location = new System.Drawing.Point(59, 88);
            this.Link_Task_2.Name = "Link_Task_2";
            this.Link_Task_2.Size = new System.Drawing.Size(339, 24);
            this.Link_Task_2.TabIndex = 1;
            this.Link_Task_2.TabStop = true;
            this.Link_Task_2.Text = "Задание №2 - Игра \"Верю - не верю\"";
            this.Link_Task_2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Task_2_LinkClicked);
            // 
            // Link_Task_3
            // 
            this.Link_Task_3.AutoSize = true;
            this.Link_Task_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Link_Task_3.Location = new System.Drawing.Point(59, 135);
            this.Link_Task_3.Name = "Link_Task_3";
            this.Link_Task_3.Size = new System.Drawing.Size(330, 24);
            this.Link_Task_3.TabIndex = 2;
            this.Link_Task_3.TabStop = true;
            this.Link_Task_3.Text = "Задание №3 - Конвертация файлов";
            this.Link_Task_3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Task_3_LinkClicked);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(646, 9);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(142, 13);
            this.Info.TabIndex = 3;
            this.Info.TabStop = true;
            this.Info.Text = "Информация о программе";
            this.Info.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Info_LinkClicked);
            // 
            // Form_Starter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Link_Task_3);
            this.Controls.Add(this.Link_Task_2);
            this.Controls.Add(this.Link_Task_1);
            this.Name = "Form_Starter";
            this.Text = "Домашняя работа №8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Link_Task_1;
        private System.Windows.Forms.LinkLabel Link_Task_2;
        private System.Windows.Forms.LinkLabel Link_Task_3;
        private System.Windows.Forms.LinkLabel Info;
    }
}