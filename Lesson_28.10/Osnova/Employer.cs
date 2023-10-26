using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osnova
{
    internal class Employer
    {
        private string employerName;
        private string job;
        private WorkingDepartments workDepartment;
        private List<Employer> superiors = new List<Employer>();
       
        public string EmployerName
        {
            get
            {
                return employerName;
            }
        }

        public string Job
        {
            get
            {
                return job;
            }
        }

        public WorkingDepartments WorkDepartment
        {
            get
            {
                return workDepartment;
            }
        }


        public List<Employer> Superiors
        {
            get
            {
                return superiors;
            }
        }

        public void AssignmentOfTask(Task task, Employer employee)
        {
            Console.WriteLine($"От {employee.EmployerName} ({employee.Job}) дается задача\n{task.Tasks} работнику {employerName} ({job})");

            if (superiors.Contains(employee) && (workDepartment == task.Task_Address))
            {
                Console.WriteLine($"{employerName} ({job}) берет задачу");
            }
            else
            {
                Console.WriteLine($"{employerName} ({job}) не берет задачу");
            }
        }

        public Employer(string employeeName, string jobTitle, WorkingDepartments workDepartment, params Employer[] superiors)
        {
            this.employerName = employeeName;
            this.job = jobTitle;
            this.workDepartment = workDepartment;
            this.superiors.AddRange(superiors);
        }
    }
}
