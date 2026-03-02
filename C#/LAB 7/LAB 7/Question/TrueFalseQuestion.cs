using LAB_7.Answers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_7.Question
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string body, int marks, Answer correctAnswer)
            : base("True/False Question", body, marks, new AnswerList(2), new Answer[] { correctAnswer })
        {
            Answers.Add(new Answer(1, "True"));
            Answers.Add(new Answer(2, "False"));
        }
        public override bool CheckAnswer(Answer[] studentAnswers)
        {
            if (studentAnswers == null || studentAnswers.Length != 1)
                return false;

            return studentAnswers[0].Id == CorrectAnswers[0].Id;
        }

        public override void Display()
        {
            Console.WriteLine(this.ToString());
            for (int i = 0; i < Answers.Count; i++)
            {
                Console.WriteLine($" {i+1})"+Answers[i]);
            }
        }
    }
}
