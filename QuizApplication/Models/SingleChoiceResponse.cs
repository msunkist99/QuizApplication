using System;

namespace QuizApplication.Models
{
    public class SingleChoiceResponse : Response
    {
        public Answer SelectedAnswer { get; set; }

        public override bool Equals(object obj)
        {
            var response = obj as SingleChoiceResponse;
            if (response == null)
                return false;
            return response.SelectedAnswer == this.SelectedAnswer;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(SelectedAnswer);
        }
    }
}