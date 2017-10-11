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
    }

    
}
