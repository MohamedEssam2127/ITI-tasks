using LAB_7.Answers;
using System;
using System.Collections.Generic;

namespace LAB_7.Question
{
    internal class ChooseAllQuestion : Question
    {
        public ChooseAllQuestion(string body, int marks, AnswerList options, List<Answer> correctAnswer) :
       base("Choose all possible answers ", body, marks, options, correctAnswer)
        { }

        public override bool CheckAnswer(List<Answer> studentAnswers)
        {
            if (studentAnswers == null || studentAnswers.Count != CorrectAnswers.Count)
            {
                return false;
            }

            int matches = 0;
            foreach (var studentAns in studentAnswers)
            {
                foreach (var correctAns in CorrectAnswers)
                {
                    if (studentAns.Id == correctAns.Id)
                    {
                        matches++;
                        break;
                    }
                }
            }
            return matches == CorrectAnswers.Count;
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