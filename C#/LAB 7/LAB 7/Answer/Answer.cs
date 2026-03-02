using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_7.Answers
{
    public class Answer : IComparable<Answer>
    {
        public int Id { get; }
        public string Text { get; }

        public Answer(int id, string text)
        {
            if (id <= 0) throw new ArgumentException("Id must be > 0");
            if (string.IsNullOrWhiteSpace(text)) throw new ArgumentException("Text cannot be empty");

            Id = id;
            Text = text;
        }

        public override string ToString() => $"  {Text}";

        public override bool Equals(object obj)
        {
            if( obj is Answer a && Id == a.Id )
                return true ;

            return false ;
        }

        public int CompareTo(Answer other)
        {
            if (other == null) return 1;
            return Id.CompareTo(other.Id);
        }
    }
}