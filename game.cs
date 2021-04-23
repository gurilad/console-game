"# console-game" 
using System;
using System.Collections.Generic;


namespace ClassLibary4
{
    class Program
    {
        private static string td;

        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.DarkGray;


            void simulation()
            {
                Random rnd = new Random();
                bool OG = false; //orange juice
                List<String> p_has = new List<String>();
                int edgication = 0;
                String job = null;
                float money = 0.0f;
                float Energy = 10;
                float raise = 0.0f;

                Console.Write("Enter your name: ");
                Console.ForegroundColor = ConsoleColor.Green;
                String Ename = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkBlue;

                Console.Write("so your name is: " + Ename + "?");
                Console.ForegroundColor = ConsoleColor.Green;
                String nameYF = Console.ReadLine();
                if (nameYF == "yes")
                {
                    Console.WriteLine("cool");
                    String Pname = Ename;

                }
                else if (nameYF == "no")
                {
                    Console.WriteLine("what is it then?");
                    simulation();
                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;



                void todo()
                {
                    if (Energy <= 0)
                    {
                        raise = 0f;
                        edgication = 0;
                        job = null;
                        money = 0f;
                        Energy = 10;
                        
                        Console.Write("you have died, you need to watch your Energy you have lost everything :( better luck next time, wanna play again?");
                        String PA = Console.ReadLine();
                        if (PA == "yes")
                        {
                            Console.Clear();
                            simulation();
                        }
                        else if (PA == "no")
                        {
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        Console.Write("you have " + Energy + " Energy");
                        Console.Write("\nChoose something to do from the list: ");
                        Console.Write("\nlearn");
                        Console.Write("\nwork");
                        Console.Write("\nrelaxe");
                        Console.Write("\nnew job");
                        Console.Write("\nuse");
                        Console.Write("\nshop\n");



                        String td = Console.ReadLine();
                        if (td == "relaxe") { relaxe(); }
                        if (td == "learn") { learn(); }
                        if (td == "work") { work(); }
                        if (td == "new job") { N_job(); }
                        if (td == "shop") { shop(); }
                        if (td == "use") { Console.Write("What would you like to use? "); use(Console.ReadLine()); }
                    }

                }
                todo();




                //im puting it here so it doesnt have to process the intire thing every time and clean some code :)


                


                void shop()
                {
                    Console.Clear();
                    Console.Write("what would you like to purchess? ");
                    Console.Write("\nmilk (+3 energy when used)");
                    Console.Write("\nOringe juice (+2 energy when used)");
                    Console.Write("\na  Donut (+2 comfidence)");  //anything u want in the shop just say in chat :)

                    String O_shop = Console.ReadLine(); //o stands for option
                     
                    if (O_shop == "milk  (Gain 5 energy points)")
                    {
                        
                        if (money >= 260)
                        {
                            p_has.Add("milk");
                            Console.Write("you got milk!");
                            money -= 260;
                            todo();
                        }
                        else { Console.Write("you dont have enough money, you need atleast 260 shmiols to purchess this item"); todo(); }
                        
                    }
                    else if (O_shop == "orange juice (if used and then you go to sleep you will wake up with 15 Energy!!)")
                    {
                        if (money >= 190)
                        {
                            p_has.Add("orange juice");
                            Console.Write("you got orange juice!");
                            money -= 190;
                            todo();
                        }
                        else { Console.Write("you dont have enough money, you need atleast 190 shmiols to purchess this item"); todo(); }
                    }
                    else if (O_shop == "donut (will boost your comfidence and has 45% chance to give you a raise 5% to fire you and 50% nothing will happen)")
                    {
                        if (money >= 200)
                        {
                            p_has.Add("donut");
                            Console.Write("you got a donut");
                            money -= 200;
                            todo();
                        }
                        else { Console.Write("you dont have enough money, you need atleast 200 shmiols to purchess this item"); todo(); }
                    }
                    
                }
                

                void use(String arg)
                {
                    if (p_has.Contains(arg))
                    {
                        if (arg == "milk")
                        {
                            Energy += 5;
                            Console.WriteLine("you gained 5 energy points");
                            todo();
                        }
                        else if (arg == "orange juice")
                        {
                            OG = true;
                            Console.Write("next time you rest you will wake up with 15 energy points");
                            todo();
                        }
                        else if (arg == "donut")
                        {
                            int chanceD = rnd.Next(0, 101);
                            if (chanceD >= 1 && chanceD <= 45)
                            {
                                raise += 100f;
                                Console.Write("you got +100 raise");
                                todo();
                            }
                            else if (chanceD >= 46 && chanceD <= 50)
                            {
                                job = null;
                                Console.Write("you asked for a raise and got fired :(!");
                                todo();

                            }
                            else if (chanceD >= 51 && chanceD <= 100)
                            {
                                Console.Write("...");
                                Console.Write("nothing happend");
                                todo();
                            }
                        }
                        else{
                            todo();

                        }
                    }
                }


                void relaxe() {
                    
                        Energy = 10;
                        Console.WriteLine("\n Energy has been restored");
                        todo();
                    
                } 



                void N_job() {
                    
                        Energy -= 1;
                        Console.Write("what job would u like? (keep in mind you need to have certian amount of edicuation to get certian jobs)");
                        Console.WriteLine("doctor");
                        Console.WriteLine("programmer");
                        Console.WriteLine("3d moddler");
                        Console.WriteLine("office worker");
                        Console.WriteLine("");
                        String M_job = Console.ReadLine(); //m stands for maybe, so its maybe job it might be that would be their job

                        if (M_job == "doctor")
                        {
                            if (edgication >= 35)
                            {
                                job = M_job;
                                Console.WriteLine("you got the job!");
                                todo();
                            }
                            else { Console.WriteLine("you dont have enough edgication, you need atleast 35 edgication points to get this job maybe next time"); todo(); }
                        }
                        else if (M_job == "programmer")
                        {
                            if (edgication >= 25)
                            {
                                job = M_job;
                                Console.WriteLine("you got the job!");
                                todo();
                            }
                            else { Console.WriteLine("you dont have enough edgication, you need atleast 25 edgication points to get this job maybe next time"); todo(); }
                        }
                        else if (M_job == "3d moddler")
                        {
                            if (edgication >= 25)
                            {
                                job = M_job;
                                Console.WriteLine("you got the job!");
                                todo();
                            }
                            else { Console.WriteLine("you dont have enough edgication, you need atleast 25 edgication points to get this job maybe next time"); todo(); }
                        }
                        else if (M_job == "office worker")
                        {
                            if (edgication >= 10)
                            {
                                job = M_job;
                                Console.WriteLine("you got the job!");
                                todo();
                            }
                            else { Console.WriteLine("you dont have enough edgication, you need atleast 10 edgication points to get this job maybe next time"); todo(); }
                        }
                    
                }

                void work()
                {

                    
                        Energy -= 1;
                        if (job == null)
                        {
                            Console.WriteLine("you have no job");
                            todo();
                        }
                        else if (job == "doctor")
                        {
                            money += 200f + raise;
                            Console.WriteLine("i have gained 200 shmiols");
                            todo();
                        }
                        else if (job == "programmer")
                        {
                            money += 100f + raise;
                            Console.WriteLine("i have gained 100 shmiols");
                            todo();
                        }
                        else if (job == "moddeler")
                        {
                            money += 100f + raise;
                            Console.WriteLine("i have gained 100 shmiols");
                            todo();
                        }
                        else if (job == "office worker")
                        {
                            money += 50f + raise;
                            Console.WriteLine("i have gained 50 shmiols");
                            todo();
                 }
                    
                }

                void learn()
                {
                    
                    
                        edgication += 1;
                        Console.WriteLine("you have learnt, your edication has gone up by 1");
                        Energy -= 1;
                        todo();
                       }
                   
                }

                
                

            simulation();
            Console.ReadLine(); 
        }
    }
}



