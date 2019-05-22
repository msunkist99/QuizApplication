using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApplication.Models
{
    public class MultipleChoiceQuestion : BaseQuestion
    {
        public MultipleChoiceQuestion(int expectedAnswerId, List<Answer> possibleAnswers)
        {
            this.PossibleAnswers = possibleAnswers;
            this.ExpectedResponse = new SingleChoiceResponse
            {
                SelectedAnswer = this.PossibleAnswers.Single(x => x.Id == expectedAnswerId)
            };
        }

    }
}
