using System;

namespace oop1._3
{
    class zoo
    {
        public string Animal;
        public string Sex;
        public string Name;
        internal int Price;
        internal int Amount;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Зоомагазин");
            zoo zoo = new zoo();

            Console.Write("Введите животное: ");
            zoo.Animal = Convert.ToString(Console.ReadLine());

            Console.Write("Введите пол: ");
            zoo.Sex = Convert.ToString(Console.ReadLine());

            Console.Write("Введите кличку: ");
            zoo.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Введите цену: ");
            zoo.Price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество: ");
            zoo.Amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------------");
            Console.WriteLine("---------------");
            Console.WriteLine(zoo.Animal);
            Console.WriteLine(zoo.Sex);
            Console.WriteLine(zoo.Name);
            Console.WriteLine(zoo.Price);
            Console.WriteLine(zoo.Amount);
            Console.WriteLine("---------------");
            Console.ReadLine();
        }
    }
}
