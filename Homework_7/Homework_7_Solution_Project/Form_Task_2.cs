using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_7_Solution_Project
{
    public partial class Form_Task_2 : Form {

        #region Variables

        private int number_Demanded;
        private int number_User;

        private int number_Attempts;

        #endregion

        #region Constructors

        public Form_Task_2() {

            InitializeComponent();

            // 1. Set game parameters
            Set_Game_Parameters();

        }

        #endregion

        #region Comamnd listeners

        private void TextBox_Number_User_KeyUp(object sender, KeyEventArgs e) {

            // 0. Prepaprations
            // 0.1. Variables
            string[] RichTextBox_Parameters_Text = new string[1];
            
            // 1. All actions are executed only when user pressed Enter inside this box
            if (!(e.KeyCode == Keys.Enter)) {

                return;

            }

            // 2. Attempt to parse number in the textbox
            if (!(Int32.TryParse(TextBox_Number_User.Text, out number_User))) {

                MessageBox.Show("Введено значение, не являющееся числом.", "Системная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            };

            // 3. Look if user guessed the number
            if (number_User == number_Demanded) {

                RichTextBox_Parameters.ForeColor = Color.Green;

                Set_Parameters_Text($"Число угадано!");

                TextBox_Number_User.Enabled = false;

            } else if ((number_User < number_Demanded)
                        && (number_Attempts > 1)) {

                number_Attempts--;

                Set_Parameters_Text($"Введенное число меньше загаданного. Осталось попыток: {number_Attempts}");

            } else if ((number_User > number_Demanded)
                        && (number_Attempts > 1)) {

                number_Attempts--;

                Set_Parameters_Text($"Введенное число больше загаданного. Осталось попыток: {number_Attempts}");

            } else {

                RichTextBox_Parameters.ForeColor = Color.Red;

                Set_Parameters_Text($"Игра окончена. Число не угадано. Правильный ответ {number_Demanded}");

                TextBox_Number_User.Enabled = false;
                
            };
            
        }

        private void Button_Restart_Click(object sender, EventArgs e) {

            // 1. Set game parameters
            Set_Game_Parameters();

        }

        #endregion

        #region Another methods

        private void Set_Parameters_Text(string Text) {

            // 1. Set text of the box
            string[] RichTextBox_Parameters_Text = new string[1];

            RichTextBox_Parameters_Text[0] = Text;
            
            // 2. Set compliant property of the box
            RichTextBox_Parameters.Lines = RichTextBox_Parameters_Text;

        }

        private void Set_Game_Parameters() {

            // 1. Initialize number, which we should get
            Random Random_Generator = new Random();

            number_Demanded = Random_Generator.Next(1, 101);
            number_User     = 0;

            // 2. Restore attempts
            number_Attempts = 10;
            
            // 3. Setting labels inscriptions
            Set_Parameters_Text($"Осталось попыток: {number_Attempts}");

            // 4. Setting properties of form objects
            RichTextBox_Parameters.ForeColor = Color.Black;

            TextBox_Number_User.Enabled = true;

            TextBox_Number_User.Text = "";

        }

        #endregion

    }
}
