using LAB_7.Answers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_7.Question
{
    public abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }
        public AnswerList Answers { get; set; }
        public Answer[] CorrectAnswers { get; set; }

        protected Question(string header, string body, int marks, AnswerList answers, Answer[] correctAnswers)
        {
            if (marks <= 0) throw new ArgumentException("Marks must be > 0");
            Header = header ?? throw new ArgumentNullException(nameof(header));
            Body = body ?? throw new ArgumentNullException(nameof(body));

            Marks = marks;
            Answers = answers;
            CorrectAnswers = correctAnswers;
        }

        public abstract void Display();
        public abstract bool CheckAnswer(Answer[] studentAnswers);

        public override string ToString() => $"{Header}\tMarks: {Marks}\n{Body}";

        public override bool Equals(object obj)
        {
            if (obj is Question q)
                return Body == q.Body && Header == q.Header;
            return false;
        }
    }

}