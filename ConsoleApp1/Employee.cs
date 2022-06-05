using System;

namespace ConsoleApp1
{
    class Employee 
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public bool HasBachelorDegree { get; set; }
        public Employee()
        {
        start:
            try
            {               
                Console.WriteLine("İşçinin adını daxil edin:");
                Name = Console.ReadLine();           
                Console.WriteLine("İşçinin soyadını daxil edin:");
                SurName = Console.ReadLine();
                Console.WriteLine("Maaşı daxil edin:");
                string salary = Console.ReadLine();
                Salary = int.Parse(salary);
                Console.WriteLine("İş Tecrübesi:");
                string experience = Console.ReadLine();
                Experience = int.Parse(experience);
                Console.WriteLine("Bakalavr derecesi (true veya false):");
                string bacheloordegree = Console.ReadLine();
                HasBachelorDegree = bool.Parse(bacheloordegree);                
            }
            catch (Exception)
            {
                Console.WriteLine("Zehmet olmasa duzgun daxil edin...");
                goto start;
            }
        }
    }
}
