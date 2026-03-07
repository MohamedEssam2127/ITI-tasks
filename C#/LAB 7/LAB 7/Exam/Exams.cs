using LAB_7.Answers;
using LAB_7.Core;
using LAB_7.Event_Infrastructure;
using LAB_7.Question;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_7.Exam
{
    public enum ExamMode { Starting, Queued, Finished }

    public delegate void ExamStartedHandler(object sender, ExamEventArgs e);

    public class ExamEventArgs : EventArgs
    {
        public Subject Subject { get; }
        public Exam Exam { get; }
        public ExamEventArgs(Subject subject, Exam exam)
        {
            Subject = subject;
            Exam = exam;
        }
    }

    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Question.Question> Questions { get; set; }
        public Dictionary<Question.Question, List<Answer>> QuestionAnswerDictionary { get; set; }
        public Subject Subject { get; set; }
        public ExamMode Mode { get; set; }
        protected int totalGrade = 0;


        //EVENT 
        public event ExamStartedHandler ExamStarted; 

        protected Exam(int time, int numQuestions, Subject subject)
        {
            Time = time;
            NumberOfQuestions = numQuestions;
            Subject = subject;
            Questions = new List<Question.Question>();
            QuestionAnswerDictionary = new Dictionary<Question.Question, List<Answer>>();
            Mode = ExamMode.Queued;
        }

        public abstract void ShowExam();
        protected virtual void OnExamStarted(ExamEventArgs e)
        {
            ExamStarted?.Invoke(this, e);
        }

        public virtual void Start()
        {
            Mode = ExamMode.Starting;
            OnExamStarted(new ExamEventArgs(Subject, this));
        }

        public virtual void Finish()
        {
            Mode = ExamMode.Finished;
        }

        public int CorrectExam()
        {
            int studentGrade = 0;
            int calculatedTotal = 0;
            foreach (var q in Questions)
            {
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

        public override int GetHashCode()
        {
            return HashCode.Combine(Time, NumberOfQuestions, Subject?.Name);
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
            foreach (var q in Questions)
            {
                q?.Display();
            }
        }

        public override void Finish()
        {
            base.Finish();
            int score = CorrectExam();
            Console.WriteLine("\n--- Practice Results ---");
            foreach (var q in Questions)
            {
                if (q == null) continue;
                Console.WriteLine("Q: " + q.Body);
                if (QuestionAnswerDictionary.ContainsKey(q))
                {
                    Console.Write("Your Answer(s): ");
                    List<Answer> ans = QuestionAnswerDictionary[q];
                    for (int j = 0; j < ans.Count; j++)
                        Console.Write(ans[j].Text + (j < ans.Count - 1 ? ", " : ""));
                    Console.WriteLine();
                }
                Console.Write("Correct Answer(s): ");
                for (int j = 0; j < q.CorrectAnswers.Count; j++)
                    Console.Write(q.CorrectAnswers[j].Text + (j < q.CorrectAnswers.Count - 1 ? ", " : ""));
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
            foreach (var q in Questions)
            {
                q?.Display();
            }
        }

        public override void Finish()
        {
            base.Finish();
            int score = CorrectExam();
            Console.WriteLine("\n--- Final Results ---");
            foreach (var q in Questions)
            {
                if (q == null) continue;
                Console.WriteLine("Q: " + q.Body);
                if (QuestionAnswerDictionary.ContainsKey(q))
                {
                    Console.Write("Your Answer(s): ");
                    List<Answer> ans = QuestionAnswerDictionary[q];
                    for (int j = 0; j < ans.Count; j++)
                        Console.Write(ans[j].Text + (j < ans.Count - 1 ? ", " : ""));
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Exam Completed. Your Score: " + score + " / " + totalGrade);
        }
    }
}