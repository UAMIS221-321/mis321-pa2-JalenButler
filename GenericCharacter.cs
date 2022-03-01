
using System;
using System.IO;
using mis321_pa2_JalenButler.Interfaces;
namespace mis321_pa2_JalenButler
{
    public class GenericCharacter 
    {
        public string Name{get; set;}
        public double MaxPower{get; set;}
        public double Health{get; set;}
        public double AttackStrength{get; set;}
        public double DefensivePower{get; set;}

        public IAttack AttackBehavior{get; set;}

        public void SetAttackBehavior(IAttack AttackBehavior)
        {
            this.AttackBehavior = AttackBehavior;
        }

        public void DisplayStats()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Health: {0}", Health);
            Console.WriteLine("Max Power: {0}", MaxPower);
            Console.WriteLine("Attack Strength: {0}", AttackStrength);
            Console.WriteLine("Defensive Power: {0}", DefensivePower);
        }
    }
}