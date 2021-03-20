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
    public partial class Form_Starter : Form
    {
        public Form_Starter() {

            InitializeComponent();
        
        }

        private void Link_Task_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            Form_Questions_Edit form = new Form_Questions_Edit();

            form.ShowDialog();

        }

        private void Link_Task_2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            Form_Task_2 form = new Form_Task_2();

            form.ShowDialog();

        }

        private void Link_Task_3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            Form_Task_3 form = new Form_Task_3();

            form.ShowDialog();

        }

        private void Info_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            StringBuilder String_Info = new StringBuilder();

            String_Info.AppendLine("Автор: Бережной Евгений");
            String_Info.AppendLine("Куратор: Станислав Байраковский");
            String_Info.AppendLine("Версия: 1.0");
            String_Info.AppendLine("Авторские права: Не заявлены.");

            MessageBox.Show(String_Info.ToString(), "Информация о программе", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }

}
