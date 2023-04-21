using System;

namespace GameSix
{
    public enum PowerUp
    {
        Health,
        Shield
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many enemies do you want to face");
            int Num =int.Parse(Console.ReadLine());

            Foe[] foes = new  Foe[Num];
            
            for (int i = 0; i < Num; i++)
            {
                Console.WriteLine(" Give them a name:");
                string name = Console.ReadLine();

                Foe enemy = new Foe(name);
                foes [i] = enemy;
            }
            Console.WriteLine("\nFoe Names: ");

            foreach (Foe foe in foes)
            {
                Console.WriteLine(foe.GetName());
            }
        }
    }
}
