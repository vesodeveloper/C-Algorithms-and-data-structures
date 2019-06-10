using System;

namespace Task3
{
    class Empl
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Departament { get; set; }
        public Empl(string name,double salary,string departament)
        {
            this.Name = name;
            this.Salary = salary;
            this.Departament = departament;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            double maxi=0;
            Console.WriteLine("Enter maximum employees:");
            var num = int.Parse(Console.ReadLine());
            Empl empl = new Empl( "Veso",5.5, "Coding");
            double[] sal = new double[num]; double fst = sal[0];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter name:");
                empl.Name = Console.ReadLine();
                Console.WriteLine("Enter salary:");
                empl.Salary = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter departament:");
                empl.Departament = Console.ReadLine();
                for (int i = 0; i < num; i++)
                {
                    if (fst>empl.Salary)
                    {
                        maxi = fst;
                    }

                }

            }
            if (fst > empl.Salary)
            {
                Console.WriteLine("Name" + empl.Name + "Salary" + maxi + "Depart" + empl.Departament);
            }
        }
    }
}
