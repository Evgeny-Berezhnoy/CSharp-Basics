using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questions_Application
{
    public partial class Form_Questions_Edit : Form {

        #region Form properties

        private Questions_File Questions_File_Current;

        private int Questions_File_Current_Index; 

        private bool IsModified = false;

        #endregion

        #region Constructors

        public Form_Questions_Edit() {

            InitializeComponent();

            Set_FormParameters(-1);

        }
        
        #endregion

        #region Drop down menu commands

        private void Panel_File_New_Click(object sender, EventArgs e) {

            if (!(File_CommandPermitted())) {

                return;

            };

            Questions_File_Current = new Questions_File();

            Set_FormParameters(0);

            IsModified = false;

        }

        private void Panel_File_Open_Click(object sender, EventArgs e) {

            if (!(File_CommandPermitted())) {

                return;

            };

            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            if (openFileDialog.ShowDialog() == DialogResult.OK) {

                Questions_File_Current = new Questions_File(openFileDialog.FileName);
                
                Set_FormParameters(0);

                IsModified = false;

            };

        }
        
        private void Panel_File_Save_Click(object sender, EventArgs e) {

            Questions_File_Current_TrySaveCurrentQuestion();

            if (!(IsModified)) {

                // No rectifications
                MessageBox.Show("Нет внесенных изменений.");

                return;

            };

            if (Questions_File_Current.Directory.Equals("")) {

                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() != DialogResult.OK) {

                    return;
                    
                };

                Questions_File_Current.Directory = saveFileDialog.FileName;

            };

            Questions_File_Current.Save();

            IsModified = false;

        }

        private void Panel_File_SaveAs_Click(object sender, EventArgs e) {

            Questions_File_Current_TrySaveCurrentQuestion();

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() != DialogResult.OK) {

                return;

            };

            Questions_File_Current.Directory = saveFileDialog.FileName;

            Questions_File_Current.Save();

            IsModified = false;
            
        }

        private void Panel_File_Exit_Click(object sender, EventArgs e) {
            
            if (!(File_CommandPermitted())) {

                return;

            };

            Close();

        }

        #endregion

        #region Top buttons

        private void Top_Buttons_Add_Click(object sender, EventArgs e) {

            Questions_File_Current_TrySaveCurrentQuestion();

            Questions_File_Current.Add();
            
            IsModified = true;

            Set_FormParameters(Questions_File_Current.Count - 1);

        }

        private void Top_Buttons_Save_Click(object sender, EventArgs e) {

            // Check if values of current question are changed
            Question Question_Current = Questions_File_Current[Questions_File_Current_Index];

            if (!(Question_Current.Text.Equals(Question_Current_Text.Text)
                    && Question_Current.IsTrue == Question_Current_IsTrue.Checked)) {

                Question_Current.Text   = Question_Current_Text.Text;
                Question_Current.IsTrue = Question_Current_IsTrue.Checked;

                IsModified = true;

            };

        }

        private void Top_Buttons_Delete_Click(object sender, EventArgs e) {

            try {

                Questions_File_Current.Remove(Questions_File_Current_Index);

                IsModified = true;
                
                Set_FormParameters(Questions_File_Current_Index - 1);

            } catch (Exception Exception_current) {

                MessageBox.Show($"Не удалось удалить вопрос. Произошла ошибка: {Exception_current.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            };

        }

        #endregion

        #region Form information elements

        private void Question_Number_ValueChanged(object sender, EventArgs e) {

            Questions_File_Current_TrySaveCurrentQuestion();

            // Switch to another question
            Questions_File_Current_Index = (int)Question_Number.Value - 1;

            Set_FormParameters(Questions_File_Current_Index);

        }

        #endregion


        #region Common methods

        private void Set_FormParameters(int Index) {

            if (Questions_File_Current == null) {

                // Setting parameters
                // Current question index
                Questions_File_Current_Index    = -1;

                // Drop  menu buttons
                Panel_File_New.Enabled          = true;
                Panel_File_Open.Enabled         = true;
                Panel_File_Save.Enabled         = false;
                Panel_File_SaveAs.Enabled       = false;
                Panel_Exit.Enabled              = true;

                // Questions amount label
                Label_Questions_Amount.Visible  = false;
                Label_Questions_Amount.Text     = "/ 0";

                // Correct answer tick
                Question_Current_IsTrue.Visible = false;
                Question_Current_IsTrue.Checked = false;
                
                // Top buttuns
                Button_Add.Visible              = false;
                Button_Delete.Visible           = false;
                Button_Save.Visible             = false;

                // Question textbox
                Question_Current_Text.Visible   = false;
                Question_Current_Text.Text      = "";
                
                // Question quantity
                Question_Number.Visible         = false;
                Question_Number.Minimum         = 0;
                Question_Number.Maximum         = 0;
                Question_Number.Value           = 0;

            }
            else if (Questions_File_Current.Count == 0) {

                // Setting parameters
                // Current question index
                Questions_File_Current_Index    = -1;

                // Drop  menu buttons
                Panel_File_New.Enabled          = true;
                Panel_File_Open.Enabled         = true;
                Panel_File_Save.Enabled         = false;
                Panel_File_SaveAs.Enabled       = false;
                Panel_Exit.Enabled              = true;

                // Questions amount label
                Label_Questions_Amount.Visible = true;
                Label_Questions_Amount.Text    = "/ 0";

                // Correct answer tick
                Question_Current_IsTrue.Visible = false;
                Question_Current_IsTrue.Checked = false;

                // Top buttuns
                Button_Add.Visible              = true;
                Button_Delete.Visible           = false;
                Button_Save.Visible             = false;
            
                // Question textbox
                Question_Current_Text.Visible   = false;
                Question_Current_Text.Text      = "";
                
                // Question quantity
                Question_Number.Visible         = true;
                Question_Number.Minimum         = 0;
                Question_Number.Maximum         = 0;
                Question_Number.Value           = 0;
                
            } else if (Index <= 0) {

                // Setting parameters
                // Current question index
                Questions_File_Current_Index    = 0;

                // Drop  menu buttons
                Panel_File_New.Enabled          = true;
                Panel_File_Open.Enabled         = true;
                Panel_File_Save.Enabled         = true;
                Panel_File_SaveAs.Enabled       = true;
                Panel_Exit.Enabled              = true;

                // Questions amount label
                Label_Questions_Amount.Visible  = true;
                Label_Questions_Amount.Text     = $"/ {Questions_File_Current.Count}";

                // Correct answer tick
                Question_Current_IsTrue.Visible = true;
                Question_Current_IsTrue.Checked = Questions_File_Current[0].IsTrue;

                // Top buttuns
                Button_Add.Visible              = true;
                Button_Delete.Visible           = true;
                Button_Save.Visible             = true;

                // Question textbox
                Question_Current_Text.Visible   = true;
                Question_Current_Text.Text      = Questions_File_Current[0].Text;
                
                // Question quantity
                Question_Number.Visible         = true;
                Question_Number.Minimum         = 1;
                Question_Number.Maximum         = Questions_File_Current.Count;
                Question_Number.Value           = 1;
                
            } else if (Index >= Questions_File_Current.Count) {

                // Setting parameters
                // Current question index
                Questions_File_Current_Index    = Questions_File_Current.Count - 1;

                // Drop  menu buttons
                Panel_File_New.Enabled          = true;
                Panel_File_Open.Enabled         = true;
                Panel_File_Save.Enabled         = true;
                Panel_File_SaveAs.Enabled       = true;
                Panel_Exit.Enabled              = true;

                // Questions amount label
                Label_Questions_Amount.Visible = true;
                Label_Questions_Amount.Text     = $"/ {Questions_File_Current.Count}";

                // Correct answer tick
                Question_Current_IsTrue.Visible = true;
                Question_Current_IsTrue.Checked = Questions_File_Current[Questions_File_Current.Count - 1].IsTrue;

                // Top buttuns
                Button_Add.Visible              = true;
                Button_Delete.Visible           = true;
                Button_Save.Visible             = true;

                // Question textbox
                Question_Current_Text.Visible   = true;
                Question_Current_Text.Text      = Questions_File_Current[Questions_File_Current.Count - 1].Text;
                
                // Question quantity
                Question_Number.Visible         = true;
                Question_Number.Minimum         = 1;
                Question_Number.Maximum         = Questions_File_Current.Count;
                Question_Number.Value           = Questions_File_Current.Count;
                
            } else {

                // Setting parameters
                // Current question index
                Questions_File_Current_Index    = Index;

                // Drop  menu buttons
                Panel_File_New.Enabled          = true;
                Panel_File_Open.Enabled         = true;
                Panel_File_Save.Enabled         = true;
                Panel_File_SaveAs.Enabled       = true;
                Panel_Exit.Enabled              = true;

                // Questions amount label
                Label_Questions_Amount.Visible  = true;
                Label_Questions_Amount.Text     = $"/ {Questions_File_Current.Count}";

                // Correct answer tick
                Question_Current_IsTrue.Visible = true;
                Question_Current_IsTrue.Checked = Questions_File_Current[Index].IsTrue;

                // Top buttuns
                Button_Add.Visible              = true;
                Button_Delete.Visible           = true;
                Button_Save.Visible             = true;

                // Question textbox
                Question_Current_Text.Visible   = true;
                Question_Current_Text.Text      = Questions_File_Current[Index].Text;

                // Question quantity
                Question_Number.Visible         = true;
                Question_Number.Minimum         = 1;
                Question_Number.Maximum         = Questions_File_Current.Count;
                Question_Number.Value           = Index + 1;
                
            };
            
        }

        private bool File_CommandPermitted() {

            if (this.IsModified) {

                DialogResult User_Question_Result = MessageBox.Show("Внесенные изменения будут утеряны. Продолжить?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (User_Question_Result == DialogResult.No) {

                    return false;

                };

            };

            return true;

        }

        private void Questions_File_Current_TrySaveCurrentQuestion() {

            if (Questions_File_Current_Index == -1) {

                return;

            };

            // Check if values of current question are changed
            Question Question_Prior = Questions_File_Current[Questions_File_Current_Index];

            if (!(Question_Prior.Text.Equals(Question_Current_Text.Text)
                    && Question_Prior.IsTrue == Question_Current_IsTrue.Checked)) {

                DialogResult User_Question_Result = MessageBox.Show("Внесенные изменения не сохранены. Сохранить?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (User_Question_Result == DialogResult.Yes)
                {

                    Question_Prior.Text     = Question_Current_Text.Text;
                    Question_Prior.IsTrue   = Question_Current_IsTrue.Checked;

                    IsModified = true;

                } else {

                    Question_Current_Text.Text      = Question_Prior.Text;
                    Question_Current_IsTrue.Checked = Question_Prior.IsTrue;
                    
                };

            };

        }

        #endregion

        
    }

}
