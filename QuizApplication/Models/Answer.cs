using System;

namespace QuizApplication.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public override bool Equals(object obj)
        {
            var answer = obj as Answer;
            if (answer == null)
                return false;
            return answer.Id == this.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Text);
        }
    }
}