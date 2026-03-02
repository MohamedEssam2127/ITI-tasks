using System;
using System.Collections.Generic;
using System.IO;
using LAB_7.Question;

namespace LAB_7.Questions
{
    public class QuestionList : List<Question.Question>
    {
        private readonly string _filePath;

        public QuestionList(string filePath)
        {
            _filePath = filePath;
        }

        public new void Add(Question.Question question)
        {
            base.Add(question);
            LogToFile(question);
        }

        private void LogToFile(Question.Question question)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, true))
            {
                sw.WriteLine(question.ToString());
                sw.WriteLine("Answers:");
                for (int i = 0; i < question.Answers.Count; i++)
                {
                    sw.WriteLine(question.Answers[i].ToString());
                }
                sw.WriteLine("--------------------------");
            }
        }
    }
}