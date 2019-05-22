using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApplication.Models
{
    public class BaseQuestion
    {
        public string Text { get; set; }
        public List<Answer> PossibleAnswers { get; set; }
        protected Response ExpectedResponse { get; set; }     

        public virtual bool GradeResponse(Response response)
        {
            return this.ExpectedResponse == response;
        }
    }
}
