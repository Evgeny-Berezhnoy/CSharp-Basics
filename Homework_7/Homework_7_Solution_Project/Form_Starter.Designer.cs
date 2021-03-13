
namespace Homework_7_Solution_Project
{
    partial class Form_Starter
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Link_Task_1 = new System.Windows.Forms.LinkLabel();
            this.Link_Task_2 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Link_Task_1
            // 
            this.Link_Task_1.AutoSize = true;
            this.Link_Task_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Link_Task_1.Location = new System.Drawing.Point(56, 76);
            this.Link_Task_1.Name = "Link_Task_1";
            this.Link_Task_1.Size = new System.Drawing.Size(260, 25);
            this.Link_Task_1.TabIndex = 0;
            this.Link_Task_1.TabStop = true;
            this.Link_Task_1.Text = "Задание №1 - Удвоитель";
            this.Link_Task_1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Task_1_LinkClicked);
            // 
            // Link_Task_2
            // 
            this.Link_Task_2.AutoSize = true;
            this.Link_Task_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Link_Task_2.Location = new System.Drawing.Point(56, 117);
            this.Link_Task_2.Name = "Link_Task_2";
            this.Link_Task_2.Size = new System.Drawing.Size(247, 25);
            this.Link_Task_2.TabIndex = 1;
            this.Link_Task_2.TabStop = true;
            this.Link_Task_2.Text = "Задание №2 - Угадайка";
            this.Link_Task_2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Task_2_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Я хочу сыграть с тобой в одну игру...";
            // 
            // Form_Starter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Link_Task_2);
            this.Controls.Add(this.Link_Task_1);
            this.Name = "Form_Starter";
            this.Text = "Домашняя работа №7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Link_Task_1;
        private System.Windows.Forms.LinkLabel Link_Task_2;
        private System.Windows.Forms.Label label1;
    }
}

