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

        // A protected member is accessible within its class and by derived class instances.
        protected Response ExpectedResponse { get; set; }

        // virtual keyword is used to override a base class members such as properties, methods, etc. in derived class to modify it based on our requirements.
        public virtual bool GradeResponse(Response response)
        {
            return this.ExpectedResponse == response;
        }
    }
}
