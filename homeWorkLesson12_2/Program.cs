using System;
using System.Linq;

namespace homeWorkLesson12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var workers = new Worker[2];

            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine("Введите фамилию и инициалы работника:");
                workers[i].SurnameAndInitials = Console.ReadLine();

                Console.WriteLine("Введите его должность:"); 
                workers[i].Post = Console.ReadLine();

                Console.WriteLine("Введите год поступления на работу:");

                try
                {                    
                    workers[i].YearOfEmployment = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Год введен некорректно, поэтому будет установлено значение по умолчанию.");
                    workers[i].YearOfEmployment = DateTime.Now.Year;
                }
                
                Console.WriteLine(new string('-', 25));
            }

            //Sort
            workers = workers.OrderBy(worker => worker.SurnameAndInitials).ToArray();

            Console.WriteLine("Введите стаж:");
            var experience = Convert.ToInt32(Console.ReadLine());

            if (FindWorkerWithExperienceMoreThanValue(experience, workers, out Worker findWorker))
            {
                Console.WriteLine($"Первый удовлетворяющий условие сотрудник: {findWorker.SurnameAndInitials}");
            }
            else
            {
                Console.WriteLine("Таких сотрудников не существует!");
            }

            Console.ReadKey();
        }

        static bool FindWorkerWithExperienceMoreThanValue(int experience, Worker[] workers, out Worker findWorker)
        {
            foreach (var worker in workers)
            {
                var workerExperience = DateTime.Now.Year - worker.YearOfEmployment;

                if (workerExperience > experience)
                {
                    findWorker = worker;
                    return true;
                }
            }

            findWorker = default;
            return false;
        }
    }
}
