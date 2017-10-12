using System;
using System.Collections.Generic;
using System.IO;
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

        public void Save()
        {
            string fileLocation = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\JurySelectionHelper\\" + Name + ".txt";
            string[] lines = new string[NumberOfJurors + 3];
            lines[0] = Name;
            lines[1] = Convert.ToString(NumberOfJurors);
            int i = 2;
            foreach(Juror j in TheJurors)
            {
                if (!j.Deleted)
                {
                    lines[i] = j.Save();
                    i++;
                }
            }
            System.IO.File.WriteAllLines(fileLocation, lines);
        }

        public Case(string filelocation)
        {
            //FileStream file = File.OpenRe(filelocation);
            List<String> lines = File.ReadLines(filelocation).ToList();
            Name = lines[0];
            NumberOfJurors = Convert.ToInt32(lines[1]);
            TheJurors = new List<Juror>();
            for (int i = 2; i < NumberOfJurors + 2; i++)
            {
                TheJurors.Add(new Juror(lines[i]));
            }
        }

    }
}
