using System;

namespace BLL.Entities
{
    public class Employee : EntityBase
    {
        public Employee() => this.State = EntitySate.Added;

        public string? EmpID { get; set; }

        public required string FName
        {
            get;
            set
            {
                if (field != value)
                {
                    field = value;
                    if (State != EntitySate.Added)
                        this.State = EntitySate.Modified;
                }
            }
        }

        public required string LName
        {
            get;
            set
            {
                if (field != value)
                {
                    field = value;
                    if (State != EntitySate.Added)
                        this.State = EntitySate.Modified;
                }
            }
        }

        public short JobLevel
        {
            get;
            set
            {
                if (field != value)
                {
                    field = value;
                    if (State != EntitySate.Added)
                        this.State = EntitySate.Modified;
                }
            }
        }

        public short JobID
        {
            get;
            set
            {
                if (field != value)
                {
                    field = value;
                    if (State != EntitySate.Added)
                        this.State = EntitySate.Modified;
                }
            }
        }
        public override string ToString()
        {
            return $"""
                  name {FName + LName}  and jobID is {JobID} and
                   job level {JobLevel}  
                """;
        }
       
    }
}