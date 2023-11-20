using System;

namespace B_E_Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            CostumeCollection<Eploy> eploys = new CostumeCollection<Eploy>();
            string devam;
            do
            {
                Console.WriteLine("1.Isdifadeci Alave elemek\n2.Id-sine gore Tapmag\n3.Hamisini cap etmek");
                string chois = Console.ReadLine();
                switch (chois)
                {
                    case "1":
                        Eploy eploy = new Eploy();
                        Console.WriteLine("Istifadeci adi:");
                        eploy.Name = Console.ReadLine();
                        Console.WriteLine("Istifadeci soy ad:");
                        eploy.Surname = Console.ReadLine();
                        Console.WriteLine("Istifadeci yasi:");
                        eploy.Age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Istifadeci maasi:");
                        eploy.Salary = double.Parse(Console.ReadLine());
                        eploys.Add(eploy);
                        break;
                    case "2":
                        Console.WriteLine("Id-ni daxil et:");
                        eploys.Src(int.Parse(Console.ReadLine()));
                        break;
                    case "3":
                        eploys.PrintAll();
                        break;
                }
                Console.WriteLine("Devam etmek ucun y/yes");
                devam = Console.ReadLine();
            } while (devam.ToLower() == "yes" || devam.ToLower() == "y");
            
        }
    }
}
