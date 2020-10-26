using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Class
{
    class WorkTask
    {
        private string memberName;
        private string taskDescription;
        private DateTime dueDate;
        private bool completedOrNot;

        public string MemberName
        {
            get { return memberName; }
            set { memberName = value; }
        }
        public string TaskDescription
        {
            get { return taskDescription; }
            set { taskDescription = value; }
        }
        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        public bool CompletedOrNot
        {
            get { return completedOrNot; }
            set { completedOrNot = value; }
        }

        public WorkTask()
        {
            MemberName = "MemberName";
            DueDate = DateTime.Parse("01/01/0001");
            CompletedOrNot = false;
            TaskDescription = "TaskDescription";

        }

        public WorkTask(string memberName, DateTime dueDate, bool completedOrNot, string taskDescription)
        {
            MemberName = memberName;
            DueDate = dueDate;
            CompletedOrNot = completedOrNot;
            TaskDescription = taskDescription;

        }

        public void DisplayTaskInformation()
        {
            Console.WriteLine($"\tMember Name: { MemberName }");
            Console.WriteLine($"\tDue Date: { DueDate }");
            Console.WriteLine($"\tTask completed?: {completedOrNot}");
            Console.WriteLine($"\tTask Description: { TaskDescription }");

        }

    }
}
