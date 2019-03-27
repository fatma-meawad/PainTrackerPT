using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public interface IFollowUpState
    {
        void AskQuestions();
        void AnswerQuestions();
        void GenerateAdvice();
        void CompleteFollowUp();
    }
}
