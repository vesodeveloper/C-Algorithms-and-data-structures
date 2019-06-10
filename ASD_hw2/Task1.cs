using System;
using System.Collections.Generic;
using System.Linq;
namespace Task1
{
    abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
    }
    class Truck : Vehicle
    {
        public double Weight { get; set; }
    }
    class Cars : Vehicle
    {
        public double HorsePower { get; set; }
    }
    class Catalog
    {
        List<Truck> trucks = new List<Truck>();
        List<Cars> cars = new List<Cars>();
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            var inp = new Dictionary<string, Dictionary<string, string>>();
            var inpstr = "";
            do
            {
                inpstr = Console.ReadLine();
                string[] str = inpstr.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                string type = str[0];
                string brand = str[1];
                string model = str[2];
                string power = str[3];
                double pw = double.Parse(power);
                if ((inp.ContainsKey(str[0])) == false)
                {
                    inp.Add(type, new Dictionary<string, string>() { { brand, model } }); }
                else {
                    if ((inp[model].ContainsKey(power)) == false)
                    {
                        inp[model].Add( model, power);
                    }
                }

            } while (inpstr != "end");
                     foreach (var item in inp
                     .OrderBy(x =>x.Key)
                     .ThenBy(x => x.Value))
                foreach (var i in inp)
                {
                    Console.WriteLine(i);
                }





            Console.ReadKey();


            /*var Lang = new Dictionary<string, string>();
            Lang.Add("C++", "Stroustrup");
            Lang.Add("C", "Richie");
            foreach (var item in Lang)
            {
                Console.WriteLine(item);
            }*/

        } } }
