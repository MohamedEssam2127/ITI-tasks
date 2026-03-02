using System;
using System.Collections.Generic;
using System.Text;
using LAB_7.Answers;
using LAB_7.Question;
using LAB_7.Core;

namespace LAB_7.Exam
{
    public enum ExamMode { Starting, Queued, Finished }

    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question.Question[] Questions { get; set; }
        public Dictionary<Question.Question, Answer[]> QuestionAnswerDictionary { get; set; }
        public Subject Subject { get; set; }
        public ExamMode Mode { get; set; }
        protected int totalGrade = 0;

        protected Exam(int time, int numQuestions, Subject subject)
        {
            Time = time;
            NumberOfQuestions = numQuestions;
            Subject = subject;
            Questions = new Question.Question[numQuestions];
            QuestionAnswerDictionary = new Dictionary<Question.Question, Answer[]>();
            Mode = ExamMode.Queued;
        }

        public abstract void ShowExam();

        public virtual void Start()
        {
            Mode = ExamMode.Starting;
        }

        public virtual void Finish()
        {
            Mode = ExamMode.Finished;
        }

        public int CorrectExam()
        {
            int studentGrade = 0;
            int calculatedTotal = 0;
            for (int i = 0; i < Questions.Length; i++)
            {
                Question.Question q = Questions[i];
                if (q != null)
                {
                    calculatedTotal += q.Marks;
                    if (QuestionAnswerDictionary.ContainsKey(q))
                    {
                        if (q.CheckAnswer(QuestionAnswerDictionary[q]))
                        {
                            studentGrade += q.Marks;
                        }
                    }
                }
            }
            this.totalGrade = calculatedTotal;
            return studentGrade;
        }

        public override string ToString()
        {
            return "Exam: " + Subject.Name + ", Time: " + Time + " min";
        }

        public override bool Equals(object obj)
        {
            if (obj is Exam other)
            {
                return this.Time == other.Time && this.NumberOfQuestions == other.NumberOfQuestions;
            }
            return false;
        }

        public int CompareTo(Exam other)
        {
            if (other == null) return 1;
            if (this.Time != other.Time) return this.Time.CompareTo(other.Time);
            return this.NumberOfQuestions.CompareTo(other.NumberOfQuestions);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class PracticeExam : Exam
    {
        public PracticeExam(int time, int numQuestions, Subject subject) : base(time, numQuestions, subject) { }

        public override void ShowExam()
        {
            Console.WriteLine("--- Practice Exam ---");
            for (int i = 0; i < Questions.Length; i++)
            {
                if (Questions[i] != null) Questions[i].Display();
            }
        }

        public override void Finish()
        {
            base.Finish();
            int score = CorrectExam();
            Console.WriteLine("\n--- Practice Results ---");
            for (int i = 0; i < Questions.Length; i++)
            {
                Question.Question q = Questions[i];
                if (q == null) continue;
                Console.WriteLine("Q: " + q.Body);
                if (QuestionAnswerDictionary.ContainsKey(q))
                {
                    Console.Write("Your Answer(s): ");
                    Answer[] ans = QuestionAnswerDictionary[q];
                    for (int j = 0; j < ans.Length; j++) Console.Write(ans[j].Text + (j < ans.Length - 1 ? ", " : ""));
                    Console.WriteLine();
                }
                Console.Write("Correct Answer(s): ");
                for (int j = 0; j < q.CorrectAnswers.Length; j++) Console.Write(q.CorrectAnswers[j].Text + (j < q.CorrectAnswers.Length - 1 ? ", " : ""));
                Console.WriteLine("\n-------------------------");
            }
            Console.WriteLine("Final Grade: " + score + " / " + totalGrade);
        }
    }

    public class FinalExam : Exam
    {
        public FinalExam(int time, int numQuestions, Subject subject) : base(time, numQuestions, subject) { }

        public override void ShowExam()
        {
            Console.WriteLine("--- Final Exam ---");
            for (int i = 0; i < Questions.Length; i++)
            {
                if (Questions[i] != null) Questions[i].Display();
            }
        }

        public override void Finish()
        {
            base.Finish();
            int score = CorrectExam();
            Console.WriteLine("\n--- Final Results ---");
            for (int i = 0; i < Questions.Length; i++)
            {
                Question.Question q = Questions[i];
                if (q == null) continue;
                Console.WriteLine("Q: " + q.Body);
                if (QuestionAnswerDictionary.ContainsKey(q))
                {
                    Console.Write("Your Answer(s): ");
                    Answer[] ans = QuestionAnswerDictionary[q];
                    for (int j = 0; j < ans.Length; j++) Console.Write(ans[j].Text + (j < ans.Length - 1 ? ", " : ""));
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Exam Completed. Your Score: " + score + " / " + totalGrade);
        }
    }
}