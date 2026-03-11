using BLL.Entities;
using BLL.EntityLists;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace BLL.EntityManagers
{
    public class EmployeeManager
    {
        static DBManager Manager = new();

        public static EmployeeList SelectALLEmployees()
        {
            try
            {
                return DataTableToEmployeeList(
                Manager.ExecuteDataTable("SelectALLEmployees"));
            }
            catch
            {
            }
            return new();
        }

        public static bool InsertEmployee(Employee E)
        {
            try
            {
                Dictionary<string, object> Parameters = new()
                {
                    ["@emp_id"] = E.EmpID,
                    ["@fname"] = E.FName,
                    ["@lname"] = E.LName,
                    ["@minit"] = "M",
                    ["@job_id"] = E.JobID,
                    ["@job_lvl"] = E.JobLevel,
                    ["@pub_id"] = "9952",
                    ["@hire_date"] = DateTime.Now
                };
                return Manager.ExecuteNonQuery("InsertEmployee", Parameters) > 0;
            }
            catch
            {
            }
            return false;
        }

        public static bool UpdateEmployee(Employee E)
        {
            try
            {
                Trace.WriteLine($"Emp Update { E } ");
                Dictionary<string, object> Parameters = new()
                {
                    ["@emp_id"] = E.EmpID.Trim(),
                    ["@fname"] = E.FName,
                    ["@lname"] = E.LName,
                    ["@minit"] = "M",
                    ["@job_id"] = E.JobID,
                    ["@job_lvl"] = E.JobLevel,
                    ["@pub_id"] = "9952"
                };
                return Manager.ExecuteNonQuery("UpdateEmployee", Parameters) > 0;
            }
            catch
            {
                //Trace.WriteLine("ERRRRRRRRRRRRRRRRRRRRRRRRRRRRORRRRRRRRRRRRRRR");
            }
            return false;
        }

        public static bool DeleteEmployee(string empID)
        {
            try
            {
                Dictionary<string, object> Parameters = new()
                {
                    ["@emp_id"] = empID
                };
                return Manager.ExecuteNonQuery("DeleteEmployee", Parameters) > 0;
            }
            catch
            {
            }
            return false;
        }

        #region Mapping Functions
        internal static EmployeeList DataTableToEmployeeList(DataTable dt)
        {
            EmployeeList Emps = new EmployeeList();
            try
            {
                foreach (DataRow item in dt.Rows)
                {
                    Emps.Add(DataRowToEmployee(item));
                }
            }
            catch
            {
            }
            return Emps;
        }

        internal static Employee DataRowToEmployee(DataRow Dr)
        {
            Employee E = new() { FName = string.Empty, LName = string.Empty };
            try
            {
                E.EmpID = Dr.Field<string>("emp_id");
                E.FName = Dr["fname"]?.ToString() ?? "NA";
                E.LName = Dr["lname"]?.ToString() ?? "NA";

                E.JobLevel = Convert.ToInt16(Dr["job_lvl"]);
                E.JobID = Convert.ToInt16(Dr["job_id"]);

                E.State = EntitySate.UnChanged;
            }
            catch
            {
            }
            return E;

        }
        #endregion
    }
}
