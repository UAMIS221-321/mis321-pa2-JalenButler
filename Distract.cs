using System;
using mis321_pa2_JalenButler.Interfaces;

namespace mis321_pa2_JalenButler
{
    public class Distract : IAttack
    {
       

        public void Attack()
        {
            Console.WriteLine("Distracting you goofy");
        }
    }
}