namespace human
{
    public class Human
    { 
        public int strength;
        public int intelligence;
        public int dexterity;
        public int health;
        public string name;
        public Human(string val)
        {
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
            name = val;
        }

        public Human(string val, int a, int b, int c, int d)
        {
            strength = a;
            intelligence = b;
            dexterity = c;
            health = d;
            name = val;
        }

        public void Attack(Human guy)
        {
            guy.health -= 5*strength;
        }
    }
}