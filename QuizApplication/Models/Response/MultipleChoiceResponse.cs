using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApplication.Models
{
    public class MultipleChoiceResponse : Response
    {
        public List<Answer> SelectedAnswers { get; set; }

        // The override modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.
        // not sure why override is used here because the Equals method is not inherited 
        // maybe something will yet be added to the Response base class
        public override bool Equals(object obj)
        {
            var response = obj as MultipleChoiceResponse;
            if (response == null)
                return false;
            return this.SelectedAnswers.Count == response.SelectedAnswers.Count 
                && !this.SelectedAnswers.Except(response.SelectedAnswers).Any();
        }

        // The override modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.
        // not sure why override is used here because the GetHasCode method is not inherited 
        // maybe something will yet be added to the Response base class
        public override int GetHashCode()
        {
            return HashCode.Combine(SelectedAnswers);
        }
    }
}
