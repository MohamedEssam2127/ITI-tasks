using LAB_7.Answers;
using System;
using System.Collections.Generic;

namespace LAB_7.Question
{
    internal class ChooseOneQuestion : Question
    {
        public ChooseOneQuestion(string body, int marks, AnswerList options, Answer correctAnswer) :
            base("Choose One", body, marks, options, new List<Answer> { correctAnswer })
        {
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
                Console.WriteLine($"  {i + 1}) {Answers[i]}");
            }
        }
    }
}