using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApplication.Models
{
    public class MultipleSelectQuestion : BaseQuestion
    {
        public MultipleSelectQuestion(int expectedAnswerId, List<Answer> possibleAnswers)
        {
            this.PossibleAnswers = possibleAnswers;
            this.ExpectedResponse = new MultipleChoiceResponse
            {
                SelectedAnswers = this.PossibleAnswers.Where(x => x.Id == expectedAnswerId).ToList()
            };
        }

        public override bool GradeResponse(Response response)
        {
            return (MultipleChoiceResponse)response == (MultipleChoiceResponse)this.ExpectedResponse;
        }
    }
}
