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
    public partial class Form_Starter : Form
    {
        public Form_Starter() {

            InitializeComponent();
        
        }

        private void Link_Task_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            Form_Task_1 Form_Task = new Form_Task_1();

            Form_Task.ShowDialog();

        }

        private void Link_Task_2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            Form_Task_2 Form_Task = new Form_Task_2();

            Form_Task.ShowDialog();

        }

    }

}
