using System;
using LAB_7.Answers;
using LAB_7.Core;
using LAB_7.Exam;
using LAB_7.Question;

namespace LAB_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Subject Setup
            Subject subject = new Subject("Advanced Programming", 5);
            Student student1 = new Student(1, "Ahmed");
            Student student2 = new Student(2,"Mo");
            subject.Enroll(student1);
            subject.Enroll(student2);
            #endregion

            #region exams setup
            PracticeExam practiceExam = new PracticeExam(30, 3, subject);
            FinalExam finalExam = new FinalExam(60, 3, subject);

            #region Questions Setup
            Answer tfCorrect = new Answer(1, "True");
            practiceExam.Questions[0] = new TrueFalseQuestion("Is C# strongly typed?", 10, tfCorrect);

            AnswerList mcOptions = new AnswerList(3);
            Answer mcCorrect = new Answer(2, "Object");
            mcOptions.Add(new Answer(1, "String"));
            mcOptions.Add(mcCorrect);
            mcOptions.Add(new Answer(3, "Int"));
            practiceExam.Questions[1] = new ChooseOneQuestion("What is the base class for all types?", 10, mcOptions, mcCorrect);

            AnswerList allOptions = new AnswerList(5);
            allOptions.Add(new Answer(1, "Interface"));
            allOptions.Add(new Answer(2, "Sealed Class"));
            allOptions.Add(new Answer(3, "Abstract Class"));
            allOptions.Add(new Answer(4, "Static Class"));
            allOptions.Add(new Answer(5, "Private Class"));
            Answer[] allCorrectAnswers = { allOptions[0], allOptions[2] };
            practiceExam.Questions[2] = new ChooseAllQuestion("Which of these can be used for abstraction?", 20, allOptions, allCorrectAnswers);

            #endregion

           
            for (int i = 0; i < 3; i++) finalExam.Questions[i] = practiceExam.Questions[i];
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
            Console.Clear();
            Console.WriteLine("Exam Status: " + selectedExam.Mode + "\n----------------------------------");

            for (int i = 0; i < selectedExam.Questions.Length; i++)
            {
                Question.Question q = selectedExam.Questions[i];
                if (q == null) continue;
                q.Display();

                if (q is ChooseAllQuestion)
                {
                    Answer[] studentSelected = null;
                    while (true)
                    {
                        Console.WriteLine("Enter IDs separated by comma (e.g., 1,3):");
                        string input = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(input)) continue;

                        string[] parts = input.Split(',');
                        Answer[] temp = new Answer[parts.Length];
                        int count = 0; bool hasError = false;

                        for (int j = 0; j < parts.Length; j++)
                        {
                            int id;
                            if (int.TryParse(parts[j].Trim(), out id))
                            {
                                try
                                {
                                    Answer found = q.Answers.GetById(id);
                                    bool isDup = false;
                                    for (int k = 0; k < count; k++) if (temp[k].Id == found.Id) isDup = true;
                                    if (!isDup) temp[count++] = found;
                                }
                                catch { hasError = true; break; }
                            }
                            else { hasError = true; break; }
                        }

                        if (!hasError && count > 0)
                        {
                            studentSelected = new Answer[count];
                            for (int x = 0; x < count; x++) studentSelected[x] = temp[x];
                            break;
                        }
                        Console.WriteLine("Invalid IDs or format. Try again.");
                    }
                    selectedExam.QuestionAnswerDictionary.Add(q, studentSelected);
                }
                else
                {
                    Answer studentAnswer = null;
                    while (true)
                    {
                        Console.Write("Enter Answer ID: ");
                        int id;
                        if (int.TryParse(Console.ReadLine(), out id))
                        {
                            try { studentAnswer = q.Answers.GetById(id); break; }
                            catch (Exception ex) { Console.WriteLine(ex.Message); }
                        }
                        else { Console.WriteLine("Please enter a valid number."); }
                    }
                    selectedExam.QuestionAnswerDictionary.Add(q, new Answer[] { studentAnswer });
                }
                Console.WriteLine();
            }

            selectedExam.Finish();
            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
        }
    }
}