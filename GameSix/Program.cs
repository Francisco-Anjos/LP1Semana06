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
            //Create the enemy, Default HP , Shield
            Foe God = new Foe("God");
            Console.WriteLine($"\nDefault name: {God.GetName()}");
            Console.WriteLine($"IHealth: {God.GetHealth()}");
            Console.WriteLine($"IShield: {God.GetShield()}");
            // Enemy pickup 
            God.PickupPowerUp(PowerUp.Health,20);
            God.PickupPowerUp(PowerUp.Shield,20);
            Console.WriteLine($"\nHealth p: {God.GetHealth()}");
            Console.WriteLine($"Shield p: {God.GetShield()}");
            //enemy Damage 
            God.TakeDamage(30);
            Console.WriteLine($"\nDhealth: {God.GetHealth()}");
            Console.WriteLine($"nDShield name: {God.GetShield()}");
            int powerUpCount = Foe.GetPowerUpCount();
            Console.WriteLine($"\nPowerup count: {powerUpCount}");


            Console.WriteLine("Thank you for using the program!");


        }
    }
}
