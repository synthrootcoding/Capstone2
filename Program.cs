using Class;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Capstone2
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkTask person1 = new WorkTask("Brian", DateTime.Parse("02/20/1992"), false, "Design graphics");
            WorkTask person2 = new WorkTask("Rachel", DateTime.Parse("06/21/1996"), false, "Illustrate characters");
            List<WorkTask> people = new List<WorkTask>();
            people.Add(person1); people.Add(person2);
            Console.WriteLine("Hello user\n");
            GetUserInput("Press Enter to continue");
            Console.Clear();
            while (true)
            {
                Console.WriteLine("1.List Tasks");
                Console.WriteLine("2.List individual task");
                Console.WriteLine("3.Add Task");
                Console.WriteLine("4.Delete Task");
                Console.WriteLine("5.Mark Task Complete");
                Console.WriteLine("6.Quit\n");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                if (userInput == "1")
                {
                    Console.Clear();
                    foreach (WorkTask task in people)
                    {
                        Console.WriteLine($"\tTask number: {people.IndexOf(task) + 1}");
                        task.DisplayTaskInformation();
                        Console.WriteLine();
                    }
                }
                if (userInput == "2")
                {
                    Console.Clear();
                    int singleTaskPick = (Convert.ToInt32(GetUserInput("Which task would you like to read about?: \n")) - 1);
                    if (singleTaskPick >= 0 && singleTaskPick < people.Count)
                    {
                        Console.WriteLine($"\tTask number: {people.IndexOf(people[singleTaskPick]) + 1}");
                        people[singleTaskPick].DisplayTaskInformation();
                        Console.WriteLine();
                    }
                }
                if (userInput == "3")
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Add a task to the list\n");
                        string memberName = GetUserInput("Who will work on the task? [First name]: \n");
                        Console.WriteLine();
                        DateTime dueDate = Convert.ToDateTime(GetUserInput("Due date? [MM/DD/YYY HH:MM:SS AM/PM format]: \n"));
                        Console.WriteLine();
                        string taskDescription = GetUserInput("Short description of task: \n");
                        Console.WriteLine();
                        WorkTask person = new WorkTask(memberName, dueDate, false, taskDescription);
                        people.Add(person);
                        Console.WriteLine();
                        break;
                    }
                }
                if (userInput == "4")
                {
                    while (true)
                    {
                        Console.Clear();
                        foreach (WorkTask task in people)
                        {
                            Console.WriteLine($"\tTask number: {people.IndexOf(task) + 1}");
                            task.DisplayTaskInformation();
                            Console.WriteLine();
                        }
                        int deleteInput = (Convert.ToInt32(GetUserInput("Which task would you like to delete? [#]: \n")) - 1);
                        if (deleteInput >= 0 && deleteInput < people.Count)
                        {
                            
                            Console.WriteLine();
                            string deleteAnswer = GetUserInput("Are you sure you want to delete this task? [y/n]: \n").ToLower();
                            if (deleteAnswer == "y")
                            {
                                people.RemoveAt(deleteInput);
                                Console.WriteLine();
                                Console.Clear();
                                Console.WriteLine("Task deleted\n");
                                break;
                            }
                            if (deleteAnswer == "n")
                            {
                                Console.WriteLine();
                                Console.Clear();
                                Console.WriteLine("Returning to main menu...\n");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                            }
                        }
                    }
                }
                if (userInput == "5")
                {
                    while (true)
                    {
                        Console.Clear();
                        foreach (WorkTask task in people)
                        {
                            Console.WriteLine($"\tTask number: {people.IndexOf(task) + 1}");
                            task.DisplayTaskInformation();
                            Console.WriteLine();
                        }
                        int completeInput = (Convert.ToInt32(GetUserInput("Which task would you like to mark as complete? [#]: \n")) - 1);
                        if (completeInput >= 0 && completeInput < people.Count)
                        {
                            Console.WriteLine();
                            string completeAnswer = GetUserInput("Are you sure you want to mark this task as complete? [y/n]: \n").ToLower();
                            if (completeAnswer == "y")
                            {
                                people[completeInput].CompletedOrNot = true;
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("Task marked as complete\n");
                                break;
                            }
                            if (completeAnswer == "n")
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("Returning to main menu...\n");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                            }
                        }
                    }
                }
                else if (userInput == "6")
                {
                    Console.Clear();
                    Console.WriteLine("Goodbye");
                    break;
                }
            }
        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string UserInfo = Console.ReadLine();
            return UserInfo;
        }

    }
}
