using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Questions_Application
{
    public class Questions_File {

        #region Public fields

        public string Directory;

        public List<Question> list;

        #endregion

        #region Public properties

        public Question this[int index] {

            get {
                
                return this.list[index];
            
            }
        
            set {

                this.list[index] = value;

            }

        }

        public int Count {

            get {

                return this.list.Count;

            }
        
        }

        #endregion

        #region Constructors
        
        public Questions_File() {

            this.Directory = "";

            this.list = new List<Question>();

        }

        public Questions_File(string directory) {

            this.Directory = directory;
            this.list = new List<Question>();
            
            if (File.Exists(this.Directory)) {

                this.Load();

            };
            
        }

        #endregion

        #region Public Methods

        public Question Add() {

            Question Question_New = new Question();

            list.Add(Question_New);

            return Question_New;

        }

        public Question Add(string Question_Text, bool IsTrue) {

            Question Question_New = new Question(Question_Text, IsTrue);
            
            list.Add(Question_New);

            return Question_New;

        }

        public void Remove(int Index) {

            if (this.Count == 0) {

                throw new Exception("Список вопросов пуст.");

            } else if ((Index < 0) || (Index >= this.Count)) {

                throw new Exception("Индекс находится за пределами массива.");

            } else {

                DialogResult User_Question_Result = MessageBox.Show("Данные вопроса будут удалены. Продолжить?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (User_Question_Result == DialogResult.Yes) {

                    list.RemoveAt(Index);

                } else {

                    throw new Exception("Операция отменена.");

                };

            };      

        }

        public void Load() {

            XmlSerializer XML_Serializer = new XmlSerializer(typeof(List<Question>));
            
            using (var File_Stream = new FileStream(this.Directory, FileMode.Open, FileAccess.Read)) {

                this.list = (List<Question>)XML_Serializer.Deserialize(File_Stream);
            
            };

        }

        public void Save() {

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            
            using (var File_Stream = new FileStream(this.Directory, FileMode.Create, FileAccess.Write)) {

                xmlSerializer.Serialize(File_Stream, list);
            
            };

        }

        #endregion

    }
}
