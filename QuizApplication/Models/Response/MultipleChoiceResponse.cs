using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApplication.Models
{
    public class MultipleChoiceResponse : Response
    {
        public List<Answer> SelectedAnswers { get; set; }

        public override bool Equals(object obj)
        {
            var response = obj as MultipleChoiceResponse;
            if (response == null)
                return false;
            return this.SelectedAnswers.Count == response.SelectedAnswers.Count 
                && !this.SelectedAnswers.Except(response.SelectedAnswers).Any();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(SelectedAnswers);
        }
    }
}
