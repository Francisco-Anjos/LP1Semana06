

namespace GameSix
{
    public class Foe
    {
        // Class attributes
        private string name;
        private float health;
        private float shield;
        
        // Name
        public string GetName()
        {
            return name;   
        }
        //Constructor
        public Foe(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }
        // Damage taking
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float DamageStillToInflict = -shield;
                shield =0;
                health -=DamageStillToInflict;
                if (health < 0) health = 0;
            }
        }

    }
}