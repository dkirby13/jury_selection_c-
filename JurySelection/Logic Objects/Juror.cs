using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurySelection.Logic_Objects
{
    public class Juror
    {
        public bool Deleted { get; set; }
        public enum LikeState
        {
            Neutral,
            Like,
            Dislike
        };
        public LikeState TheLikeState { get;
            set; }
        public int Number { get; set; }
        public List<Info> TheInfo { get; set; }
        public Juror(int number)
        {
            Deleted = false;
            TheLikeState = LikeState.Neutral;
            Number = number;
            TheInfo = new List<Info>();
        }

        public bool MeetsSearchCriteria(string question, string answer, Info.theType type)
        {
            if (Deleted)
                return false;
            if (answer == "Not filled in yet")
                return MeetsSearchCriteria(question);
            foreach (Info info in TheInfo)
                if (info.Question.ToLower() == question.ToLower() && info.Type == type)
                {
                    if (type == Info.theType.aBool)
                    {
                        if (answer.ToLower() == "false")
                            return info.Answer.ToLower() == "false" || info.Answer.ToLower() == "no";
                        else
                            return info.Answer.ToLower() == "true" || info.Answer.ToLower() == "yes";

                    }
                    else if(type == Info.theType.aInt)
                    {
                        if(answer.Contains('='))
                        {
                            return Convert.ToInt32(answer.Split(' ')[0]) == Convert.ToInt32(question);
                        }

                        else if(answer.Contains('>'))
                        {
                            return Convert.ToInt32(answer.Split(' ')[0]) > Convert.ToInt32(question);
                        }

                        else
                        {
                            return Convert.ToInt32(answer.Split(' ')[0]) < Convert.ToInt32(question);
                        }
                    }
                    else
                        return info.Answer.ToLower() == answer;
                }
            return false;
        }

        public bool MeetsSearchCriteria(string question)
        {
            
            foreach (Info info in TheInfo)
                if (info.Question.ToLower() == question.ToLower() && !info.FilledIn)
                    return true;
            return false;
        }

        public string Save()
        {
            string line = Convert.ToString(Number) + "~";
            if (TheLikeState == LikeState.Dislike)
                line = line + "Dislike~";
            else if (TheLikeState == LikeState.Like)
                line = line + "Like~";
            else
                line = line + "Nuetral~";
            foreach(Info i in TheInfo)
            {
                line = line + "(" + i.Type + "@" + i.Question + "@" + i.Answer;
            }
            return line;
        }

        public Juror(string line)
        {
            TheInfo = new List<Info>();
            List<string> j = line.Split('~').ToList();
            Number = Convert.ToInt32(j[0]);
            if (j[1] == "Like")
                TheLikeState = LikeState.Like;
            else if (j[1] == "Dislike")
                TheLikeState = LikeState.Dislike;
            else
                TheLikeState = LikeState.Neutral;

            j.RemoveAt(0);
            j.RemoveAt(0);
            j = String.Join("", j.ToArray()).Split('(').ToList();
            j.RemoveAt(0);
            foreach(string info in j)
            {
                string[] i = info.Split('@');
                TheInfo.Add(new Info(i[1], i[2]));
            }
        }
    }

    
}
