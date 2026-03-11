using LAB_7.Answers;
using LAB_7.Core;
using LAB_7.Exam;
using LAB_7.Question;
using LAB_7.Questions;
using System;
using System.Collections.Generic;

namespace LAB_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Subject Setup
            Subject subject = new Subject("Advanced Programming", 5);
            Student student1 = new Student(1, "Ahmed");
            Student student2 = new Student(2, "Mo");
            subject.Enroll(student1);
            subject.Enroll(student2);
            #endregion

            #region exams setup
            PracticeExam practiceExam = new PracticeExam(30, 3, subject);
            FinalExam finalExam = new FinalExam(60, 3, subject);

            #region Questions Setup
            Answer tfCorrect = new Answer(1, "True");
            TrueFalseQuestion q1 = new TrueFalseQuestion("Is C# strongly typed?", 10, tfCorrect);
            practiceExam.Questions.Add(q1);

            AnswerList mcOptions = new AnswerList(3);
            Answer mcCorrect = new Answer(2, "Object");
            mcOptions.Add(new Answer(1, "String"));
            mcOptions.Add(mcCorrect);
            mcOptions.Add(new Answer(3, "Int"));
            ChooseOneQuestion q2 = new ChooseOneQuestion("What is the base class for all types?", 10, mcOptions, mcCorrect);
            practiceExam.Questions.Add(q2);

            AnswerList allOptions = new AnswerList(5);
            allOptions.Add(new Answer(1, "Interface"));
            allOptions.Add(new Answer(2, "Sealed Class"));
            allOptions.Add(new Answer(3, "Abstract Class"));
            allOptions.Add(new Answer(4, "Static Class"));
            allOptions.Add(new Answer(5, "Private Class"));
            List<Answer> allCorrectAnswers = new List<Answer> { allOptions[0], allOptions[2] };
            ChooseAllQuestion q3 = new ChooseAllQuestion("Which of these can be used for abstraction?", 20, allOptions, allCorrectAnswers);
            practiceExam.Questions.Add(q3);

            QuestionList myList = new QuestionList("Questions.txt");
            myList.Add(q1);
            myList.Add(q2);
            myList.Add(q3);
            // ============= Here =============
            foreach (var student in subject.EnrolledStudents)
            {
                practiceExam.ExamStarted += student.OnExamStarted;
                finalExam.ExamStarted += student.OnExamStarted;
            }
            #endregion

            finalExam.Questions.AddRange(practiceExam.Questions);
            #endregion

            Console.WriteLine("Select Exam Type (1 - Practice, 2 - Final):");
            Exam.Exam selectedExam;
            while (true)
            {
                string choice = Console.ReadLine();
                if (choice == "1") { selectedExam = practiceExam; break; }
                if (choice == "2") { selectedExam = finalExam; break; }
                Console.WriteLine("Invalid input. Enter 1 or 2 only:");
            }

            selectedExam.Start();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Exam Status: " + selectedExam.Mode + "\n----------------------------------");

            foreach (var q in selectedExam.Questions)
            {
                if (q == null) continue;
                q.Display();

                List<Answer> studentSelected = new List<Answer>();

                if (q is ChooseAllQuestion)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter IDs separated by comma (e.g., 1,3):");
                        string input = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(input)) continue;

                        string[] parts = input.Split(',');
                        bool hasError = false;
                        studentSelected.Clear();

                        foreach (var part in parts)
                        {
                            if (int.TryParse(part.Trim(), out int id))
                            {
                                try
                                {
                                    Answer found = q.Answers.GetById(id);
                                    if (!studentSelected.Contains(found))
                                    {
                                        studentSelected.Add(found);
                                    }
                                }
                                catch { hasError = true; break; }
                            }
                            else { hasError = true; break; }
                        }

                        if (!hasError && studentSelected.Count > 0) break;
                        Console.WriteLine("Invalid IDs or format. Try again.");
                    }
                }
                else
                {
                    while (true)
                    {
                        Console.Write("Enter Answer ID: ");
                        if (int.TryParse(Console.ReadLine(), out int id))
                        {
                            try
                            {
                                studentSelected.Add(q.Answers.GetById(id));
                                break;
                            }
                            catch (Exception ex) { Console.WriteLine(ex.Message); }
                        }
                        else { Console.WriteLine("Please enter a valid number."); }
                    }
                }

                selectedExam.QuestionAnswerDictionary.Add(q, studentSelected);
                Console.WriteLine();
            }

            selectedExam.Finish();
            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
        }
    }
}