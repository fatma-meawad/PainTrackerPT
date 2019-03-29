using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public interface IFollowUpState
    {
        void askQuestions();
        void answerQuestion();
        void generateAdvice();
        void completeFollowUp();
    }
}
