namespace Questions_Application
{
    partial class Form_Questions_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Questions_Edit));
            this.Panel_QuestionParameters = new System.Windows.Forms.Panel();
            this.Label_Questions_Amount = new System.Windows.Forms.Label();
            this.Question_Number = new System.Windows.Forms.NumericUpDown();
            this.Question_Current_IsTrue = new System.Windows.Forms.CheckBox();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Panel_File = new System.Windows.Forms.ToolStripDropDownButton();
            this.Panel_File_New = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Panel_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Question_Current_Text = new System.Windows.Forms.TextBox();
            this.Panel_QuestionParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Question_Number)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_QuestionParameters
            // 
            this.Panel_QuestionParameters.Controls.Add(this.Label_Questions_Amount);
            this.Panel_QuestionParameters.Controls.Add(this.Question_Number);
            this.Panel_QuestionParameters.Controls.Add(this.Question_Current_IsTrue);
            this.Panel_QuestionParameters.Controls.Add(this.Button_Save);
            this.Panel_QuestionParameters.Controls.Add(this.Button_Delete);
            this.Panel_QuestionParameters.Controls.Add(this.Button_Add);
            this.Panel_QuestionParameters.Location = new System.Drawing.Point(0, 28);
            this.Panel_QuestionParameters.Name = "Panel_QuestionParameters";
            this.Panel_QuestionParameters.Size = new System.Drawing.Size(649, 37);
            this.Panel_QuestionParameters.TabIndex = 0;
            // 
            // Label_Questions_Amount
            // 
            this.Label_Questions_Amount.AutoSize = true;
            this.Label_Questions_Amount.Location = new System.Drawing.Point(99, 13);
            this.Label_Questions_Amount.Name = "Label_Questions_Amount";
            this.Label_Questions_Amount.Size = new System.Drawing.Size(104, 13);
            this.Label_Questions_Amount.TabIndex = 4;
            this.Label_Questions_Amount.Text = "/ Questions_Amount";
            // 
            // Question_Number
            // 
            this.Question_Number.Location = new System.Drawing.Point(8, 8);
            this.Question_Number.Name = "Question_Number";
            this.Question_Number.Size = new System.Drawing.Size(85, 20);
            this.Question_Number.TabIndex = 1;
            this.Question_Number.ValueChanged += new System.EventHandler(this.Question_Number_ValueChanged);
            // 
            // Question_Current_IsTrue
            // 
            this.Question_Current_IsTrue.AutoSize = true;
            this.Question_Current_IsTrue.Location = new System.Drawing.Point(209, 12);
            this.Question_Current_IsTrue.Name = "Question_Current_IsTrue";
            this.Question_Current_IsTrue.Size = new System.Drawing.Size(109, 17);
            this.Question_Current_IsTrue.TabIndex = 1;
            this.Question_Current_IsTrue.Text = "Statement is valid";
            this.Question_Current_IsTrue.UseVisualStyleBackColor = true;
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(567, 8);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(75, 23);
            this.Button_Save.TabIndex = 2;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Top_Buttons_Save_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Location = new System.Drawing.Point(487, 8);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(75, 23);
            this.Button_Delete.TabIndex = 3;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Top_Buttons_Delete_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(406, 8);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Button_Add.TabIndex = 1;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Top_Buttons_Add_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Panel_File});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(649, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Panel_File
            // 
            this.Panel_File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Panel_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Panel_File_New,
            this.Panel_File_Open,
            this.Panel_File_Save,
            this.Panel_File_SaveAs,
            this.toolStripSeparator1,
            this.Panel_Exit});
            this.Panel_File.Image = ((System.Drawing.Image)(resources.GetObject("Panel_File.Image")));
            this.Panel_File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Panel_File.Name = "Panel_File";
            this.Panel_File.Size = new System.Drawing.Size(38, 22);
            this.Panel_File.Text = "File";
            // 
            // Panel_File_New
            // 
            this.Panel_File_New.Name = "Panel_File_New";
            this.Panel_File_New.Size = new System.Drawing.Size(180, 22);
            this.Panel_File_New.Text = "New";
            this.Panel_File_New.Click += new System.EventHandler(this.Panel_File_New_Click);
            // 
            // Panel_File_Open
            // 
            this.Panel_File_Open.Name = "Panel_File_Open";
            this.Panel_File_Open.Size = new System.Drawing.Size(180, 22);
            this.Panel_File_Open.Text = "Open";
            this.Panel_File_Open.Click += new System.EventHandler(this.Panel_File_Open_Click);
            // 
            // Panel_File_Save
            // 
            this.Panel_File_Save.Name = "Panel_File_Save";
            this.Panel_File_Save.Size = new System.Drawing.Size(180, 22);
            this.Panel_File_Save.Text = "Save";
            this.Panel_File_Save.Click += new System.EventHandler(this.Panel_File_Save_Click);
            // 
            // Panel_File_SaveAs
            // 
            this.Panel_File_SaveAs.Name = "Panel_File_SaveAs";
            this.Panel_File_SaveAs.Size = new System.Drawing.Size(180, 22);
            this.Panel_File_SaveAs.Text = "Save as...";
            this.Panel_File_SaveAs.Click += new System.EventHandler(this.Panel_File_SaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // Panel_Exit
            // 
            this.Panel_Exit.Name = "Panel_Exit";
            this.Panel_Exit.Size = new System.Drawing.Size(180, 22);
            this.Panel_Exit.Text = "Exit";
            this.Panel_Exit.Click += new System.EventHandler(this.Panel_File_Exit_Click);
            // 
            // Question_Current_Text
            // 
            this.Question_Current_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Question_Current_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question_Current_Text.Location = new System.Drawing.Point(0, 71);
            this.Question_Current_Text.Multiline = true;
            this.Question_Current_Text.Name = "Question_Current_Text";
            this.Question_Current_Text.Size = new System.Drawing.Size(649, 302);
            this.Question_Current_Text.TabIndex = 2;
            // 
            // Form_Questions_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 373);
            this.Controls.Add(this.Question_Current_Text);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Panel_QuestionParameters);
            this.Name = "Form_Questions_Edit";
            this.Text = "Домашняя работа №8 - Задание №1";
            this.Panel_QuestionParameters.ResumeLayout(false);
            this.Panel_QuestionParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Question_Number)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_QuestionParameters;
        private System.Windows.Forms.NumericUpDown Question_Number;
        private System.Windows.Forms.CheckBox Question_Current_IsTrue;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton Panel_File;
        private System.Windows.Forms.ToolStripMenuItem Panel_File_New;
        private System.Windows.Forms.ToolStripMenuItem Panel_File_Open;
        private System.Windows.Forms.ToolStripMenuItem Panel_File_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Panel_Exit;
        private System.Windows.Forms.TextBox Question_Current_Text;
        private System.Windows.Forms.ToolStripMenuItem Panel_File_SaveAs;
        private System.Windows.Forms.Label Label_Questions_Amount;
    }
}

