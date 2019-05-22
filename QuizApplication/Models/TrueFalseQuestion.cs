using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApplication.Models
{
    public class TrueFalseQuestion : BaseQuestion
    {
        public TrueFalseQuestion()
        {
            this.PossibleAnswers = new List<Answer>();
            this.PossibleAnswers.Add(new Answer { Id = 1, Text = "True" });
            this.PossibleAnswers.Add(new Answer { Id = 2, Text = "False" });
        }

        public TrueFalseQuestion(bool expectedResponse)
        {
            this.PossibleAnswers = new List<Answer>();
            this.PossibleAnswers.Add(new Answer { Id = 1, Text = "True" });
            this.PossibleAnswers.Add(new Answer { Id = 2, Text = "False" });
            this.ExpectedResponse = new SingleChoiceResponse {
                SelectedAnswer = this.PossibleAnswers.Single(x => bool.Parse(x.Text) == expectedResponse)  
            };
        }

        public override bool GradeResponse(Response response)
        {
            return (SingleChoiceResponse)response == (SingleChoiceResponse)this.ExpectedResponse;
        }
    }
}
