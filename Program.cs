
using System;
using System.IO;



namespace mis321_pa2_JalenButler
{
    class Program
    {
        static void Main(string[] args)
        {

            //These random numbers generate all the stats for the characters, yes I know this was an inefficient way to do this will learn better way next time 
           
            
            Random mprandom = new Random();
            int JSmp;
            JSmp = mprandom.Next(2, 101);

            Random assrandom = new Random();
            int JSass;
            JSass = assrandom.Next(2, JSmp);

            Random dprandom = new Random();
            int JSdp;
            JSdp = dprandom.Next(2, JSmp);
            // ///////////////////////////
            
            Random mprandom1 = new Random();
            int DJmp;
            DJmp = mprandom1.Next(2, 101);

            
            Random assrandom1 = new Random();
            int DJass;
            DJass = assrandom1.Next(2, DJmp);

            Random dprandom1 = new Random();
            int DJdp;
            DJdp = dprandom1.Next(2, DJmp);
            ///////////////////////////////



            
            Random mprandom2 = new Random();
            int WTmp;
            WTmp = mprandom2.Next(2, 101);

            
            Random assrandom2 = new Random();
            int WTass;
            WTass = assrandom2.Next(2, WTmp);

            Random dprandom2 = new Random();
            int WTdp;
            WTdp = dprandom2.Next(2, WTmp);
            

         

            
            

            //These are my characters that are playable I added an extra playable character called Jalen Butler who will never lose a game because he is overpowered in every statistical category just like in real life :)

            JackSparrow jacksparrow = new JackSparrow(){Name = "Jack Sparrow", Health = 100, MaxPower = JSmp, AttackStrength = JSass, DefensivePower = JSdp };
            DavyJones davyjones = new DavyJones(){Name = "Davy Jones", Health = 100, MaxPower = DJmp, AttackStrength = DJass, DefensivePower = DJdp};
            WillTurner willturner = new WillTurner(){Name = "Will Turner", Health = 100, MaxPower = WTmp, AttackStrength = WTass, DefensivePower = WTdp};
            JalenButler jalenbutler = new JalenButler(){Name = "Jalen Butler", Health = 1000, MaxPower = 100, AttackStrength = 100, DefensivePower = 100};
            GenericCharacter Gen1 = new GenericCharacter();
            GenericCharacter Gen2 = new GenericCharacter();

           

            
            string player1;
            string player2;

            Console.WriteLine("****************************************");
            Console.WriteLine("Welcome to Battle of Calypso's Maelstrom(Pirate noisesss)");
            Console.WriteLine("****************************************");


            Console.WriteLine("Player 1 what is your name?");
            player1 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Player 2 what is your name?");
            player2 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("{0} What character would you like to play as?", player1);
            Console.WriteLine("1 for Jack, 2 for Davy, 3 for Will, 4 for Jalen");
            Console.WriteLine();
            int player1Answer = int.Parse(Console.ReadLine());
            switch (player1Answer)
            {
                case 1: Gen1 = jacksparrow;
                break;

                case 2: Gen1 = davyjones;
                break;

                case 3: Gen1 = willturner;
                break;

                case 4: Gen1 = jalenbutler;
                break;

                 
                
                default:
                break;
            }

            

            Console.WriteLine("{0} What character would you like to play as?", player2);
            Console.WriteLine("1 for Jack, 2 for Davy, 3 for Will");
            int player2Answer = int.Parse(Console.ReadLine());
               switch (player2Answer)
            {
                case 1: Gen2 = jacksparrow;
                break;

                case 2: Gen2 = davyjones;
                break;

                case 3: Gen2 = willturner;
                break;

                case 4: Gen2 = jalenbutler;
                break;

                 
                
                default:
                break;
            }


             Gameplay(Gen1, Gen2);
        


          

            
        }
        public static void Gameplay(GenericCharacter Gen1, GenericCharacter Gen2)
        {
        double damageDone;
        double damageDone2;
        double typebonus = 1; 


        
        Console.WriteLine("Randomizing who goes first.........");
        Random random = new Random();
        int random2;
        random2 = random.Next(2);

        if(random2 == 0)
        {

            if (Gen1.Name == "Jack Sparrow" && Gen2.Name == "Will Turner")
            {
                typebonus = 1.2;
            }

            else if (Gen1.Name == "Will Turner" && Gen2.Name == "Davy Jones")
            {
                typebonus = 1.2;
            }
            else if (Gen1.Name == "Davy Jones" && Gen2.Name == "Jack Sparrow")
            {
                typebonus = 1.2;
            }
           


            Console.WriteLine(Gen1.Name, " Is attacking fisrt");
            while (Gen1.Health > 0 && Gen2.Health > 0)
            {
                Console.WriteLine("Press space to attack ", Gen1.Name);
                Gen1.AttackBehavior.Attack();
                Console.ReadKey();
                Console.WriteLine("");

                if (Gen2.DefensivePower > Gen1.AttackStrength)
                {
                    Gen2.Health = Gen2.Health - 15;
                }
                else if(Gen2.DefensivePower < Gen1.AttackStrength)
                {
                damageDone =  (Gen1.AttackStrength - Gen2.DefensivePower) * typebonus;
                Gen2.Health = Gen2.Health - damageDone;
                }
                Gen2.DisplayStats();

                if (Gen2.Health <= 0)
                {
                    break;
                }

                Console.WriteLine(Gen2.Name, " It is your turn to attack");
                Console.WriteLine("Press space to attack ", Gen2.Name);
                Gen2.AttackBehavior.Attack();
                Console.ReadKey();
                Console.WriteLine("");
                if(Gen1.DefensivePower > Gen2.AttackStrength)
                {
                    Gen1.Health = Gen1.Health - 15;
                }

                else if(Gen1.DefensivePower < Gen2.AttackStrength)
                {
                damageDone2 = (Gen2.AttackStrength - Gen1.DefensivePower) * typebonus;
                Gen1.Health = Gen1.Health - damageDone2;
                }
                Gen1.DisplayStats();               
            }

        }
          if(random2 == 1)
        {

            if (Gen2.Name == "Jack Sparrow" && Gen1.Name == "Will Turner")
            {
                typebonus = 1.2;
            }

            else if (Gen2.Name == "Will Turner" && Gen1.Name == "Davy Jones")
            {
                typebonus = 1.2;
            }
            else if (Gen2.Name == "Davy Jones" && Gen1.Name == "Jack Sparrow")
            {
                typebonus = 1.2;
            }

            Console.WriteLine(Gen2.Name, " Is attacking fisrt");
            while (Gen1.Health > 0 && Gen2.Health > 0)
            {
                Console.WriteLine("Press space to attack ", Gen2.Name);
                 Gen2.AttackBehavior.Attack();
                Console.ReadKey();
                Console.WriteLine("");

                if(Gen1.DefensivePower > Gen2.AttackStrength)
                {
                    Gen1.Health = Gen1.Health - 15;
                }

                else if(Gen1.DefensivePower < Gen2.AttackStrength)
                {
                damageDone = (Gen2.AttackStrength - Gen1.DefensivePower) * typebonus;
                Gen1.Health = Gen1.Health - damageDone;
                }
                Gen1.DisplayStats();

                 if (Gen1.Health <= 0)
                {
                    break;
                }

                Console.WriteLine(Gen1.Name, " It is your turn to attack");
                Console.WriteLine("Press space to attack ", Gen1.Name);
                 Gen1.AttackBehavior.Attack();
                Console.ReadKey();
                Console.WriteLine("");

                if (Gen2.DefensivePower > Gen1.AttackStrength)
                {
                    Gen2.Health = Gen2.Health - 15;
                }


                else if(Gen2.DefensivePower < Gen1.AttackStrength)
                {
                damageDone2 = (Gen1.AttackStrength - Gen2.DefensivePower) * typebonus;
                Gen2.Health = Gen2.Health - damageDone2;
                }
                Gen2.DisplayStats();               
            }

        }

        }    


     
    }
}
