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
    public partial class Form_Task_1 : Form {

        #region Variables

        private int number_Demanded;
        private int number_User;
        
        private int number_Steps_Demanded   = 0;
        private int number_Steps_User       = 0;

        List<int> number_Succession = new List<int>();

        #endregion

        #region Constructors

        public Form_Task_1() {

            InitializeComponent();

            // 1. Set game parameters
            Set_Game_Parameters();

        }

        #endregion

        #region Commands listeners

        private void Button_Number_User_Plus_Click(object sender, EventArgs e) {

            number_User++;

            Do_Another_Step();

        }

        private void Button_Number_User_Double_Click(object sender, EventArgs e) {

            number_User = number_User * 2;

            Do_Another_Step();
            
        }

        private void Button_Number_User_Revert_Click(object sender, EventArgs e) {

            // 0. 1 is unrevertable
            if (number_User == 0) {

                return;

            };

            // 1. Delete number from the user step succession
            number_Succession.Remove(number_User);

            // 2. Set previous number
            if (number_Succession.Count == 0) {

                number_User = 0;

            } else {

                number_User = number_Succession[number_Succession.Count - 1];

            };

            // 3. Count steps
            number_Steps_User--;

            // 4. Set properties of elements
            Set_Parameters_Text();
            
        }

        private void Button_Restart_Click(object sender, EventArgs e) {

            // 1. Set game parameters
            Set_Game_Parameters();

        }

        #endregion

        #region Another methods

        private void Do_Another_Step() {

            // 1. Add number to the user step succession
            number_Succession.Add(number_User);

            // 2. Count steps
            number_Steps_User++;

            // 3. Check if user has achieved optimal way of gaining reedled number. If he has - block all the fields
            if (number_Demanded == number_User
                    && number_Steps_Demanded == number_Steps_User) {

                RichTextBox_Parameters.ForeColor = Color.Green;

                TextBox_Number_User.Enabled         = false;
                Button_Number_User_Plus.Enabled     = false;
                Button_Number_User_Double.Enabled   = false;
                Button_Number_User_Revert.Enabled   = false;
                
            };

            // 4. Set properties of elements
            Set_Parameters_Text();

        }

        private void Set_Parameters_Text() {

            // 1. Set text of the box
            string[] RichTextBox_Parameters_Text = new string[3];

            RichTextBox_Parameters_Text[0] = $"Требуется получить число: {number_Demanded}";
            RichTextBox_Parameters_Text[1] = $"За число шагов: {number_Steps_Demanded}";
            RichTextBox_Parameters_Text[2] = $"Текущее число шагов: {number_Steps_User}";

            // 2. Set compliant property of the box
            RichTextBox_Parameters.Lines = RichTextBox_Parameters_Text;

            // 3. Set current number in the TextBox
            TextBox_Number_User.Text = number_User.ToString();

        }

        private void Set_Game_Parameters() {

            // 0. Dumping steps
            number_Steps_Demanded = 0;
            number_Steps_User = 0;

            // 1. Initialize number, which we should get
            Random Random_Generator = new Random();

            number_Demanded = Random_Generator.Next(1, 101);
            number_User     = number_Demanded;

            // 2. Determine, how many steps we need for gaining this number
            while (number_User > 1) {

                if (number_User % 2 > 0)
                {

                    number_User--;

                    number_Steps_Demanded++;

                };

                number_User = number_User / 2;

                number_Steps_Demanded++;

            };
            
            number_User--; // to 1

            number_Steps_Demanded++;

            // 3. Setting labels inscriptions
            Set_Parameters_Text();
            
            // 4. Setting properties of form objects
            RichTextBox_Parameters.ForeColor = Color.Red;

            TextBox_Number_User.Enabled         = true;
            Button_Number_User_Plus.Enabled     = true;
            Button_Number_User_Double.Enabled   = true;
            Button_Number_User_Revert.Enabled   = true;

        }

        #endregion

    }

}
