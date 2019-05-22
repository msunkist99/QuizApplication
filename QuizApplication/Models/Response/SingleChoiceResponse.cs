using System;

namespace QuizApplication.Models
{
    public class SingleChoiceResponse : Response
    {
        public Answer SelectedAnswer { get; set; }

        // The override modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.
        // not sure why override is used here because the Equals method is not inherited 
        // maybe something will yet be added to the Response base class
        public override bool Equals(object obj)
        {
            var response = obj as SingleChoiceResponse;
            if (response == null)
                return false;
            return response.SelectedAnswer == this.SelectedAnswer;
        }

        // The override modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.
        // not sure why override is used here because the GetHashCode method is not inherited 
        // maybe something will yet be added to the Response base class
        public override int GetHashCode()
        {
            return HashCode.Combine(SelectedAnswer);
        }
    }
}