using LAB_7.Answers;
using System;
using System.Collections.Generic;

namespace LAB_7.Question
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string body, int marks, Answer correctAnswer)
            : base("True/False Question", body, marks, new AnswerList(2), new List<Answer> { correctAnswer })
        {
            Answers.Add(new Answer(1, "True"));
            Answers.Add(new Answer(2, "False"));
        }

        public override bool CheckAnswer(List<Answer> studentAnswers)
        {
            if (studentAnswers == null || studentAnswers.Count != 1)
                return false;

            return studentAnswers[0].Id == CorrectAnswers[0].Id;
        }

        public override void Display()
        {
            Console.WriteLine(this.ToString());
            for (int i = 0; i < Answers.Count; i++)
            {
                Console.WriteLine($" {i + 1})" + Answers[i]);
            }
        }
    }
}