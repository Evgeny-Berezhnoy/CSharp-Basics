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
    public partial class Form_Task_2 : Form {

        #region Fields

        private Questions_File Questions_File_Current;

        private List<Question> Question_List;

        #endregion

        #region Constructors

        public Form_Task_2() {

            InitializeComponent();

            Set_FormParameters();

        }

        #endregion

        #region Drop down menu

        private void Open_Click(object sender, EventArgs e) {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK) {

                Questions_File Questions_File_Current_Copy = new Questions_File(openFileDialog.FileName);

                if (Questions_File_Current_Copy.Count < 5) {

                    MessageBox.Show("Файл должен иметь не менее 5 утверждений.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;

                };

                Questions_File_Current = Questions_File_Current_Copy;

                Set_FormParameters();

            };

        }

        private void Restart_Click(object sender, EventArgs e) {

            Game_Restart();

        }

        private void Exit_Click(object sender, EventArgs e) {

            Close();

        }

        #endregion

        #region Bottom buttons

        private void Button_Check_Click(object sender, EventArgs e) {

            int CorrectAnswers = 0;

            // Question 1
            if (Question_IsTrue_1.Checked == Question_List[0].IsTrue) {

                Question_Text_1.BackColor = Color.LightGreen;

                CorrectAnswers++;

            } else {

                Question_Text_1.BackColor = Color.LightPink;

            };

            // Question 2
            if (Question_IsTrue_2.Checked == Question_List[1].IsTrue) {

                Question_Text_2.BackColor = Color.LightGreen;

                CorrectAnswers++;

            } else {

                Question_Text_2.BackColor = Color.LightPink;

            };

            // Question 3
            if (Question_IsTrue_3.Checked == Question_List[2].IsTrue) {

                Question_Text_3.BackColor = Color.LightGreen;

                CorrectAnswers++;

            } else {

                Question_Text_3.BackColor = Color.LightPink;

            };

            // Question 4
            if (Question_IsTrue_4.Checked == Question_List[3].IsTrue) {

                Question_Text_4.BackColor = Color.LightGreen;

                CorrectAnswers++;

            } else {

                Question_Text_4.BackColor = Color.LightPink;

            };

            // Question 5
            if (Question_IsTrue_5.Checked == Question_List[4].IsTrue) {

                Question_Text_5.BackColor = Color.LightGreen;

                CorrectAnswers++;

            } else {

                Question_Text_5.BackColor = Color.LightPink;

            };

            MessageBox.Show($"Количество верных ответов: {CorrectAnswers}", "Результаты игры", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        #endregion

        #region Common methods

        private void Set_FormParameters() {

            if (Questions_File_Current == null) {

                // Setting parameters
                // Drop  menu buttons
                Restart.Enabled         = false;

                // Questions texts
                Question_Text_1.Visible = false;
                Question_Text_2.Visible = false;
                Question_Text_3.Visible = false;
                Question_Text_4.Visible = false;
                Question_Text_5.Visible = false;

                // Questions answers
                Question_IsTrue_1.Visible = false;
                Question_IsTrue_2.Visible = false;
                Question_IsTrue_3.Visible = false;
                Question_IsTrue_4.Visible = false;
                Question_IsTrue_5.Visible = false;

                // Bottom buttons
                Button_Check.Visible = false;

            } else if (Questions_File_Current.Count == 0) {

                // Setting parameters
                // Drop  menu buttons
                Restart.Enabled = false;

                // Questions texts
                Question_Text_1.Visible = false;
                Question_Text_2.Visible = false;
                Question_Text_3.Visible = false;
                Question_Text_4.Visible = false;
                Question_Text_5.Visible = false;

                // Questions answers
                Question_IsTrue_1.Visible = false;
                Question_IsTrue_2.Visible = false;
                Question_IsTrue_3.Visible = false;
                Question_IsTrue_4.Visible = false;
                Question_IsTrue_5.Visible = false;

                // Bottom buttons
                Button_Check.Visible = false;

            } else {

                // Setting parameters
                // Drop  menu buttons
                Restart.Enabled = true;

                // Questions texts
                Question_Text_1.Visible = true;
                Question_Text_2.Visible = true;
                Question_Text_3.Visible = true;
                Question_Text_4.Visible = true;
                Question_Text_5.Visible = true;

                Question_Text_1.BackColor = Color.White;
                Question_Text_2.BackColor = Color.White;
                Question_Text_3.BackColor = Color.White;
                Question_Text_4.BackColor = Color.White;
                Question_Text_5.BackColor = Color.White;
                
                // Questions answers
                Question_IsTrue_1.Visible = true;
                Question_IsTrue_2.Visible = true;
                Question_IsTrue_3.Visible = true;
                Question_IsTrue_4.Visible = true;
                Question_IsTrue_5.Visible = true;

                // Bottom buttons
                Button_Check.Visible = true;

                // Restarting the game
                Game_Restart();

            };

        }

        private void Game_Restart() {

            Random Random_Generator = new Random();

            Question Question_Copy;

            Question_List = new List<Question>();

            for (int i = 1; i <=5; i++) {

                do {

                    Question_Copy = Questions_File_Current[Random_Generator.Next(0, Questions_File_Current.Count)];

                } while (Question_List.Contains(Question_Copy));

                Question_List.Add(Question_Copy);

            };

            // Setting questions texts
            Question_Text_1.Text = Question_List.ElementAt(0).Text;
            Question_Text_2.Text = Question_List.ElementAt(1).Text;
            Question_Text_3.Text = Question_List.ElementAt(2).Text;
            Question_Text_4.Text = Question_List.ElementAt(3).Text;
            Question_Text_5.Text = Question_List.ElementAt(4).Text;

            Question_IsTrue_1.Checked = false;
            Question_IsTrue_2.Checked = false;
            Question_IsTrue_3.Checked = false;
            Question_IsTrue_4.Checked = false;
            Question_IsTrue_5.Checked = false;
            
        }

        #endregion

    }

}
