using System;
using mis321_pa2_JalenButler.Interfaces;

namespace mis321_pa2_JalenButler
{
    public class Sword : IAttack
    {
         public void Attack()
        {
            Console.WriteLine("Slicing you with the sword goofy");
        }
    }
}