using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Questions_Application
{
    public partial class Form_Task_3 : Form {

        #region Constructors

        public Form_Task_3() {

            InitializeComponent();
        
        }

        #endregion

        #region Common methods
        
        public void Button_Convert_Click(object sender, EventArgs e) {

            // 0. Variables
            List<Person> Persons_List;

            XmlSerializer XML_Serializer = new XmlSerializer(typeof(List<Person>));

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "XML files (*.xml)|*.xml";

            String Directory;

            StringBuilder String_Constructor = new StringBuilder();

            // 1. Actions
            if (openFileDialog.ShowDialog() != DialogResult.OK) {

                return;

            };

            using (var File_Stream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read)) {

                Persons_List = (List<Person>)XML_Serializer.Deserialize(File_Stream);

            };

            Directory = openFileDialog.FileName.Replace(".xml", ".csv");

            using(FileStream CSV_Stream = new FileStream(Directory, FileMode.Create)) {

                StreamWriter CSV_Recorder = new StreamWriter(CSV_Stream, Encoding.UTF8);

                foreach (Person Person_Example in Persons_List) {

                    CSV_Recorder.WriteLine(Person_Example.ToString());

                };

                CSV_Recorder.Close();

            };

            Process CSV_Launcher = Process.Start(Directory);
            
        }

        #endregion

    }

}
