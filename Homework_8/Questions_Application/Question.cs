using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions_Application {
 
    public class Question {

        #region Fields

        public string Text { get; set; }

        public bool IsTrue { get; set; }
        
        #endregion

        #region Constructors

        public Question() {

            // Default costructor
            this.Text   = "";
            this.IsTrue = false;

        }

        public Question(string text, bool isTrue) {

            this.Text    = text;
            this.IsTrue  = isTrue;

        }
        
        #endregion
        
    }

}
