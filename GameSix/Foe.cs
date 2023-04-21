

namespace GameSix
{
    public class Foe
    {
        // Class attributes
        private string name;
        private float health;
        private float shield;
        //Constructor
        public Foe(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }
    }
}