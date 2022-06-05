using System;

namespace ConsoleApp1
{
    class Department
    {
        public string Name { get; set; }
        public int EmployerLimit { get; set; }
        public int Budget { get; set; }
        public int RequiredExperience { get; set; }
        public bool IsBachelorDegreRequired { get; set; }
        Employee[] employees = new Employee[0];
        public Department()
        {
            string budget;
            string ask;
        first:
            try
            {
                Console.WriteLine("Departamentin Adi:");
                Name = Console.ReadLine();
                Console.WriteLine("İşçi sayı limiti:");
                string employerLimit = Console.ReadLine();
                EmployerLimit = int.Parse(employerLimit);
                Console.WriteLine("Departamentin ümumi büdcesi:");
                budget = Console.ReadLine();
                Budget = int.Parse(budget);
                Console.WriteLine("Minimum tecrübe:");
                string experience = Console.ReadLine();
                RequiredExperience = int.Parse(experience);
                Console.WriteLine("Bakalavr tehsili true/false:");
                string degree = Console.ReadLine();
                IsBachelorDegreRequired = bool.Parse(degree);
            }
            catch (Exception)
            {
                Console.WriteLine("Zehmet olmasa duzgun daxil edin...");
                goto first;
            }
            do
            {
                Console.WriteLine("İşçi elave etmek isteyirsinizmi? yes/no");
                ask = Console.ReadLine();
            } while (ask != "yes");
            do
            {
                if (ask == "yes")
                {
                    Employee employee = new();
                    if (AddEmployee(employee))
                    {
                        Console.WriteLine($"Tebrikler {employee.Name} {employee.SurName} adli isci siyahiya elave olundu...");
                    }
                    else if (!AddEmployee(employee))
                    {
                        Console.WriteLine("Isci elave olunmadi Zehmet olmasa melumatlari yeniden yoxlayin...");
                    }
                    Console.WriteLine("İşçi elave etmek isteyirsinizmi? yes/no");
                    ask = Console.ReadLine();
                }
                if (ask == "no")
                {
                    MaasOrtalama();
                }
            } while (ask == "yes");
        }
        public bool AddEmployee(Employee employee)
        {
            int sum = 0;

            if (IsBachelorDegreRequired == employee.HasBachelorDegree && RequiredExperience <= employee.Experience)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employee;
                foreach (var item in employees)
                {
                    sum += item.Salary;
                }
                if (EmployerLimit >= employees.Length && sum <= Budget)
                {
                    return true;
                }
            }
            return false;
        }
        public void MaasOrtalama()
        {
            int sum1 = 0;
            foreach (var item in employees)
            {
                sum1 += item.Salary;
                if (sum1 > Budget)
                {
                    sum1 = Budget;
                }
            }
            int count = employees.Length;
            Console.WriteLine($"Umumi maas ortalamasi :{sum1 / count}");
        }
    }
}

