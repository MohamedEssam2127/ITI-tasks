using LAB_7.Answers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_7.Question
{
    internal class ChooseAllQuestion : Question

    {
        public ChooseAllQuestion(string body, int marks, AnswerList options, Answer[] correctAnswer) :
       base("Choose all possible answers ", body, marks, options,  correctAnswer )
        { }

        public override bool CheckAnswer(Answer[] studentAnswers)
        {
            if (studentAnswers == null || studentAnswers.Length != CorrectAnswers.Length) { 
              return false;
            }

            int matches = 0;
            for (int i = 0; i < studentAnswers.Length; i++)
            {
                for (int j = 0; j < CorrectAnswers.Length; j++)
                {
                    if (studentAnswers[i].Id == CorrectAnswers[j].Id)
                    {
                        matches++;
                        break;
                    }
                }
            }
            return matches == CorrectAnswers.Length;

        }

        public override void Display()
        {
            Console.WriteLine(this.ToString());
            for (int i = 0; i < Answers.Count; i++) {
                Console.WriteLine($"  {i + 1}) {Answers[i]}");
            } 
        }
    }
    }

