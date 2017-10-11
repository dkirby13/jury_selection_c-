using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurySelection.Logic_Objects
{
    public class Case
    {
        
        
        public List<Juror> TheJurors { get; set; }
        public String Name { get; set; }
        public int NumberOfJurors { get; }
        public Case(String name, int numberOfJuror)
        {
            
            Name = name;
            NumberOfJurors = numberOfJuror;
            TheJurors = new List<Juror>();
        }

        public List<string> GetQuestionsByType(Info.theType type)
        {
            List<string> i = new List<string>();
            foreach(Juror j in TheJurors)
            {
                if(!j.Deleted)
                {
                    foreach(Info info in j.TheInfo)
                    {
                        if (info.Type == type && !i.Contains(info.Question.ToLower()))
                            i.Add(info.Question.ToLower());
                    }
                }
            }
            return i;
        }

        public List<string> GetAnswersByType(Info.theType type)
        {
            List<string> i = new List<string>();
            foreach (Juror j in TheJurors)
            {
                if (!j.Deleted)
                {
                    foreach (Info info in j.TheInfo)
                    {
                        if (info.Type == type && !i.Contains(info.Answer.ToLower()))
                            i.Add(info.Answer.ToLower());
                    }
                }
            }
            return i;
        }

        public List<string> GetAnswersByQuestion(string question, Info.theType type)
        {
            List<string> i = new List<string>();
            foreach (Juror j in TheJurors)
            {
                if (!j.Deleted)
                {
                    foreach (Info info in j.TheInfo)
                    {
                        if (info.Type == type && info.Question.ToLower() == question && !i.Contains(info.Answer.ToLower()))
                            i.Add(info.Answer.ToLower());
                    }
                }
            }
            return i;
        }

        public Dictionary<string, List<string>> GetQADictionaryByType(Info.theType type)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            foreach(string question in GetQuestionsByType(type))
            {
                if (!dictionary.ContainsKey(question))
                    dictionary.Add(question, GetAnswersByQuestion(question, type));
            }
            return dictionary;
        }

    }
}
