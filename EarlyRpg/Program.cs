using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EarlyRpg
{
    class Program
    {

        public static bool GetSword = false;
        public static bool GetArmor = false;
        public static bool GetLightArmor = false;
        public static bool Getshield = false;
        public static bool Get_Dagger = false;
        public static bool Get_Great_Sword = false;
        public static bool GetDragonS = false;
        public static bool GetDragonShield = false;
        public static bool Black_Exit = false;
        public static bool King_Deny = false;
        public static bool Kings_Token = false;
        public static bool Player_rest = false;
        public static bool Dragon_Hole = false;
        public static bool scale_Drop = false;
        public static bool Dragon_FRight = false;
        public static bool Kings_Motion = false;
        public static bool Kings_quest = false;
        public static bool Notice = false;
        public static bool Free_Item = false;
        public static bool Again = false;
        public static bool Dead = false;
        public static bool vial = false;
        public static bool stick = false;
        public static bool Chunk_Wood = false;
        public static int string1 = 0;
        public static bool alch = false;
        public static bool Leather = false;
        public static bool cloth = false;
        public static bool herb = false;
        public static int herb_Count = 0;
        public static bool Crossbow = false;
        public static bool bomb = false;
        public static bool medKit = false;
        public static bool Alcohol = false;
        public static bool Powder = false;
        public static bool Poison = false;
        public static bool Poison_Vial = false;
        public static bool crossuse = false;
        public static bool bomb_use = false;
        public static bool poison_use = false;

        public static int Out_Count = 0;
        public static int Gold = 0;
        public static int Player_Room = 1;
        public static int kings_count = 0;
        public static int Squire_count = 0;
        public static int Dragon_Scale = 0;
        public static bool Alerted = false;
        public static int Dragon_Count = 0;
        public static int Dragon_Health = 150;
        public static int Dragon_Swipe;
        public static int Drake_health = 50;
        public static int Drake_att;
        public static int Sword;
        public static int VialCT = 0;
        public static int powderCT = 0;
        public static int poisonCT = 0;
        public static int Player_Att = 1;
        public static int Player_Health = 100;


        static void Main(string[] args)

        {//Jesse Winden
            //SENG 100 thur 1-5
            //Midterm

            Intro();// Name and welcome
            Rules();// rules of the game
            startGame();


        }

        static void startGame()
        {
            PrintL("[Type Look]");
            string input = responseCommand();
            switch (input)
            {
                case "rules":// displays rules again if typed
                    Rules();
                    break;
                case "error":// for programmer to see whats working in the game
                    Console.WriteLine(Player_Room);
                    Console.WriteLine(Out_Count);
                    break;
                case "look":
                    lookArea();
                    break;
                case "crossbow":
                    if (Crossbow == true)
                    {
                        useCrossbow();
                    }
                    break;
                case "bomb":
                    useBomb();
                    break;
                case "ship":
                    Player_Room = 9;
                    PrintL("You find a thin strip of land that leads to the ship");
                    PrintL("It does no look like anyone has been on the ship for a lomg time");
                    PrintSomethingGreen("SEARCH ");// search case
                    PrintL("the ship?");
                    PrintSomethingGreen("LEAVE ");// leave case
                    PrintL("the ship?");
                    break;
                case "equip":
                    getWeaponsStats();
                    getUsableStats();
                    PrintSomethingred("[Press Enter]");
                    Console.ReadLine();
                    startGame();
                    break;
                case "east":
                    goEast();
                    break;
                case "north":
                    goNorth();
                    break;
                case "south":
                    goSouth();
                    break;
                case "west":
                    goWest();
                    break;
                case "king":

                    break;
            }
        }

        static void goEast()
        {
            if (Player_Room == 1)
            {
                PrintL("Now Leaving Town Square");
                PrintSomethingred("[Press Enter]");
                Console.ReadLine();
                Console.Clear();
                Player_Room = 2;
                if (Notice == false)// if first time in thone room
                {
                    Console.WriteLine("You enter the ThroneRoom when a squire runs up to you");
                    Console.Write("Squire:");
                    PrintSomethingTalk("It's Terrible the kingdom is under attack! Talk to the king!");
                    PrintSomethingred("[Press Enter]");
                    Console.ReadLine();
                    Notice = true;
                    lookArea();
                }
                lookArea();
            }
            if (Player_Room == 6)
            {
                Player_Room = 8;
                PrintL("Leaving Lake");
                PrintSomethingred("[Press Enter]");
                Console.ReadLine();
                Console.Clear();
                lookArea();
            }
        }
        static void goNorth()
        {
            if (Player_Room == 4)
            {
                PrintL("Now leaving clearing");
                PrintSomethingred("[Press Enter]");
                Console.ReadLine();
                Console.Clear();
                Player_Room = 1;
                lookArea();
            }
            if (Player_Room == 5)
            {
                PrintL("Now leaving cave");
                PrintSomethingred("[Press Enter]");
                Console.ReadLine();
                Console.Clear();
                Player_Room = 4;
                lookArea();
            }
            if (Player_Room == 6)
            {
                PrintL("Now leaving lake");
                PrintSomethingred("[Press Enter]");
                Console.ReadLine();
                Console.Clear();
                Player_Room = 5;
                lookArea();
            }
            if (Player_Room == 1)
            {
                PrintSomethingred("Where are you going?");
                PrintSomethingred("[Press Enter]");
                Console.ReadLine();
                Console.Clear();
                Player_Room = 1;
                lookArea();
            }
        }
        static void goSouth()
        {
            if (Player_Room == 5)
            {
                PrintL("Now Leaving Cave");
                PrintSomethingred("[Press Enter]");
                Console.ReadLine();
                Console.Clear();
                Player_Room = 6;
                lookArea();
            }
            if (Player_Room == 4)
            {
                PrintL("Now Leaving Clearing");
                PrintSomethingred("[Press Enter]");
                Console.ReadLine();
                Console.Clear();
                Player_Room = 5;
                lookArea();
            }
            if (Player_Room == 1)
            {
                if (Out_Count == 0)// if player has not talked to king no south is available
                {
                    PrintSomethingred("Where are you going!!??");
                }
                if (Out_Count == 2)// if king has been talked to and accepted 
                {
                    //go to "Outskirts";
                }
                if (Out_Count == 1)// if king denied
                {
                    PrintL("Now Leaving Town Square");
                    PrintSomethingred("[Press Enter]");
                    Console.ReadLine();
                    Console.Clear();
                    Player_Room = 4;
                    lookArea();
                }
            }
            if (Player_Room == 6)
            {
                PrintL("Now Leaving Lake");
                PrintSomethingred("[Press Enter]");
                Console.ReadLine();
                Console.Clear();
                Player_Room = 10;
                lookArea();
            }
        }
        static void goWest()
        {
            Console.Clear();
            if (Player_Room == 1)
            {
                PrintL("Now leaving town square");
                PrintSomethingred("[Press Enter]");
                Console.ReadLine();
                Console.Clear();
                Player_Room = 3;
                // goto case "BlackSmith";

            }
            if (Player_Room == 6)
            {
                PrintL("Now leaving lake");
                PrintSomethingred("[Press Enter]");
                Console.ReadLine();
                Console.Clear();
                Player_Room = 7;
                lookArea();
            }
        }
        static void getUsableStats()
        {
            PrintL("\nUsables:");// if player has item show them
            PrintL("Gold: " + Gold);

            if (Chunk_Wood == true)
            {
                PrintL("Wood");
            }
            if (cloth == true)
            {
                PrintL("Cloth");
            }
            if (stick == true)
            {
                PrintL("Stick");
            }
            if (string1 > 0)
            {
                PrintL("String");
            }
            if (Poison == true)
            {
                PrintL("Poison(unusable ATM)");
            }
            if (Poison_Vial == true)
            {
                PrintL("Poison (Usable)");
            }
            if (vial == true)
            {
                PrintL("Empty Vials");
            }
            if (Powder == true)
            {
                PrintL("Stange Powder");
            }
            if (Leather == true)
            {
                PrintL("leather");
            }
            if (herb == true)
            {
                PrintL("Herb");
            }
            if (Alcohol == true)
            {
                PrintL("Alcohol");
            }
        }
        static void getWeaponsStats()
        {
            PrintL("Player Health: " + Player_Health);//showing players health
            PrintL("\nWeapons/Armor");// if player has weapon show them
            if (Get_Dagger == true)
            {
                PrintL("Dagger Att (1-3)");
            }
            if (GetSword == true)
            {
                PrintL("Sword Att (3-6)");
            }
            if (GetDragonS == true)
            {
                PrintL("Dragon Sword Att (6-9) *Can use Shield*");
            }
            if (Get_Great_Sword == true)
            {
                PrintL("Great Sword Att (6-9)");
            }
            if (Getshield == true)
            {
                PrintL("Shield Def (1-3)");
            }
            if (GetDragonShield == true)
            {
                PrintL("Dragon Shield Att (2-5) *Immune to fire*");
            }
            if (GetLightArmor == true)
            {
                PrintL("Light Armor Def (1-3)");
            }
            if (GetArmor == true)
            {
                PrintL("Armor Att (2-5)");
            }
            if (Crossbow == true)
            {
                PrintL("CrossBow available");
            }
            if (bomb == true)
            {
                PrintL("Bomb available");
            }
        }
        static void useBomb()
        {
            PrintL("Throw Bomb?");
            PrintSomethingGreen("Yes/No");//choice
            string YES_NO;
            Blue_choice();
            YES_NO = Console.ReadLine();
            YES_NO = YES_NO.ToLower();// keeping answer as a lower
            if (YES_NO == "yes")// if choice yes
            {
                Console.ForegroundColor = ConsoleColor.White;
                PrintL("You throw the bomb at the stalagmites!");
                PrintL("With a loud BANG and a bright light, you hear the stalagmites begin to crack.");
                PrintL("The stalagmites start to fall on the Dragon, piercing its scales in many places.");
                PrintL("The Dragon is critically wounded!");
                bomb_use = true;//used bomb
                Dragon_Health = Dragon_Health - 100;// dragon heath reduction
                PrintL("Now, lets bring the fight to him!");
                Player_Room = 6;// setting room to lake
                PrintL("Heading back to lake.");
                Print("[Press Enter]");
                Console.ReadLine();
                Console.Clear();
                lookArea();// reloading case look
            }
            if (YES_NO == "no")// choice no
            {
                PrintL("The Dragon does not seem to be going anywhere.\n Might as well wait.");
                Player_Room = 8;// case lookout
                PrintL("Heading back to Lookout.");
                Print("[Press Enter]");
                Console.ReadLine();
                Console.Clear();
                lookArea();// go to case look
            }
            else
            {
                PrintSomethingred("What are you doing?");// if not yes or no
                useBomb();
            }
        }
        static void useCrossbow()
        {
            PrintL("Try to hit it with the CrossBow?");
            PrintSomethingGreen("Yes/No");// players option to shoot
            string shoot;
            Blue_choice();
            shoot = Console.ReadLine();
            shoot = shoot.ToLower();
            Console.ForegroundColor = ConsoleColor.White;
            if (shoot == "yes")// if player chooses to shoot
            {
                PrintL("You fire an arrow which directly hits your target.");
                PrintL("The Dragon stands up, thrashing about, and causing the cave to shake.");
                PrintL("Finally the Dragon falls over, breathing ever so slowly.");
                PrintL("Time to finish the dragon off, head on down.");
                crossuse = true;// dragon has been shot triggers dragons death later
                Player_Room = 6;// now  you are back in the lake
                PrintL("Heading back to lake.");
                Print("[Press Enter]");
                Console.ReadLine();
                Console.Clear();
                lookArea();// going back to specific case
            }
            if (shoot == "no")// did not shoot
            {
                PrintL("The Dragon does not seem to be going anywhere.\n Might as well wait.");
                Player_Room = 8;// room is now 8
                PrintL("Heading back to Lookout.");
                Print("[Press Enter]");
                Console.ReadLine();
                Console.Clear();
                lookArea();// reload case look

            }
            else
            {
                PrintSomethingred("What are you doing?");// if inputed wrong
                useCrossbow();
            }                         
            
        }
        static void lookArea()
        {
            Console.Clear();
            switch (Player_Room)
            {
                case 1:// displays rules again if typed
                    Console.WriteLine("You seem to be in a small field in the middle of a town.");
                    Console.WriteLine("A giant fountain is in front of you.\nThe fountain is of a dragon spiting water from its nostrils.");
                    Console.Write("To the ");
                    PrintSomethingGreen("WEST ");//option - blacksmith
                    if (Player_rest == false)
                    {
                        Console.WriteLine("is the Blacksmith");
                    }
                    if (Player_rest == true)//if player has refuse quest
                    {
                        Console.WriteLine("is the Blacksmith remains and to the ");
                    }
                    Console.Write("To the ");
                    PrintSomethingGreen("EAST ");//option - throneroom
                    Console.WriteLine("is the ThroneRoom.");
                    if (Kings_Token == true)//if player accepts quest
                    {
                        Console.Write("To the ");
                        PrintSomethingGreen("SOUTH ");//option- clearing
                        Console.WriteLine("Village outskirts");
                    }
                    if (Kings_quest == true)// if player refuses quest
                    {
                        Console.Write("To the ");
                        PrintSomethingGreen("SOUTH ");//option - clearing
                        Console.WriteLine("Village outskirts");
                    }
                    Print("Or you can ");
                    PrintSomethingGreen("SEARCH ");//option search case
                    PrintL("the area");
                    break;
                case 2:
                    Print("The ");
                    PrintSomethingGreen("KING ");//option - king case
                    Print("sits on his throne in front of you.\nThe ");
                    PrintSomethingGreen("SQUIRE ");//option - squire case
                    Console.Write("fidgets nerviously\nOr");
                    PrintSomethingGreen(" LEAVE");//option - leave case
                    PrintL(" the room?");
                    break;
                case 4:
                    if (Kings_Token == true)// if quest accepted
                    {
                        PrintL("The remaining bodies are resting around the site");
                        Print("To the");
                        PrintSomethingGreen(" NORTH");//option - town square
                        PrintL(" is the Castle");
                        Print("Further ");
                        PrintSomethingGreen("SOUTH");//option - cave entrance
                        PrintL(" is the cave from earlier");
                        PrintSomethingGreen("SEARCH");//option - search case
                        PrintL("the remaining bodies resting around the site");


                    }
                    if (Kings_quest == true)// if quest denied
                    {
                        PrintL("There are bodies littered everywhere");
                        PrintL("A dragon attack on the knights happened here");
                        PrintSomethingGreen("SEARCH ");//option
                        Print("the area");
                        PrintL("of remaining bodies resting around the site");
                        Print("To the");
                        PrintSomethingGreen(" NORTH");//option
                        PrintL(" is the Castle");
                        Print("Further ");
                        PrintSomethingGreen("SOUTH");//option
                        PrintL(" is a cave");
                    }
                    break;
                case 5:
                    Print("To the ");
                    PrintSomethingGreen("NORTH");//option - clearing
                    PrintL(" smoke rises slowly from the clearing");
                    Print("To the");
                    PrintSomethingGreen(" SOUTH ");//option- lake
                    Print("Lies the entrance to a cave\n");

                    Print("You See the ");
                    PrintSomethingGreen("SMITH ");//option- smith
                    PrintL("Standing near the entrance");
                    break;
                case 6:
                    PrintL("A giant chasm is in the middle of the cave");
                    PrintL("A lake fills most of it with a path leading along the side");
                    Print("To the ");
                    PrintSomethingGreen("EAST ");// option - dragons overlook
                    PrintL("is an uphill slope");
                    Print("To the ");
                    PrintSomethingGreen("WEST ");// option Alchemist
                    PrintL("List a Cave entrance with light Pouring out");
                    Print("To the ");
                    PrintSomethingGreen("NORTH ");// option -Cave entrance
                    PrintL("Lies the cave entrance");
                    Print("To the ");
                    PrintSomethingGreen("SOUTH ");// option - dragons den
                    PrintL("lies another Cave with growling sounds coming from it");
                    Print("Across the Lake is a ");
                    PrintSomethingGreen("SHIP");//option Ship
                    PrintL(" half sunk into the water");
                    PrintSomethingGreen("SEARCH"); // option search case
                    PrintL(" The area");
                    break;
                case 7:
                    if (Dead == false)// if alchemist is alive
                    {
                        PrintL("You enter the room");
                        PrintL("Vials Are lying everywhere");
                        Print("A ");
                        PrintSomethingGreen("MAN ");// option - man case
                        PrintL("Stands in facing away near a table");
                        Print("In the corner of the room lies the ");
                        PrintSomethingGreen("MIXER\n");// option mixer case(minigame)
                        PrintSomethingGreen("LEAVE");// option leaver case
                        PrintL(" the room?");
                    }
                    if (Dead == true)// if alchemist is killed
                    {
                        PrintL("Vials are lying everywhere");
                        Print("A man lies dead on the floor");
                        Print("In the corner of the room lies the");
                        PrintSomethingGreen("MIXER");// option mixer case(minigame)
                        PrintSomethingGreen("LEAVE");// option - leave case
                        PrintL(" the room?");
                    }
                    break;
                case 9:
                    PrintL("The uphill slope looks down on the Dragon's Den.");
                    PrintL("The Dragon is peacefully sleeping below.");


                    if (Dragon_Hole == true)// if player nocked scale off
                    {
                        PrintL("There is a hole in its scales where you knocked one off.");
                        PrintL("With the right weapon you have a good chance of killing it.");
                        if (Crossbow == true)// if cross bow is made
                        {
                            Print("Use the ");
                            PrintSomethingGreen("CROSSBOW?\n");// go to crossbow case
                        }

                    }
                    if (bomb == true)// if bomb is made
                    {
                        PrintL("The stalagmites above are incredibly sharp.");
                        PrintL("A well placed bomb cause them to fall on the Dragon!");
                        Print("Use the ");
                        PrintSomethingGreen("BOMB?/n");// bomb case
                    }
                    if (Dragon_FRight == true)//if dragon is injured
                    {
                        PrintL("The Dragons' front shoulder is dropping, it appears wounded.");
                    }
                    PrintSomethingGreen("LEAVE");//leave case
                    PrintL(" the area?");
                    break;
                case 10:
                    if (crossuse == true)// if crossbow was used
                    {
                        PrintL("The Dragon lies dead on the ground, bolt still sticking out.");
                        PrintL("Time to get to the King.");
                        Print("[Press Enter]");
                        Console.ReadLine();
                        Console.Clear();
                        //goto case "kingdom";// go to you kingdom case
                    }
                    if (Dragon_FRight == true)// if dragon is injured
                    {
                        PrintL("The Dragon is nursing its right side.");
                    }
                    if (bomb_use == false && crossuse == false && Dragon_FRight == false)// if nothing is wrong with dragon
                    {
                        PrintL("The Dragon is asleep");
                        PrintSomethingred("[Press Enter]");
                        Console.ReadLine();
                    }
                    if (bomb_use == true)//if you used a bomb
                    {
                        PrintL("The dragon is alive but in critical consition");
                        PrintSomethingred("[Press Enter]");
                        Console.ReadLine();
                    }

                    PrintSomethingGreen("Dragon ");// dragon case
                    Print(" or ");
                    PrintSomethingGreen("LEAVE");// leave case
                    PrintL(" the area?");
                    break;
            }
            startGame();
        }

        static string responseCommand()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" > ");//getting peoples answer and que to when they should type
            string input = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            input = input.ToLower();// switch will use this
            return input;
        }
            
        static void type(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
        }

        static int randomNumber(int start, int end)
        {
            Random rnd = new Random();
            int rand = randomNumber(start, end);
            return rand;
        }
        /// <summary>
        /// Puts bar to notify player
        /// </summary>
        static void Blue_choice()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" > ");


        }
        /// <summary>
        /// Write
        /// </summary>
        /// <param name="text"></param>
        static void Print(string text)
        {
            Console.Write(text);
        }
        /// <summary>
        /// wrtie line
        /// </summary>
        /// <param name="text"></param>
        static void PrintL(string text)
        {
            Console.WriteLine(text);
        }
        /// <summary>
        /// Prints line in green
        /// </summary>
        /// <param name="text"></param>
        static void PrintSomethingGreen(string text)
        {
            // change color to green
            Console.ForegroundColor = ConsoleColor.Green;
            // out put some text
            Console.Write(text);
            // Change back to grey
            Console.ForegroundColor = ConsoleColor.White;

        }
        /// <summary>
        /// prints red line 
        /// </summary>
        /// <param name="text"></param>
        static void PrintSomethingred(string text)
        {
            // change color to green
            Console.ForegroundColor = ConsoleColor.Red;
            // out put some text
            Console.WriteLine(text);
            // Change back to grey
            Console.ForegroundColor = ConsoleColor.White;

        }
        /// <summary>
        /// prints yello line(character)
        /// </summary>
        /// <param name="text"></param>
        static void PrintSomethingTalk(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// gets name says hi
        /// </summary>
        static void Intro()
        { //Intro to the games
            Console.ForegroundColor = ConsoleColor.White;// text color main white
            Console.WriteLine("Welcome Weary Traveler");
            Console.Write("Please Tell me Your Name:");
            //Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Cyan; // text name color blue
            string User_Name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Welcome ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(User_Name);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" to my adventure Game.");
            Get_Dagger = true;//starting armor and weapon
            GetLightArmor = true;
        }//intro end
        /// <summary>
        /// rules of the game
        /// </summary>
        static void Rules()
        { //Rules Start            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Rules are:");
            Console.Write("1. Start the Game with ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Look");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2. Directions will be in ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("GREEN");
            Console.ForegroundColor = ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.White;
            Console.Write("3. Type ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Exit ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("to leave Game");
            Console.Write("4. Type ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Equip ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("to see current armor and weapons");
            Console.Write("5. Type ");
            PrintSomethingGreen("RULES ");
            Console.ForegroundColor = ConsoleColor.Red;
            PrintL("to reread the rules");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[press Enter]");

            Console.ReadLine();
            Console.Clear();
        }
    }
}
