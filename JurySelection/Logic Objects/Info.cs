using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurySelection.Logic_Objects
{
    public class Info
    {
        private string theAnswer;
        public bool FilledIn { get; set; }
        public string Question { get; set; }
        public string Answer { get { return theAnswer; } }
        public theType Type { get; set; }
        public enum theType
        {
            aString,
            aBool,
            aInt
        };

        public Info(string question)
        {
            theAnswer = "";
            Question = question;
            FilledIn = false;

        }

        public Info(string question, theType t)
        {
            theAnswer = "";
            Question = question;
            FilledIn = false;
            Type = t;
        }

        

        public Info(string question, string answer)
        {
            Question = question;
            theAnswer = answer;

            FilledIn = true;
            if(answer == "")
            {
                FilledIn = false;
                return;
            }
            CheckType(answer);
        }

        private void CheckType(string t)
        {
            if (t == null)
                return;
            int x;
            if (Int32.TryParse(t, out x))
                Type = theType.aInt;
            
           // string s = new string(t.Where(c => !char.IsPunctuation(c)).ToArray());
           
            else if (t.ToLower() == "false" || t.ToLower() == "no" || t.ToLower() == "true" || t.ToLower() == "yes")
                Type = theType.aBool;

            else
                Type = theType.aString;

        }

        public void SetAnswer(string answer)
        {
            theAnswer = answer;
            if (answer != "")
                FilledIn = true;
            CheckType(answer);
        }

    }

}
