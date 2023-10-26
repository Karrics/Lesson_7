using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osnova
{
    internal class Task
    {
        private string tasks;
        private WorkingDepartments task_Address;


        public string Tasks
        {
            get
            {
                return tasks;
            }
        }

        public WorkingDepartments Task_Address
        {
            get
            {
                return task_Address;
            }
        }



        public Task(string tasks, WorkingDepartments task_Address)
        {
            this.tasks = tasks;
            this.task_Address = task_Address;
        }
    }
}
