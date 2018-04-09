using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human human1 = new Human("Alex");
            Console.WriteLine("Human: {0}, strength: {1}, intelligence: {2}, dexterity: {3}, and health: {4}.", human1.name, human1.strength, human1.intelligence, human1.dexterity, human1.health);

            Human new_guy = new Human("Tim", 50, 2, 15, 80);
            Console.WriteLine("Human: {0}, strength: {1}, intelligence: {2}, dexterity: {3}, and health: {4}.", new_guy.name, new_guy.strength, new_guy.intelligence, new_guy.dexterity, new_guy.health);

            human1.Attack(new_guy);

            Console.WriteLine("Human: {0}, strength: {1}, intelligence: {2}, dexterity: {3}, and health: {4}.", new_guy.name, new_guy.strength, new_guy.intelligence, new_guy.dexterity, new_guy.health);

        }
    }
}
