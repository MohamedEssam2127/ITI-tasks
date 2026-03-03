using System;
using System.Collections.Generic;
using System.Text;
using System;

namespace LAB_7.Answers
{
    public class AnswerList
    {
        private Answer[] answers;
        private int count;

        public AnswerList(int capacity = 4)
        {
            if (capacity <= 0) throw new ArgumentException("Capacity must be > 0");
            answers = new Answer[capacity];
            count = 0;
        }

        //public int Count => count;
        public int Count { get { return count; }  }

        public void Add(Answer answer)
        {
            if (answer == null) throw new ArgumentNullException(nameof(answer));

            

            answers[count++] = answer;
        }

        public Answer GetById(int id)
        {
            for (int i = 0; i < count; i++)
                if (answers[i].Id == id)
                    return answers[i];

            throw new InvalidOperationException("Answer not found");
        }

        public Answer this[int index]
        {
            get
            {
                if (index < 0 || index >= count) throw new IndexOutOfRangeException();
                return answers[index];
            }
            set
            {
                if (index < 0 || index >= count) throw new IndexOutOfRangeException();
                answers[index] = value ?? throw new ArgumentNullException();
            }
        }
    }
}