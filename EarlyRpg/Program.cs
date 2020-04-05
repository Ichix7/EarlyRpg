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
        static void Main(string[] args)

        {//Jesse Winden
            //SENG 100 thur 1-5
            //Midterm





            bool DoExit = false;
            bool Play_Again = false;
            do
            {
                Random rnd = new Random();
                #region bools
                bool GetSword = false;
                bool GetArmor = false;
                bool GetLightArmor = false;
                bool Getshield = false;
                bool Get_Dagger = false;
                bool Get_Great_Sword = false;
                bool GetDragonS = false;
                bool GetDragonShield = false;
                bool Black_Exit = false;
                bool King_Deny = false;
                bool Kings_Token = false;
                bool Player_rest = false;
                bool Dragon_Hole = false;
                bool scale_Drop = false;
                bool Dragon_FRight = false;
                bool Kings_Motion = false;
                bool Kings_quest = false;
                bool Notice = false;
                bool Free_Item = false;
                bool Friend = false;
                bool Again = false;
                bool Dead = false;
                bool vial = false;
                bool stick = false;
                bool Chunk_Wood = false;
                int string1 = 0;
                bool alch = false;
                bool Leather = false;
                bool cloth = false;
                bool herb = false;
                int herb_Count = 0;
                bool Crossbow = false;
                bool bomb = false;
                bool medKit = false;
                bool Alcohol = false;
                bool Powder = false;
                bool Poison = false;
                bool Poison_Vial = false;
                bool crossuse = false;
                bool bomb_use = false;
                bool poison_use = false;
                #endregion

                #region INT
                int Smith_Count = 0;
                int Out_Count = 0;
                int Gold = 0;
                int Player_Room = 1;
                int kings_count = 0;
                int Squire_count = 0;
                int Dragon_Scale = 0;
                bool Alerted = false;
                int Dragon_Count = 0;
                int Dragon_Health = 150;
                int Dragon_Swipe;
                int Drake_health = 50;
                int Drake_att;
                int Sword;
                int VialCT = 0;
                int powderCT = 0;
                int poisonCT = 0;
                int Player_Att = 1;
                int Player_Health = 100;
                #endregion



                Intro();// Name and welcome
                Rules();// rules of the game
                Get_Dagger = true;//starting armor and weapon
                GetLightArmor = true;
                PrintL("[Type Look]");
                do
                {

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(" > ");//getting peoples answer and que to when they should type
                    string input = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    input = input.ToLower();// switch will use this
                    switch (input)
                    {

                        case "rules":// displays rules again if typed
                            Rules();
                            break;
                        case "error":// for programmer to see whats working in the game
                            Console.WriteLine(Player_Room);
                            Console.WriteLine(Out_Count);
                            break;
                        case "look":// will tell the player where thay are at in the game and give them the que for next area
                            #region Town Square
                            Console.Clear();// clears previous text
                            if (Player_Room == 1)// only if player is in room 1
                            {
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
                            }


                            #endregion
                            #region ThroneRoom
                            if (Player_Room == 2)// only if player is in room 2
                            {
                                Print("The ");
                                PrintSomethingGreen("KING ");//option - king case
                                Print("sits on his throne in front of you.\nThe ");
                                PrintSomethingGreen("SQUIRE ");//option - squire case
                                Console.Write("fidgets nerviously\nOr");
                                PrintSomethingGreen(" LEAVE");//option - leave case
                                PrintL(" the room?");
                            }

                            #endregion
                            #region Clearing
                            if (Player_Room == 4)//only if player is in room 4
                            {
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
                            }

                            #endregion
                            #region Cave
                            if (Player_Room == 5)//only if player is in room 5
                            {
                                Print("To the ");
                                PrintSomethingGreen("NORTH");//option - clearing
                                PrintL(" smoke rises slowly from the clearing");
                                Print("To the");
                                PrintSomethingGreen(" SOUTH ");//option- lake
                                Print("Lies the entrance to a cave\n");

                                Print("You See the ");
                                PrintSomethingGreen("SMITH ");//option- smith
                                PrintL("Standing near the entrance");

                            }

                            #endregion
                            #region Lake
                            if (Player_Room == 6)// only if in room 6
                            {
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
                            }
                            #endregion
                            #region Alchemist
                            if (Player_Room == 7)
                            {
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

                            }
                            #endregion
                            #region lookout
                            if (Player_Room == 8)// only if player is in room 8
                            {
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
                            }
                            #endregion
                            #region Dragon Room
                            if (Player_Room == 10)
                            {
                                if (crossuse == true)// if crossbow was used
                                {
                                    PrintL("The Dragon lies dead on the ground, bolt still sticking out.");
                                    PrintL("Time to get to the King.");
                                    Print("[Press Enter]");
                                    Console.ReadLine();
                                    Console.Clear();
                                    goto case "kingdom";// go to you kingdom case
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

                            }
                            break;
                        #endregion
                        #region crossbow
                        case "crossbow":
                            if (Crossbow == true)// if cross bow has been made
                            {
                                PrintL("Try to hit it with the CrossBow?");
                                PrintSomethingGreen("Yes/No");// players option to shoot
                                string shoot;
                                do
                                {
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
                                        goto case "look";// going back to specific case
                                    }
                                    if (shoot == "no")// did not shoot
                                    {
                                        PrintL("The Dragon does not seem to be going anywhere.\n Might as well wait.");
                                        Player_Room = 8;// room is now 8
                                        PrintL("Heading back to Lookout.");
                                        Print("[Press Enter]");
                                        Console.ReadLine();
                                        Console.Clear();
                                        goto case "look";// reload case look

                                    }
                                    else
                                    {
                                        PrintSomethingred("What are you doing?");// if inputed wrong
                                    }

                                } while (shoot != "yes" || shoot != "no");    //while choice is not yes or no repeat                            
                            }
                            break;
                        #endregion
                        #region bomb
                        case "bomb":

                            PrintL("Throw Bomb?");
                            PrintSomethingGreen("Yes/No");//choice
                            string YES_NO;
                            do
                            {
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
                                    goto case "look";// reloading case look
                                }
                                if (YES_NO == "no")// choice no
                                {
                                    PrintL("The Dragon does not seem to be going anywhere.\n Might as well wait.");
                                    Player_Room = 8;// case lookout
                                    PrintL("Heading back to Lookout.");
                                    Print("[Press Enter]");
                                    Console.ReadLine();
                                    Console.Clear();
                                    goto case "look";// go to case look
                                }
                                else
                                {
                                    PrintSomethingred("What are you doing?");// if not yes or no
                                }
                            } while (YES_NO == "yes" || YES_NO == "no");// while it is not yes or no
                            break;
                        #endregion
                        case "ship":
                            #region Ship       
                            Player_Room = 9;
                            PrintL("You find a thin strip of land that leads to the ship");
                            PrintL("It does no look like anyone has been on the ship for a lomg time");
                            PrintSomethingGreen("SEARCH ");// search case
                            PrintL("the ship?");
                            PrintSomethingGreen("LEAVE ");// leave case
                            PrintL("the ship?");
                            break;
                        #endregion

                        #region equip
                        case "equip":
                            PrintL("Player Health: " + Player_Health);//showing players health
                            #region Weapons
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
                            #endregion
                            #region Usables
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
                            #endregion
                            PrintSomethingred("[Press Enter]");
                            Console.ReadLine();
                            goto case "look";//reload case look

                        #endregion

                        #region North
                        case "north":// notifies people what room they are leaving and sets new room
                            if (Player_Room == 4)
                            {
                                PrintL("Now leaving clearing");
                                PrintSomethingred("[Press Enter]");
                                Console.ReadLine();
                                Console.Clear();
                                Player_Room = 1;
                                goto case "look";
                            }
                            if (Player_Room == 5)
                            {
                                PrintL("Now leaving cave");
                                PrintSomethingred("[Press Enter]");
                                Console.ReadLine();
                                Console.Clear();
                                Player_Room = 4;
                                goto case "look";
                            }
                            if (Player_Room == 6)
                            {
                                PrintL("Now leaving lake");
                                PrintSomethingred("[Press Enter]");
                                Console.ReadLine();
                                Console.Clear();
                                Player_Room = 5;
                                goto case "look";
                            }
                            if (Player_Room == 1)
                            {
                                PrintSomethingred("Where are you going?");
                                PrintSomethingred("[Press Enter]");
                                Console.ReadLine();
                                Console.Clear();
                                Player_Room = 1;
                                goto case "look";
                            }

                            break;
                        #endregion
                        #region south
                        case "south":// notifies people what room they are leaving and sets new room
                            if (Player_Room == 5)
                            {
                                PrintL("Now Leaving Cave");
                                PrintSomethingred("[Press Enter]");
                                Console.ReadLine();
                                Console.Clear();
                                Player_Room = 6;
                                goto case "look";
                            }
                            if (Player_Room == 4)
                            {
                                PrintL("Now Leaving Clearing");
                                PrintSomethingred("[Press Enter]");
                                Console.ReadLine();
                                Console.Clear();
                                Player_Room = 5;
                                goto case "look";
                            }


                            if (Player_Room == 1)
                            {
                                if (Out_Count == 0)// if player has not talked to king no south is available
                                {
                                    PrintSomethingred("Where are you going!!??");
                                }
                                if (Out_Count == 2)// if king has been talked to and accepted 
                                {
                                    goto case "Outskirts";
                                }
                                if (Out_Count == 1)// if king denied
                                {
                                    PrintL("Now Leaving Town Square");
                                    PrintSomethingred("[Press Enter]");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Player_Room = 4;
                                    goto case "look";
                                }
                            }
                            if (Player_Room == 6)
                            {
                                PrintL("Now Leaving Lake");
                                PrintSomethingred("[Press Enter]");
                                Console.ReadLine();
                                Console.Clear();
                                Player_Room = 10;
                                goto case "look";
                            }


                            break;




                        #endregion
                        #region East
                        case "east":// notifies people what room they are leaving and sets new room
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
                                    goto case "look";
                                }
                                goto case "look";
                            }
                            if (Player_Room == 6)
                            {
                                Player_Room = 8;
                                PrintL("Leaving Lake");
                                PrintSomethingred("[Press Enter]");
                                Console.ReadLine();
                                Console.Clear();
                                goto case "look";
                            }
                            break;
                        #endregion
                        #region west
                        case "west":// notifies people what room they are leaving and sets new room
                            Console.Clear();
                            if (Player_Room == 1)
                            {
                                PrintL("Now leaving town square");
                                PrintSomethingred("[Press Enter]");
                                Console.ReadLine();
                                Console.Clear();
                                Player_Room = 3;
                                goto case "BlackSmith";

                            }
                            if (Player_Room == 6)
                            {
                                PrintL("Now leaving lake");
                                PrintSomethingred("[Press Enter]");
                                Console.ReadLine();
                                Console.Clear();
                                Player_Room = 7;
                                goto case "look";
                            }
                            break;
                        #endregion

                        #region king
                        case "king":
                            if (Player_Room != 2)// if not in room to there is no king
                            {
                                PrintL("What King are you talking about?");
                            }
                            if (Player_Room == 2)
                            {
                                if (Kings_Token == false && King_Deny == false)// if quest has not been denied or accepted
                                {
                                    kings_count = 1;
                                    Print("King: ");
                                    PrintSomethingTalk("Welcome, Noble Knight, I have a quest for you.");
                                    Print("King: ");
                                    PrintSomethingTalk("There is a Dragon in the vicinity.");
                                    Print("King: ");
                                    PrintSomethingTalk("I need a group of knights to fight it.");
                                    Print("King: ");
                                    PrintSomethingTalk("The choice, however, is yours.");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("Accept ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(" or ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("Deny: ");
                                    Console.ForegroundColor = ConsoleColor.Cyan;

                                    string Kings_Quest;
                                    do
                                    {
                                        Blue_choice();
                                        Kings_Quest = Console.ReadLine();
                                        Kings_Quest = Kings_Quest.ToLower();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        if (Kings_Quest == "accept")//accept sequence
                                        {
                                            Print("King: ");
                                            PrintSomethingTalk("Wise decision. Best of luck.");
                                            Kings_Token = true;
                                            PrintSomethingred("[Press Enter]");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Out_Count = 2;
                                            goto case "look";

                                        }
                                        if (Kings_Quest == "deny")//deny sequence
                                        {
                                            Print("King: ");
                                            PrintSomethingTalk("Ah. I respect that.");
                                            King_Deny = true;
                                            Kings_Motion = true;
                                            PrintSomethingred("[Press Enter]");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto case "look";
                                        }
                                        else
                                        {
                                            Console.WriteLine("Not a valid option");// if not accept or deny
                                            PrintSomethingred("[Press Enter]");
                                            Console.ReadLine();


                                        }
                                    } while (Kings_Quest != "accept" || Kings_Quest != "deny");// until answer is accept or deny
                                }
                                if (Player_rest == true)// if dragon has attacked
                                {
                                    Print("King: ");
                                    PrintSomethingTalk("Your cowardice has caused us to lose many men. Now, you must fight!");
                                    Kings_quest = true;
                                    Out_Count = 1;
                                }
                                if (Kings_Token == true && Player_rest == false)// if quest accepted
                                {
                                    Print("King: ");
                                    PrintSomethingTalk("Good luck on your journey.");
                                }
                                if (King_Deny == true && Player_rest == false)// if quest denied
                                {
                                    Print("King: ");
                                    PrintSomethingTalk("May God bless the knights.");
                                }
                            }
                            break;
                        #endregion
                        #region Squire
                        case "squire":
                            if (Player_Room != 2)// if not in throne room
                            {
                                PrintL("These are not the squires you are looking for.");
                            }
                            if (Player_Room == 2)
                            {
                                if (kings_count == 0)// if king has not been talked to
                                {
                                    Console.WriteLine("The squire is pacing nervously");
                                    Console.WriteLine("He finally turns to you.");
                                    Console.Write("Squire: ");
                                    PrintSomethingTalk("Quickly, to the King!");
                                }
                                if (kings_count == 1 && Kings_Token == true)//if king has been talked ot and accepted
                                {
                                    Console.Write("Squire: ");
                                    PrintSomethingTalk("Go to the Blacksmith for supplies, it's best to be prepared.");
                                    if (Squire_count == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("Recieved 2 Gold");
                                        Gold = Gold + 2;
                                        Squire_count++;
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    Console.Write("Squire: ");
                                    PrintSomethingTalk("I heard the Strangest rumor");
                                    PrintSomethingTalk("Something about ");
                                    PrintSomethingGreen("Poison Vial Weapon\n");// hint for minigame
                                    PrintSomethingTalk("Good Luck!");
                                    Print("[Press Enter]");
                                    Console.ReadLine();
                                    goto case "look";
                                }
                                if (kings_count == 1 && King_Deny == true && Player_rest == false)// quest denied
                                {
                                    Console.WriteLine("Squire: You Coward!");
                                }
                                if (kings_count == 1 && King_Deny == true && Player_rest == true)// quest denied and dragon att
                                {
                                    Console.WriteLine("Squire: This is all your fault!");
                                }
                            }
                            break;
                        #endregion
                        #region Dragon/Deny
                        case "Dragon_Attack":
                            if (Player_Room == 1 && King_Deny == true)//if quest denied and room 1
                            {
                                Kings_Motion = false;
                                Console.Clear();
                                Console.WriteLine("One week has passed since the knights have left to fight the dragon");
                                Console.WriteLine("A blood curling roar echoes across the skies");
                                Console.WriteLine("A bright flare erupts from outside the window");
                                Console.WriteLine("You rush out the door to see the Blacksmith on fire");
                                Console.WriteLine("A Dragon stands on its hind legs in the middle of the square");
                                Console.WriteLine("It turns its head at you and opens its mouth.");
                                PrintSomethingGreen("RUN");// choice
                                Console.Write(" Inside or ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Dodge");//choice

                                string Fight_D;

                                #region run
                                do
                                {
                                    Blue_choice();
                                    Fight_D = Console.ReadLine();
                                    Fight_D = Fight_D.ToLower();
                                    if (Fight_D == "run")
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("You jump inside the building as a gust of flames catches the door on fire");
                                        Console.Write("A ");
                                        PrintSomethingGreen("SWORD ");//choice
                                        Console.Write("Lies near the door and a ");
                                        PrintSomethingGreen("SPEAR ");//choice
                                        Console.WriteLine("sits just outside.");
                                        Blue_choice();
                                        string Sword_Spear;
                                        #region Sword
                                        do
                                        {
                                            Sword_Spear = Console.ReadLine();
                                            Sword_Spear = Sword_Spear.ToLower();
                                            if (Sword_Spear == "sword")
                                            {
                                                GetSword = true;//makes sword equip and the rest not
                                                Get_Dagger = false;
                                                Get_Great_Sword = false;
                                                GetDragonS = false;
                                                Sword = rnd.Next(3, 6);// random sword damage
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                PrintL("Recieved Sword");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine("You grab the hilt and charge out the door, The dragon is close by");
                                                Console.WriteLine("The dragon jumps up as you swing hitting its underside");
                                                Console.WriteLine("You barely draw blood");
                                                PrintL("The Dragon flies away to the south");
                                                Dragon_Health = Dragon_Health - (Player_Att + Sword);// damaging dragon
                                                PrintSomethingred("[Press Enter]");
                                                Console.ReadLine();
                                                Player_rest = true;// set up so player can go south
                                                goto case "Rest";
                                            }
                                            #endregion
                                            #region Spear
                                            if (Sword_Spear == "spear")
                                            {
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine("You  manage to grab the spear, peaking around the corner of the door frame");
                                                Console.WriteLine("The dragon has lost interest in you");
                                                PrintSomethingGreen("SNEAK");//choice
                                                Console.Write("Or ");
                                                PrintSomethingGreen("THROW");//choice
                                                Console.WriteLine(" the spear");
                                                Blue_choice();
                                                string Sneak_throw;
                                                #region Throw
                                                do
                                                {
                                                    Sneak_throw = Console.ReadLine();
                                                    Sneak_throw = Sneak_throw.ToLower();
                                                    if (Sneak_throw == "throw")
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                        Console.WriteLine("Wing, Leg, Belly, Head, chest");//choices
                                                        Blue_choice();
                                                        string Aim_First;
                                                        do
                                                        {
                                                            Console.ForegroundColor = ConsoleColor.White;
                                                            Aim_First = Console.ReadLine();
                                                            Aim_First = Aim_First.ToLower();
                                                            Console.ForegroundColor = ConsoleColor.White;
                                                            if (Aim_First == "wing")
                                                            {
                                                                Console.WriteLine("The spear goes clean through; doing little damage");
                                                                Dragon_Health = Dragon_Health - 10;//damaging dragon
                                                                Console.WriteLine("The Dragon does not look happy.");
                                                                Console.WriteLine("It launches up, flying West");
                                                                Console.WriteLine("Well, looks like there's a Dragon hunt now.");
                                                                Console.WriteLine("[Press Enter]");
                                                                Console.ReadLine();
                                                                Player_rest = true;//seting up south exit
                                                                goto case "Rest";//reload case rest


                                                            }
                                                            else if (Aim_First == "leg" || Aim_First == "chest")
                                                            {
                                                                Dragon_Swipe = rnd.Next(5, 11);// random drag att dmg
                                                                Console.WriteLine("The spear bounces off");
                                                                Console.WriteLine("The Dragon does not look happy");
                                                                Console.WriteLine("The Dragon wips around, nailing you in the chest with its tail");
                                                                Player_Health = Player_Health - Dragon_Swipe;// player injured
                                                                Console.WriteLine(Player_Health);
                                                                Console.WriteLine("It Launches up, flying West");
                                                                Console.WriteLine("Well, looks like there's a Dragon hunt now.");
                                                                Console.WriteLine("[Press Enter]");
                                                                Console.ReadLine();
                                                                Player_rest = true;//setting up south exit
                                                                goto case "Rest";// reloading case rest


                                                            }
                                                            else if (Aim_First == "belly")
                                                            {
                                                                Console.WriteLine("The spear makes a bloody wound");
                                                                Console.WriteLine("The Dragon staggers for a second.");
                                                                Dragon_Health = Dragon_Health - 15;//dragon injured
                                                                Console.WriteLine("It Launches up, flying West");
                                                                Console.WriteLine("Well, looks like there's a Dragon hunt now.");
                                                                Console.WriteLine("[Press Enter]");
                                                                Console.ReadLine();
                                                                Player_rest = true;// setting up south exit
                                                                goto case "Rest";//reloading case rest


                                                            }
                                                            else if (Aim_First == "head")
                                                            {
                                                                Console.WriteLine("The spear sticks into one of its horns.");
                                                                Console.WriteLine("The Dragon does not look happy.");
                                                                Console.WriteLine("It Launches up, flying West");
                                                                Console.WriteLine("Well, looks like there's a Dragon hunt now.");
                                                                Console.WriteLine("[Press Enter]");
                                                                Console.ReadLine();
                                                                Player_rest = true;//setting up south exit
                                                                goto case "Rest";// reloading case rest

                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Not an Answer");// if not any of the options try again
                                                                Print("[Press Enter]");
                                                                Console.ReadLine();
                                                            }

                                                        } while (Aim_First != "belly" || Aim_First != "head" || Aim_First != "chest" || Aim_First != "leg" || Aim_First != "wing");
                                                        break;
                                                    }//if throw
                                                    #endregion

                                                    else if (Sneak_throw == "sneak")
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("You get right next to the dragon before it notices.");
                                                        Console.WriteLine("You jab The spear behind its shoulder, going for the kill.");
                                                        Console.WriteLine("The scale is too strong; you do minor damage.");
                                                        Dragon_Health = Dragon_Health - 5;// damage drag
                                                        Console.WriteLine("The Dragon rears up And flies away to the West");
                                                        Console.WriteLine("The spear is still in hand, a scale on the tip");
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine("Recieved: dragon scale");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Dragon_Hole = true;// cross bow usage available
                                                        Console.WriteLine("Well, looks like there's a Dragon hunt now.");
                                                        PrintSomethingred("[Press Enter]");
                                                        Console.ReadLine();
                                                        Player_rest = true;//setting up south exit
                                                        goto case "Rest";// loading case rest

                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Not an Answer");// if not option try again
                                                        PrintSomethingred("[Press Enter]");
                                                        Console.ReadLine();
                                                    }

                                                } while (Sneak_throw != "throw" && Sneak_throw != "sneak");
                                                break;
                                            }// iff spear
                                            #endregion

                                        } while (Sword_Spear != "sword" && Sword_Spear != "spear");

                                        break;
                                    }// if run
                                    #endregion



                                    #region Dodge
                                    else if (Fight_D == "dodge")
                                    {
                                        int Chance;
                                        Chance = rnd.Next(1, 10);// chance to dodge successful
                                        if (Chance <= 8)
                                        {
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("You manage to roll under the Dragon as it breathes fire.");
                                            Console.WriteLine("You draw your dagger and pry it underneath one of its scales.");
                                            Console.WriteLine("You feel the dagger sink in and blood run down your hand.");
                                            Dragon_Health = Dragon_Health - 10;// drag injured
                                            Console.WriteLine("The Dragon roars, launches you back, and takes flight.");
                                            Console.WriteLine("You see the Dragon head West");
                                            Console.WriteLine("Well, looks like there's a Dragon hunt now.");
                                            PrintSomethingred("[Press Enter]");
                                            Console.ReadLine();
                                            Player_rest = true;// go to south available
                                            goto case "Rest";//load case rest
                                        }
                                        if (Chance >= 9)// dodge failed
                                        {
                                            Console.ForegroundColor = ConsoleColor.White;
                                            PrintL("You dodge the attack but get grazed by the flame.");
                                            Player_Health = Player_Health - 10;// player injured
                                            PrintL("You manage to get back in the building when you see the Dragon flying south");
                                            PrintSomethingred("[Press Enter]");
                                            Console.ReadLine();
                                            Player_rest = true;// go to south
                                            goto case "Rest";// load case rest
                                        }

                                    }
                                    #endregion
                                    else
                                    {
                                        Console.WriteLine("Not an Answer");//if not option try again
                                        PrintSomethingred("[Press Enter]");
                                        Console.ReadLine();
                                    }
                                } while (Fight_D != "run" && Fight_D != "dodge");

                            }
                            break;
                        #endregion
                        #region Blacksmith
                        case "BlackSmith":

                            if (Player_Room == 3)
                            {


                                if (Player_rest == false)
                                {
                                    do
                                    {

                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Welcome to the Blacksmith!");
                                        Console.WriteLine("What would you like to do?");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("SHOP ");//choice
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.Write("or ");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("LEAVE:");// choice
                                        Blue_choice();
                                        string SmithChoice = Console.ReadLine();
                                        SmithChoice = SmithChoice.ToLower();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        if (SmithChoice == "shop")
                                        {
                                            do
                                            {//options
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine("If You have the Gold        Gold:" + Gold);
                                                Console.WriteLine("Item                        Price");
                                                PrintSomethingGreen("Dagger");
                                                PrintL("                      1Gold");
                                                PrintSomethingGreen("sword");
                                                PrintL("                       2Gold");
                                                PrintSomethingGreen("GreatSword");
                                                PrintL("                  3Gold");
                                                PrintSomethingGreen("Shield");
                                                PrintL("                      1Gold");
                                                PrintSomethingGreen("LightArmor");
                                                PrintL("                  2Gold");
                                                PrintSomethingGreen("Armor");
                                                PrintL("                       3Gold");
                                                Console.Write("Your Selection?");
                                                Blue_choice();
                                                string Shop = Console.ReadLine();
                                                Shop = Shop.ToLower();
                                                Console.ForegroundColor = ConsoleColor.White;
                                                switch (Shop)
                                                {
                                                    case "No_Gold":// no gold available
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("You've not enough gold, you fool!");
                                                        Console.ForegroundColor = ConsoleColor.White;

                                                        break;
                                                    case "No_Weapon":// dont buy
                                                        PrintSomethingred("No weapon was bought");
                                                        break;
                                                    case "No_Armor":// dont buy
                                                        PrintSomethingred("No armor was bought");
                                                        break;
                                                    #region Dagger
                                                    case "dagger":
                                                        if (Get_Dagger == true)// alread have
                                                        {
                                                            PrintSomethingred("You already have that item!");
                                                            break;
                                                        }
                                                        if (GetSword == true || Get_Great_Sword == true || GetDragonS == true)// if stronger sword
                                                        {
                                                            PrintSomethingred("Current weapon is stronger");
                                                            PrintL("Buy anyway?");
                                                            PrintSomethingGreen("Yes/No");

                                                            string Dagger;
                                                            do
                                                            {
                                                                Blue_choice();
                                                                Dagger = Console.ReadLine();
                                                                Dagger = Dagger.ToLower();
                                                                Console.ForegroundColor = ConsoleColor.White;
                                                                if (Dagger == "yes")// weapon bought
                                                                {
                                                                    if (Gold >= 1)
                                                                    {
                                                                        Get_Dagger = true;
                                                                        GetSword = false;
                                                                        Get_Great_Sword = false;
                                                                        GetDragonS = false;

                                                                        Gold = Gold - 1;
                                                                        Console.WriteLine("You have recieved a Dagger");
                                                                        break;
                                                                    }
                                                                    if (Gold == 0)//no buy
                                                                    {
                                                                        goto case "No_Gold";
                                                                    }
                                                                }

                                                                if (Dagger == "no")
                                                                {//dont want
                                                                    goto case "No_Weapon";
                                                                }
                                                                else
                                                                {
                                                                    PrintSomethingred("Not an option");//wasnt an option
                                                                    PrintSomethingred("[Press Enter]");
                                                                    Console.ReadLine();
                                                                    Console.Clear();
                                                                }
                                                            } while (Dagger == "yes" || Dagger == "no");// Repeat as nessessary
                                                            break;
                                                        }
                                                        if (GetSword == false || Get_Great_Sword == false || GetDragonS == false)
                                                        {
                                                            if (Gold >= 1)
                                                            {
                                                                Get_Dagger = true;
                                                                GetSword = false;
                                                                Get_Great_Sword = false;
                                                                GetDragonS = false;

                                                                Gold = Gold - 1;
                                                                Console.WriteLine("You have recieved a Dagger");
                                                            }
                                                            else
                                                            {
                                                                goto case "No_Gold";
                                                            }
                                                        }



                                                        break;
                                                    #endregion
                                                    #region Sword
                                                    case "sword":// already have
                                                        if (GetSword == true)
                                                        {
                                                            PrintSomethingred("You already have that item!");
                                                            break;
                                                        }
                                                        if (Get_Great_Sword == true || GetDragonS == true)//stronger weapons
                                                        {
                                                            PrintSomethingred("Current Weapon is Stronger");
                                                            PrintL("Buy Anyways?");
                                                            PrintSomethingGreen("Yes/No");
                                                            Blue_choice();
                                                            string SWORD = Console.ReadLine();
                                                            SWORD = SWORD.ToLower();
                                                            do
                                                            {
                                                                if (SWORD == "yes")// bought anyways
                                                                {
                                                                    if (Gold >= 2)
                                                                    {
                                                                        GetSword = true;
                                                                        Get_Dagger = false;
                                                                        Gold = Gold - 2;
                                                                        Console.WriteLine("You have recieved a Sword");
                                                                        break;
                                                                    }
                                                                    else//no buy
                                                                    {
                                                                        goto case "No_Gold";
                                                                    }
                                                                }
                                                                if (SWORD == "no")//no buy
                                                                {
                                                                    goto case "No_Weapon";
                                                                }
                                                                else
                                                                {
                                                                    PrintSomethingred("Not An Option");// not an option provided
                                                                    PrintSomethingred("[Press Enter]");
                                                                    Console.ReadLine();
                                                                    Console.Clear();
                                                                }
                                                            } while (SWORD == "yes" || SWORD == "no");
                                                        }
                                                        if (Get_Great_Sword != true && GetDragonS != true)// recieved sword
                                                        {
                                                            if (Gold >= 2)
                                                            {
                                                                GetSword = true;
                                                                Get_Dagger = false;
                                                                Gold = Gold - 2;
                                                                Console.WriteLine("You have recieved a Sword");
                                                            }
                                                            else//no buy
                                                            {
                                                                goto case "No_Gold";
                                                            }
                                                        }

                                                        break;
                                                    #endregion
                                                    #region GreatSword
                                                    case "greatsword":
                                                        if (Get_Great_Sword == true)//already have
                                                        {
                                                            PrintSomethingred("You already have that item!");
                                                            break;
                                                        }
                                                        if (GetDragonS == true)// stronger weapon
                                                        {
                                                            PrintSomethingred("Current Weapon is Stronger");
                                                            PrintL("Buy Anyways?");
                                                            PrintSomethingGreen("Yes/No");
                                                            Blue_choice();
                                                            string GSWORD = Console.ReadLine();
                                                            GSWORD = GSWORD.ToLower();
                                                            do
                                                            {
                                                                if (Gold >= 3)
                                                                {
                                                                    PrintSomethingred("Can't Equip Shield With this!");// cant have shield
                                                                    PrintL("Is this Okay?");
                                                                    PrintSomethingGreen("Yes/no");
                                                                    Blue_choice();
                                                                    string Yesno = Console.ReadLine();
                                                                    Console.ForegroundColor = ConsoleColor.White;
                                                                    do
                                                                    {
                                                                        if (Yesno == "yes")// bought anyways
                                                                        {
                                                                            Get_Great_Sword = true;
                                                                            GetDragonS = false;
                                                                            Get_Dagger = false;
                                                                            GetSword = false;
                                                                            Getshield = false;
                                                                            GetDragonShield = false;
                                                                            Gold = Gold - 3;
                                                                            Console.WriteLine("You have recieved a Great_Sword");
                                                                            break;
                                                                        }
                                                                        if (Yesno == "no")//no buy
                                                                        {
                                                                            PrintL("No Sword Was added");
                                                                            PrintSomethingred("[Press Enter]");
                                                                            Console.ReadLine();
                                                                            break;
                                                                        }
                                                                        else
                                                                        {
                                                                            PrintSomethingred("Not An Option");
                                                                            PrintSomethingred("[Press Enter]");
                                                                            Console.ReadLine();
                                                                            Console.Clear();
                                                                        }
                                                                    } while (Yesno == "yes" || Yesno == "no");
                                                                }
                                                                else
                                                                {
                                                                    goto case "No_Gold";

                                                                }
                                                            } while (GSWORD == "yes" || GSWORD == "no");
                                                        }
                                                        if (GetDragonS == false)// stronger weapon
                                                        {
                                                            if (Gold >= 3)
                                                            {
                                                                PrintSomethingred("Current Weapon is stronger!");
                                                                PrintL("Is this Okay?");
                                                                PrintSomethingGreen("Yes/no");
                                                                Blue_choice();
                                                                string Yesno = Console.ReadLine();
                                                                Console.ForegroundColor = ConsoleColor.White;
                                                                do
                                                                {
                                                                    if (Yesno == "yes")
                                                                    {
                                                                        Get_Great_Sword = true;
                                                                        GetDragonS = false;
                                                                        Get_Dagger = false;
                                                                        GetSword = false;
                                                                        Getshield = false;
                                                                        GetDragonShield = false;
                                                                        Gold = Gold - 3;
                                                                        Console.WriteLine("You have recieved a Great_Sword");
                                                                        break;
                                                                    }
                                                                    if (Yesno == "no")
                                                                    {
                                                                        PrintL("No Sword Was added");
                                                                        PrintSomethingred("[Press Enter]");
                                                                        Console.ReadLine();
                                                                        break;
                                                                    }

                                                                    else
                                                                    {
                                                                        PrintSomethingred("Not An Option");
                                                                        PrintSomethingred("[Press Enter]");
                                                                        Console.ReadLine();
                                                                        Console.Clear();
                                                                    }
                                                                } while (Yesno == "yes" || Yesno == "no");
                                                            }
                                                            else
                                                            {
                                                                goto case "No_Gold";
                                                            }
                                                        }

                                                        break;
                                                    #endregion
                                                    #region Shield
                                                    case "shield":
                                                        if (Getshield == true)//already have
                                                        {
                                                            PrintSomethingred("You already have that item!");
                                                            break;
                                                        }
                                                        if (Get_Great_Sword == true)// no strong sword with shield
                                                        {
                                                            PrintSomethingred("Cannot use Greatsword with shield");
                                                            PrintL("Buy Anyways?");
                                                            PrintSomethingGreen("Yes/No");
                                                            Blue_choice();
                                                            string SHIELD = Console.ReadLine();
                                                            SHIELD = SHIELD.ToLower();
                                                            do
                                                            {
                                                                if (SHIELD == "yes")
                                                                {
                                                                    if (Gold >= 1)
                                                                    {
                                                                        Getshield = true;
                                                                        Get_Dagger = true;
                                                                        Get_Great_Sword = false;
                                                                        Gold = Gold - 1;
                                                                        Console.WriteLine("You have recieved a Shield");
                                                                        Console.WriteLine("You recieved a dagger out of courtesy");
                                                                    }
                                                                    else
                                                                    {
                                                                        goto case "No_Gold";
                                                                    }
                                                                }
                                                                if (SHIELD == "no")
                                                                {
                                                                    goto case "No_Armor";
                                                                }

                                                                else
                                                                {
                                                                    PrintL("Not An Option");
                                                                    PrintSomethingred("[Press Enter]");
                                                                    Console.ReadLine();
                                                                    Console.Clear();
                                                                }
                                                            } while (SHIELD == "yes" || SHIELD == "no");
                                                        }
                                                        if (Get_Great_Sword == false)// recieved shield
                                                        {
                                                            if (Gold >= 1)
                                                            {
                                                                Getshield = true;

                                                                Gold = Gold - 1;
                                                                Console.WriteLine("You have recieved a Shield");
                                                            }
                                                            else
                                                            {
                                                                goto case "No_Gold";
                                                            }
                                                        }

                                                        break;
                                                    #endregion
                                                    #region LArmor
                                                    case "lightarmor":
                                                        if (GetLightArmor == true)// already have
                                                        {
                                                            PrintSomethingred("You already have that item!");
                                                            break;
                                                        }
                                                        if (GetArmor == true)
                                                        {
                                                            PrintSomethingred("Current Armor is Stronger");// stronger armor
                                                            PrintL("Buy Anyways?");
                                                            PrintSomethingGreen("Yes/No");
                                                            Blue_choice();
                                                            string ARMOR = Console.ReadLine();
                                                            ARMOR = ARMOR.ToLower();
                                                            do
                                                            {
                                                                if (ARMOR == "yes")//bought
                                                                {
                                                                    if (Gold >= 2)
                                                                    {
                                                                        GetLightArmor = true;
                                                                        GetArmor = false;
                                                                        Gold = Gold - 2;
                                                                        Console.WriteLine("You have recieved Light Armor");
                                                                    }
                                                                    else
                                                                    {
                                                                        goto case "No_Gold";
                                                                    }
                                                                }
                                                                if (ARMOR == "no")//no buy
                                                                {
                                                                    goto case "No_Armor";
                                                                }
                                                                else
                                                                {
                                                                    PrintSomethingred("Not An Option");
                                                                    PrintSomethingred("[Press Enter]");
                                                                    Console.ReadLine();
                                                                    Console.Clear();
                                                                }
                                                            } while (ARMOR == "yes" || ARMOR == "no");
                                                        }
                                                        break;
                                                    #endregion
                                                    #region Armor
                                                    case "armor":
                                                        if (GetArmor == true)// already have
                                                        {
                                                            PrintSomethingred("You already have that item!");
                                                            break;
                                                        }
                                                        if (Gold >= 3)//buy
                                                        {
                                                            GetArmor = true;
                                                            GetLightArmor = false;
                                                            Gold = Gold - 3;
                                                            Console.WriteLine("You have recieved Heavy Armor");
                                                        }
                                                        else
                                                        {
                                                            goto case "No_Gold";
                                                        }
                                                        break;
                                                        #endregion
                                                }
                                                PrintL("Buy more?");//again?
                                                PrintSomethingGreen("Yes/No");
                                                Blue_choice();
                                                string PAgain = Console.ReadLine();
                                                Console.ForegroundColor = ConsoleColor.White;
                                                PAgain = PAgain.ToLower();
                                                do
                                                {
                                                    if (PAgain == "yes")
                                                    {
                                                        PrintL("Feel free to shop.");
                                                        break;
                                                    }
                                                    if (PAgain == "no")
                                                    {
                                                        Again = true;

                                                        break;
                                                    }
                                                    else
                                                    {
                                                        PrintSomethingred("Yes or No please");
                                                        PrintSomethingred("[Press Enter]");
                                                        Console.ReadLine();
                                                        Console.Clear();
                                                    }
                                                } while (PAgain == "yes" || PAgain == "no");
                                                Console.WriteLine("[Press Enter]");
                                                Console.ReadLine();
                                                Console.Clear();

                                            } while (Again == false);

                                        }
                                        if (SmithChoice == "leave" && Player_rest == false)//if leave and quest accepted
                                        {
                                            Player_Room = 1;//leaves blacksmith
                                            Black_Exit = true;
                                            Console.Clear();
                                            PrintL("Now leaving BlackSmith");
                                            PrintL("[Press Enter]");
                                            Console.ReadLine();
                                            Console.Clear();


                                        }
                                        /* else
                                         {
                                             PrintSomethingred("Not An Option");
                                             PrintSomethingred("[Press Enter]");
                                             Console.ReadLine();
                                             Console.Clear();
                                         }*/


                                    } while (Black_Exit == false);//Blacksmith end   
                                    Black_Exit = false;
                                    goto case "look";//load case look

                                }// Blacksmiht shop or no
                            }

                            if (Player_Room == 3)
                            {
                                if (Player_rest == true && Free_Item != true)//if king deny and item not recieved
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("The BlackSmith has burned to the ground");
                                    Console.Write("The");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(" SMITH ");//option
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("is standing on the side of the building");

                                    Blue_choice();
                                    string Smith_Talk = Console.ReadLine();
                                    Smith_Talk = Smith_Talk.ToLower();
                                    if (Smith_Talk == "smith")
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Print("Smith: ");
                                        PrintSomethingTalk("Screw this, I'm going to become a farmer.");
                                        if (Getshield == false && GetDragonShield == false)//if not shield, free shield
                                        {
                                            Print("Smith: ");
                                            PrintSomethingTalk("Here take this. Figures, only damn thing that survived was wood!");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine("Recieved shield");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Getshield = true;
                                        }
                                        Free_Item = true;// wont give 2
                                        Player_Room = 1;
                                    }
                                }
                                if (Player_rest == true && Free_Item == true)// if nothing left to do
                                {
                                    PrintL("There is nothing but burnt remains here.");
                                    PrintL("Heading back to the Square");
                                    Print("[Press Enter]");
                                    Console.ReadLine();
                                    Player_Room = 1;
                                    goto case "look";
                                }
                            }


                            break;
                        #endregion
                        #region Rest
                        case "Rest":// king deny end here
                            Console.Clear();
                            Console.WriteLine("The town takes a while to get back on its feet.");
                            Console.WriteLine("When things settle down, you get a message from the King to come immediately.");
                            PrintSomethingred("[Press Enter]");
                            Console.ReadLine();
                            goto case "look";
                        #endregion

                        #region Entrance
                        case "Entrance":// king accept end here
                            Console.Clear();
                            Player_Room = 5;
                            PrintL("You wake up in a daze.");
                            PrintSomethingred("[Press Enter]");
                            Console.ReadLine();
                            goto case "look";

                        #endregion
                        #region Smith
                        case "smith":
                            if (Player_rest == true)
                            {// king deny here
                                Print("Smith: ");
                                PrintSomethingTalk("I couldn't be a Farmer, too boring.");
                            }
                            if (Kings_Token == true)// king accept here
                            {
                                Print("Smith: ");
                                PrintSomethingTalk("Here on buisness");
                            }
                            Print("Smith: ");
                            PrintSomethingTalk("If you need something made, let me know.");
                            if (Dragon_Scale == 0)
                            {
                                Print("Smith: ");
                                PrintSomethingTalk("You do not have the materials needed sadly");
                            }
                            if (Dragon_Scale > 0)// if scale makes strong weapon
                            {
                                Print("Smith: ");
                                PrintSomethingTalk("Is that a Dragon Scale?!");
                                Print("Smith: ");
                                PrintSomethingTalk("Let me make you something.");
                                if (Getshield == true)
                                {
                                    Print("Smith: ");
                                    PrintSomethingTalk("I can make you a crazy");
                                    PrintSomethingGreen("SHIELD\n");//choice
                                }
                                if (GetSword == true)
                                {
                                    Print("Smith: ");
                                    PrintSomethingTalk("I can make you a crazy");
                                    PrintSomethingGreen("SWORD\n");//choice
                                }
                                string Dragon = Console.ReadLine();
                                Dragon = Dragon.ToLower();
                                do
                                {
                                    if (Dragon == "sword")// ultimate sword
                                    {
                                        Print("Smith: ");
                                        PrintSomethingTalk("I have created the ultimate Sword!");

                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        PrintL("Recieved DragonSword!");
                                        GetDragonS = true;// make one true rest not
                                        Get_Dagger = false;
                                        GetSword = false;
                                        Get_Great_Sword = false;
                                        Console.ForegroundColor = ConsoleColor.White;
                                        if (GetDragonShield == false && Getshield == false)// free shield if not equipt
                                        {
                                            Print("Smith: ");
                                            PrintSomethingTalk("Here is a shield to complete it.");
                                            GetDragonShield = true;
                                        }
                                        PrintL("[Press Enter]");
                                        Console.ReadLine();
                                        goto case "look";
                                    }
                                    if (Dragon == "shield")// ultimate shield
                                    {
                                        Print("Smith: ");
                                        PrintSomethingTalk("I have created the ultimate Shield!(It's immune to fire)");
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        PrintL("Recieved DragonShield!");
                                        GetDragonShield = true;
                                        Getshield = false;

                                        Console.ForegroundColor = ConsoleColor.White;
                                        PrintL("[Press Enter]");
                                        Console.ReadLine();
                                        goto case "look"; ;
                                    }
                                    else
                                    {
                                        PrintSomethingred("Not an option");
                                        Print("[Press Enter]");
                                        Console.ReadLine();
                                    }
                                } while (Dragon != "shield" || Dragon != "sword");
                            }
                            Print("Smith: ");
                            PrintSomethingTalk("I heard the Strangest rumor");
                            Print("Smith: ");
                            PrintSomethingTalk("Something about ");
                            PrintSomethingGreen("Poison Vial Weapon\n");
                            PrintSomethingred("[Press Enter]");
                            Console.ReadLine();
                            goto case "look";

                        #endregion
                        #region Outskirts
                        case "Outskirts":
                            if (Out_Count == 2)
                            {
                                Out_Count = 1;
                                Player_Room = 4;
                                if (Kings_Token == true)//quest accepted
                                {
                                    Console.Clear();
                                    PrintL("The group of knights leave the Square, heading to the Dragons Den.");
                                    PrintL("You stop at a small clearing just outside of the mountian to rest.");
                                    PrintL("The night is getting late. A roar echoes through the skies.");
                                    PrintL("A Dragon lands in the camp, chomping down on the closest knight.");
                                    PrintL("Its tail whips around, nailing many knights to the ground.");
                                    Print("It's your choice: ");
                                    PrintSomethingGreen("CHARGE");//choice
                                    Print(" or assemble a ");
                                    PrintSomethingGreen("TEAM");//choice

                                    String Clearing_1;
                                    do
                                    {
                                        Blue_choice();
                                        Clearing_1 = Console.ReadLine();
                                        Clearing_1 = Clearing_1.ToLower();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        if (Clearing_1 == "charge")
                                        {
                                            Console.Clear();
                                            PrintL("You recklessly charge at the Dragon.");
                                            PrintL("The Dragon spots your charge.");
                                            PrintL("You see the Dragon's tail coming in fast.");
                                            PrintSomethingGreen("DUCK");//choice
                                            if (Getshield == true)
                                            {
                                                Print(" Or ");
                                                Print("Put up your ");
                                                PrintSomethingGreen("SHIELD?");//choice
                                            }
                                            string Clearing_2;
                                            do
                                            {
                                                Blue_choice();
                                                Clearing_2 = Console.ReadLine();
                                                Clearing_2 = Clearing_2.ToLower();
                                                Console.ForegroundColor = ConsoleColor.White;
                                                if (Clearing_2 == "duck")
                                                {
                                                    int Chance;
                                                    Chance = rnd.Next(1, 10);
                                                    if (Chance <= 8)//dodge success
                                                    {
                                                        Console.Clear();
                                                        PrintL("The tail rushes past your head, hitting the knight behind you.");
                                                        PrintL("The Dragons back is to you.");
                                                        PrintSomethingGreen("STAB");//choice
                                                        Print(" for its belly");
                                                        if (GetSword == true)
                                                        {
                                                            Print(" Or ");
                                                            PrintSomethingGreen("ATTACK");//choice
                                                            PrintL(" with your sword");
                                                        }
                                                        string Clearing_3;
                                                        do
                                                        {

                                                            Blue_choice();
                                                            Clearing_3 = Console.ReadLine();
                                                            Clearing_3 = Clearing_3.ToLower();
                                                            Console.ForegroundColor = ConsoleColor.White;
                                                            if (Clearing_3 == "stab")
                                                            {
                                                                Console.Clear();
                                                                PrintL("You are temporarily under the Dragon.");
                                                                PrintL("You stab near the crease of its front right leg.");
                                                                Dragon_Health = Dragon_Health - 15;//drag injured
                                                                Dragon_FRight = true;// injured, attack decrease
                                                                PrintL("Blood drains onto your hand, it appears to be a serious wound.");
                                                                PrintL("The Dragon turns on you, nailing you with its head.");
                                                                PrintL("The hit knocks you off the nearby cliff\nYou to roll to the bottom and pass out.");
                                                                PrintL("[Press Enter]");
                                                                Console.ReadLine();
                                                                goto case "Entrance";

                                                            }
                                                            if (Clearing_3 == "attack")
                                                            {
                                                                Console.Clear();
                                                                PrintL("You release a battle cry as you shove the Sword underneath a scale.");
                                                                PrintL("The attack wasn't fatal, but did major damage.");
                                                                Dragon_Health = Dragon_Health - 20;//drag injured
                                                                Dragon_Hole = true;// crossbow use available
                                                                PrintL("You watch something fall off of the Dragon.");
                                                                PrintL("The Dragon bucks up and spreads its wings, nailling you in the chest.");
                                                                PrintL("The hit knocks you off the nearby cliff\nYou to roll to the bottom and pass out.");
                                                                PrintL("[Press Enter]");
                                                                Console.ReadLine();
                                                                goto case "Entrance";
                                                            }
                                                            else
                                                            {
                                                                PrintL("Not a choice");
                                                                Print("[Press Enter]");
                                                                Console.ReadLine();
                                                            }
                                                        } while (Clearing_3 != "stab" || Clearing_3 != "attack");
                                                    }
                                                    if (Chance >= 9)// failed dodge
                                                    {
                                                        PrintL("The tail nails you in the chest");
                                                        PrintL("The hit knocks you off the nearby cliff\nYou to roll to the bottom and pass out.");
                                                        Player_Health = Player_Health - 10;//player injured
                                                        PrintL("[Press Enter]");
                                                        Console.ReadLine();
                                                        goto case "Entrance";
                                                    }

                                                }//if duck

                                                if (Clearing_2 == "shield")
                                                {
                                                    Console.Clear();
                                                    PrintL("You raise your shield at the last second.");
                                                    PrintL("The tail feels like a battering ram as it hits\n Your shield instantly shatters.");
                                                    Player_Health = Player_Health - 10;// player injured
                                                    Getshield = false;// no more shield
                                                    PrintL("The hit knocks you off the nearby cliff, causing you to roll to the bottom.");
                                                    PrintL("Well, that didn't work.");
                                                    PrintL("As you try to get up, you pass out.");
                                                    PrintL("[Press Enter]");
                                                    Console.ReadLine();
                                                    goto case "Entrance";

                                                }//shield
                                                else
                                                {
                                                    PrintL("Not an attack option.");
                                                    Print("[Press Enter]");
                                                    Console.ReadLine();

                                                }

                                            } while (Clearing_2 != "duck" || Clearing_2 != "shield");

                                        }// charge
                                        if (Clearing_1 == "team")
                                        {
                                            Console.Clear();
                                            PrintL("You gather the remaining knights and grab spears.");
                                            PrintSomethingGreen("CHARGE, SURROUND ");//choice
                                            Print("the Dragon, or ");
                                            PrintSomethingGreen("THROW ");//choice
                                            Print("the spears at the Dragon?");
                                            string Clearing_4;

                                            do
                                            {
                                                Blue_choice();
                                                Clearing_4 = Console.ReadLine();
                                                Clearing_4 = Clearing_4.ToLower();
                                                Console.ForegroundColor = ConsoleColor.White;

                                                if (Clearing_4 == "charge")
                                                {
                                                    Console.Clear();
                                                    PrintL("The Dragon turns at the group and unleashs a blast of flames.");
                                                    PrintL("You manage to dodge. As you get up, its tail nails you in the chest.");
                                                    Player_Health = Player_Health - 10;// plyer injured
                                                    PrintL("The hit knocks you off the nearby cliff, causing you to roll to the bottom.");
                                                    PrintL("Well, that didn't work.");
                                                    PrintL("As you try to get up, you pass out.");
                                                    PrintL("[Press Enter]");
                                                    Console.ReadLine();
                                                    goto case "Entrance";

                                                }
                                                if (Clearing_4 == "surround")
                                                {
                                                    Console.Clear();
                                                    PrintL("The group manages to surround the dragon.");
                                                    PrintL("The group does some damage by hitting its weak point.");
                                                    PrintL("Finally, one of them hit home.");
                                                    PrintL("It sinks deep into its front right leg.");
                                                    Dragon_Health = Dragon_Health - 20;// dragon injured
                                                    Dragon_FRight = true;// dragon injured, att decrease
                                                    PrintL("It roars, going on its back legs.");
                                                    PrintL("The Dragon hits you with a wing as it squirms.");
                                                    PrintL("Caught by suprise, you losing balance and fall over the side of the cliff.");
                                                    PrintL("You to roll to the bottom, and pass out.");
                                                    PrintL("[Press Enter]");
                                                    Console.ReadLine();
                                                    goto case "Entrance";
                                                }
                                                if (Clearing_4 == "throw")
                                                {
                                                    Console.Clear();
                                                    PrintL("Everyone hurls their spear at the Dragon.");
                                                    PrintL("Some of them pierce the Dragons wings, doing minor damage.");
                                                    Dragon_Health = Dragon_Health - 10;//drag injured
                                                    PrintL("One spear pierces into a scale, causing it to break off.");
                                                    scale_Drop = true;// dragon scale found later
                                                    Dragon_Hole = true;// cross bow use available
                                                    PrintL("The rest bounce off harmlessly.");
                                                    PrintL("Temporarily weaponless, the Dragon charges at the group.");
                                                    PrintL("The Dragon turns on you, nailing you with its head.");
                                                    Player_Health = Player_Health - 5;// player injured
                                                    PrintL("The hit knocks you off the nearby cliff\nYou to roll to the bottom, and pass out.");
                                                    PrintL("[Press Enter]");
                                                    Console.ReadLine();
                                                    goto case "Entrance";

                                                }
                                                else
                                                {
                                                    PrintSomethingred("Not an option");
                                                    Print("[Press Enter]");
                                                    Console.ReadLine();
                                                }

                                            } while (Clearing_4 != "charge" || Clearing_4 != "surround" || Clearing_4 != "throw");
                                        }
                                        else
                                        {
                                            PrintL("Not an option of attack");
                                            Print("[Press Enter]");
                                            Console.ReadLine();
                                        }
                                    } while (Clearing_1 != "charge" || Clearing_1 != "team");



                                }
                            }

                            break;
                        #endregion
                        #region Search
                        case "search":
                            if (Player_Room == 1)// find item if requirment is fullfilled
                            {
                                PrintL("Something is etched into the fountain");
                                PrintSomethingGreen("Herb Cloth Alcohol\n");// minigame
                                PrintL("[Press Enter]");
                                Console.ReadLine();
                                goto case "look";

                            }
                            if (Player_Room == 4)// find item if requirment is fullfilled
                            {
                                Print("A man has a note that says:");
                                PrintSomethingGreen("String Wood Stick\n");// minigame
                                Console.ForegroundColor = ConsoleColor.Cyan;

                                if (Gold <= 1 || GetSword == false || Getshield == false || scale_Drop == true || Leather == false)
                                {
                                    if (scale_Drop == true)// scale from earlier
                                    {
                                        PrintL("Recieved Dragon Scale");
                                        Dragon_Scale++;
                                        scale_Drop = false;
                                    }
                                    if (Gold <= 2)
                                    {
                                        PrintL("You found a few gold.");
                                        Gold = Gold + 1;

                                    }
                                    if (GetSword == false)// found sword
                                    {
                                        if (Get_Great_Sword == true || GetDragonS == true)
                                        {
                                            break;
                                        }
                                        if (Get_Great_Sword == false || GetDragonS == false)
                                        {
                                            PrintL("You manage to find a sword still intact.");
                                            GetSword = true;
                                            Get_Dagger = false;
                                        }

                                    }
                                    if (Getshield == false)
                                    {
                                        PrintL("You find a shield only slightly dented.");
                                        Getshield = true;
                                    }
                                    if (Leather == false)
                                    {
                                        PrintL("You find Leather");
                                        Leather = true;
                                    }
                                    if (string1 <= 2)
                                    {
                                        PrintL("You find String");
                                        string1++;
                                    }
                                }

                                else
                                {
                                    PrintL("Some ashes, some toothpicks, nothing useful.");
                                    PrintL("[Press Enter]");
                                    Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    goto case "look";
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                                PrintL("[Press Enter]");
                                Console.ReadLine();
                                goto case "look";
                            }

                            if (Player_Room == 6)// find item if requirment is fullfilled
                            {
                                PrintL("A strange herb is growing in the cave.");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                if (herb == false && herb_Count == 0)
                                {
                                    PrintL("Aquired herb");
                                    herb = true;
                                    herb_Count = 1;
                                }
                            }
                            if (Player_Room == 9)// find item if requirment is fullfilled
                            {
                                if (Dragon_Count >= 1)// drake killed
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    if (cloth == false)
                                    {
                                        PrintL("You have found some old cloth");
                                        cloth = true;
                                    }
                                    if (Alcohol == false)
                                    {
                                        PrintL("You Found an Old Rum Bottle(alcohol)");
                                        Alcohol = true;
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Print("[Press Enter]");
                                    Console.ReadLine();
                                    Console.Clear();
                                    goto case "ship";
                                }
                                if (Dragon_Count == 0)// drake ahead of you
                                {
                                    Console.Clear();
                                    PrintL("You hear scratching on wood ahead of you!");
                                    PrintL("A dragonling is walking around the deck.");
                                    Print("[Press Enter]");
                                    Console.ReadLine();
                                    Console.Clear();
                                    goto case "dragonling";
                                }
                            }
                            break;
                        #endregion
                        case "Complete":
                            Console.Clear();
                            PrintL("The Dragon defeated, you cut its head off to bring back to the king");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            PrintL("Recieved Dragons Head");
                            PrintSomethingred("[Press Enter]");
                            Console.ReadLine();
                            goto case "kingdom";

                        case "kingdom":
                            Console.Clear();
                            Print("King: ");
                            PrintSomethingTalk("You have defeated the Dragon!");
                            Print("King: ");
                            PrintSomethingTalk("You have saved our kingdom.");
                            Print("King: ");
                            PrintSomethingTalk("you will live like a king for the rest of your life!");
                            PrintSomethingred("[Press Enter]");
                            Console.ReadLine();
                            Console.Clear();
                            type("Your Win!!!");
                            Console.Clear();
                            Console.ReadLine();
                            goto case "again";

                        #region Dragon
                        case "dragon":
                            if (Player_Room == 10)
                            {
                                if (bomb_use == false && crossuse == false && Dragon_FRight == false)// if uninjured you wake it up
                                {
                                    PrintL("The Dragon wakes up");
                                    PrintSomethingred("[Press Enter]");
                                    Console.ReadLine();
                                }
                                do

                                {
                                    Console.Clear();
                                    PrintL("Player Health:" + Player_Health);// displays healths
                                    PrintL("Dragons Health:" + Dragon_Health);
                                    PrintSomethingGreen("ATTACK    USE");
                                    string ATT_USE;
                                    do
                                    {
                                        Blue_choice();
                                        ATT_USE = Console.ReadLine();
                                        ATT_USE = ATT_USE.ToLower();
                                        Console.ForegroundColor = ConsoleColor.White;

                                        if (ATT_USE == "attack")
                                        {
                                            #region Dagger                                                                             
                                            if (Get_Dagger == true)
                                            {
                                                int Dagger;
                                                Dagger = rnd.Next(1, 3);// random dmg

                                                int ATTSEQ;
                                                ATTSEQ = rnd.Next(1, 2);// random wording
                                                if (ATTSEQ == 1)
                                                {
                                                    PrintL("You swing your Dagger");
                                                }
                                                if (ATTSEQ == 2)
                                                {
                                                    PrintL("You lunge at the Dragon");
                                                }
                                                int Chance;
                                                Chance = rnd.Next(1, 10);// chance to miss
                                                if (Chance <= 8)
                                                {
                                                    Dragon_Health = Dragon_Health - Dagger;
                                                    Print("Dealt: " + Dagger + " Dmg\n");
                                                }
                                                else
                                                {
                                                    PrintL("You Missed\n");
                                                }

                                            }
                                            #endregion
                                            #region Sword                                                                             
                                            if (GetSword == true)
                                            {
                                                Sword = rnd.Next(3, 6);// random att

                                                int ATTSEQ;
                                                ATTSEQ = rnd.Next(1, 2);// rendom words
                                                if (ATTSEQ == 1)
                                                {
                                                    PrintL("You swing your Sword");
                                                }
                                                if (ATTSEQ == 2)
                                                {
                                                    PrintL("You lunge at the Dragon");
                                                }
                                                int Chance;
                                                Chance = rnd.Next(1, 10);// misses att
                                                if (Chance <= 8)
                                                {
                                                    Dragon_Health = Dragon_Health - Sword;
                                                    Print("Dealt: " + Sword + " Dmg\n");
                                                }
                                                else
                                                {
                                                    PrintL("You Missed\n");
                                                }

                                            }
                                            #endregion
                                            #region GRTSWORD                                                                            
                                            if (Get_Great_Sword == true)
                                            {
                                                int GRTsword;
                                                GRTsword = rnd.Next(6, 9);// swrd smg

                                                int ATTSEQ;
                                                ATTSEQ = rnd.Next(1, 2);// wording
                                                if (ATTSEQ == 1)
                                                {
                                                    PrintL("You swing your Great Sword");
                                                }
                                                if (ATTSEQ == 2)
                                                {
                                                    PrintL("You lunge at the Dragon");
                                                }
                                                int Chance;
                                                Chance = rnd.Next(1, 10);// chance to miss
                                                if (Chance <= 8)
                                                {
                                                    Dragon_Health = Dragon_Health - GRTsword;
                                                    Print("Dealt: " + GRTsword + " Dmg\n");
                                                }
                                                else
                                                {
                                                    PrintL("You Missed\n");
                                                }

                                            }
                                            #endregion
                                            #region DRGSWORD                                                                             
                                            if (GetDragonS == true)
                                            {
                                                int DRGSWRD;
                                                DRGSWRD = rnd.Next(6, 9);// random dmg

                                                int ATTSEQ;
                                                ATTSEQ = rnd.Next(1, 2);// random wording
                                                if (ATTSEQ == 1)
                                                {
                                                    PrintL("You swing your Dragon Sword");
                                                }
                                                if (ATTSEQ == 2)
                                                {
                                                    PrintL("You lunge at the Dragon");
                                                }
                                                int Chance;
                                                Chance = rnd.Next(1, 10);// random misses
                                                if (Chance <= 8)
                                                {
                                                    Dragon_Health = Dragon_Health - DRGSWRD;
                                                    Print("Dealt: " + DRGSWRD + " Dmg\n");
                                                }
                                                else
                                                {
                                                    PrintL("You Missed\n");
                                                }

                                            }
                                            #endregion
                                            if (poison_use == true)// used poison so its in affect
                                            {
                                                int Pois;
                                                Pois = rnd.Next(5, 10);
                                                Drake_health = Drake_health - Pois;
                                                PrintL("Poison: " + Pois + " Dmg");
                                            }
                                            break;
                                        }

                                        if (ATT_USE == "use")// use an item
                                        {
                                            #region Use
                                            PrintL("Use?");
                                            if (medKit == true)//medkit if avaialble
                                            {
                                                PrintSomethingGreen("MEDKIT?\n");
                                            }
                                            if (Poison_Vial == true)//poison
                                            {
                                                PrintSomethingGreen("POISON?");
                                                poison_use = true;
                                            }
                                            if (bomb == true)//bomb
                                            {
                                                PrintSomethingGreen("BOMB?\n");
                                            }
                                            PrintSomethingGreen("BACK?");
                                            string USE;
                                            do
                                            {
                                                Blue_choice();
                                                USE = Console.ReadLine();
                                                USE = USE.ToLower();
                                                Console.ForegroundColor = ConsoleColor.White;
                                                if (USE == "medkit")
                                                {
                                                    Player_Health = Player_Health + 50;// heals 50 health wont go ovr max
                                                    if (Player_Health > 100)
                                                    {
                                                        Player_Health = 100;
                                                        PrintL("Fully Healed");
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        PrintL("Healed 50 points");
                                                    }
                                                    medKit = false;
                                                }
                                                if (USE == "poison" && Poison_Vial == true)// triggers poison att
                                                {
                                                    PrintL("Enemy has been poisoned!");
                                                    poison_use = true;
                                                    break;
                                                }
                                                if (USE == "bomb" && bomb == true)// damages enemy
                                                {
                                                    PrintL("You throw the bomb at the Drake");
                                                    Drake_health = Drake_health - 20;
                                                    PrintL("Bomb Dmg: 20");
                                                    bomb = false;
                                                    break;
                                                }
                                                if (USE == "back")
                                                {

                                                    break;
                                                }
                                                else
                                                {
                                                    PrintSomethingred("Not an option");
                                                }
                                            } while (USE != "medkit" || USE != "poison" || USE != "back");
                                            #endregion
                                            break;
                                        }
                                        else
                                        {
                                            PrintSomethingred("That is not an option!");
                                        }

                                    } while (ATT_USE != "attack" || ATT_USE != "use");
                                    #region Dragon ATT      //calculates Player health - (dragon att - player defence )
                                    Dragon_Swipe = rnd.Next(10, 15);//random dmgs for attack
                                    int Dragon_Breath = rnd.Next(10, 20);
                                    int tail = rnd.Next(10, 15);
                                    int Choice;
                                    Choice = rnd.Next(1, 100);// decides what attack
                                    #region Swipe
                                    if (Choice < 30)//swipe att
                                    {
                                        PrintL("The Dragon swipes at you");

                                        int Dodge;
                                        Dodge = rnd.Next(1, 10);//chance to miss
                                        if (Dodge <= 8)
                                        {//deducting armor
                                            int Attck;
                                            if (GetLightArmor == true)
                                            {
                                                int Light_Arm;
                                                Light_Arm = rnd.Next(1, 3);//random defence stat
                                                if (Getshield == true)
                                                {
                                                    int Shield;
                                                    Shield = rnd.Next(1, 3);// random defence stat
                                                    if (Dragon_FRight == true)// dragon injured?
                                                    {
                                                        Attck = ((Dragon_Swipe / 2) - Shield - Light_Arm);
                                                    }
                                                    else { Attck = (Dragon_Swipe - Shield - Light_Arm); }
                                                    if (Attck <= 0)
                                                    {
                                                        PrintL("No damage recieved");// dragon hit do damage?
                                                    }
                                                    if (Attck > 0)
                                                    {
                                                        Player_Health = Player_Health - (Attck);
                                                        PrintL("Damage recieved: " + Attck);
                                                    }
                                                }
                                                if (GetDragonShield == true)
                                                {

                                                    int Shield;
                                                    Shield = rnd.Next(2, 4);// random shield
                                                    if (Dragon_FRight == true)
                                                    {
                                                        Attck = ((Dragon_Swipe / 2) - Shield - Light_Arm);
                                                    }
                                                    else { Attck = (Dragon_Swipe - Shield - Light_Arm); }
                                                    if (Attck <= 0)
                                                    {
                                                        PrintL("No damage recieved");
                                                    }
                                                    if (Attck > 0)
                                                    {
                                                        Player_Health = Player_Health - (Attck);
                                                        PrintL("Damage recieved: " + Attck);
                                                    }
                                                }
                                                if (GetDragonShield == false && Getshield == false)
                                                {
                                                    if (Dragon_FRight == true)
                                                    {
                                                        Attck = ((Dragon_Swipe / 2) - Light_Arm);
                                                    }
                                                    else { Attck = (Dragon_Swipe - Light_Arm); }

                                                    Player_Health = Player_Health - (Attck);
                                                    PrintL("Damage recieved: " + Attck);
                                                }
                                            }
                                            if (GetArmor == true)
                                            {
                                                int HVYARM;
                                                HVYARM = rnd.Next(2, 5);
                                                if (Getshield == true)
                                                {
                                                    int Shield;
                                                    Shield = rnd.Next(1, 3);
                                                    if (Dragon_FRight == true)
                                                    {
                                                        Attck = ((Dragon_Swipe / 2) - Shield - HVYARM);
                                                    }
                                                    else { Attck = (Dragon_Swipe - Shield - HVYARM); }
                                                    if (Attck <= 0)
                                                    {
                                                        PrintL("No damage recieved");
                                                    }
                                                    if (Attck > 0)
                                                    {
                                                        Player_Health = Player_Health - (Attck);
                                                        PrintL("Damage recieved: " + Attck);
                                                    }
                                                }
                                                if (GetDragonShield == true)
                                                {

                                                    int Shield;
                                                    Shield = rnd.Next(2, 4);
                                                    if (Dragon_FRight == true)
                                                    {
                                                        Attck = ((Dragon_Swipe / 2) - Shield - HVYARM);
                                                    }
                                                    else { Attck = (Dragon_Swipe - Shield - HVYARM); }
                                                    Player_Health = Player_Health - (Attck);
                                                    if (Attck <= 0)
                                                    {
                                                        PrintL("No damage recieved");
                                                    }
                                                    if (Attck > 0)
                                                    {
                                                        Player_Health = Player_Health - (Attck);
                                                        PrintL("Damage recieved: " + Attck);
                                                    }
                                                }
                                                if (GetDragonShield == false && Getshield == false)
                                                {
                                                    Attck = (Dragon_Swipe - HVYARM);
                                                    Player_Health = Player_Health - (Attck);
                                                    PrintL("Damage recieved: " + Attck);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            PrintL("The Dragons attack missed");
                                        }
                                    }
                                    #endregion
                                    #region Tail
                                    if (Choice >= 30 && Choice < 80)
                                    {
                                        PrintL("The Dragon swipes its tail at you");

                                        int Dodge;
                                        Dodge = rnd.Next(1, 10);
                                        if (Dodge <= 8)
                                        {
                                            int Attck;
                                            if (GetLightArmor == true)
                                            {
                                                int Light_Arm;
                                                Light_Arm = rnd.Next(1, 3);
                                                if (Getshield == true)
                                                {
                                                    int Shield;
                                                    Shield = rnd.Next(1, 3);
                                                    if (Dragon_FRight == true)
                                                    {
                                                        Attck = ((tail / 2) - Shield - Light_Arm);
                                                    }
                                                    else { Attck = (tail - Shield - Light_Arm); }
                                                    if (Attck <= 0)
                                                    {
                                                        PrintL("No damage recieved");
                                                    }
                                                    if (Attck > 0)
                                                    {
                                                        Player_Health = Player_Health - (Attck);
                                                        PrintL("Damage recieved: " + Attck);
                                                    }
                                                }
                                                if (GetDragonShield == true)
                                                {

                                                    int Shield;
                                                    Shield = rnd.Next(2, 4);
                                                    if (Dragon_FRight == true)
                                                    {
                                                        Attck = ((tail / 2) - Shield - Light_Arm);
                                                    }
                                                    else { Attck = (tail - Shield - Light_Arm); }
                                                    Player_Health = Player_Health - (Attck);
                                                    PrintL("Damage recieved: " + Attck);
                                                }
                                                if (GetDragonShield == false && Getshield == false)
                                                {
                                                    Attck = (tail - Light_Arm);
                                                    Player_Health = Player_Health - (Attck);
                                                    PrintL("Damage recieved: " + Attck);
                                                }
                                            }
                                            if (GetArmor == true)
                                            {
                                                int HVYARM;
                                                HVYARM = rnd.Next(2, 5);
                                                if (Getshield == true)
                                                {
                                                    int Shield;
                                                    Shield = rnd.Next(1, 3);
                                                    if (Dragon_FRight == true)
                                                    {
                                                        Attck = ((tail / 2) - Shield - HVYARM);
                                                    }
                                                    else { Attck = (tail - Shield - HVYARM); }
                                                    if (Attck <= 0)
                                                    {
                                                        PrintL("No damage recieved");
                                                    }
                                                    if (Attck > 0)
                                                    {
                                                        Player_Health = Player_Health - (Attck);
                                                        PrintL("Damage recieved: " + Attck);
                                                    }
                                                }
                                                if (GetDragonShield == true)
                                                {

                                                    int Shield;
                                                    Shield = rnd.Next(2, 4);
                                                    if (Dragon_FRight == true)
                                                    {
                                                        Attck = ((tail / 2) - Shield - HVYARM);
                                                    }
                                                    else { Attck = (tail - Shield - HVYARM); }
                                                    Player_Health = Player_Health - (Attck);
                                                    if (Attck <= 0)
                                                    {
                                                        PrintL("No damage recieved");
                                                    }
                                                    if (Attck > 0)
                                                    {
                                                        Player_Health = Player_Health - (Attck);
                                                        PrintL("Damage recieved: " + Attck);
                                                    }
                                                }
                                                if (GetDragonShield == false && Getshield == false)
                                                {
                                                    Attck = (tail - HVYARM);
                                                    Player_Health = Player_Health - (Attck);
                                                    PrintL("Damage recieved: " + Attck);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            PrintL("The Dragons attack misses");
                                        }
                                    }
                                    #endregion
                                    #region Breath
                                    if (Choice >= 80)
                                    {
                                        PrintL("The Dragon breathes fire at you");

                                        int Dodge;
                                        Dodge = rnd.Next(1, 10);
                                        if (Dodge <= 8)
                                        {
                                            int Attck;
                                            if (GetLightArmor == true)
                                            {
                                                int Light_Arm;
                                                Light_Arm = rnd.Next(1, 3);
                                                if (Getshield == true)
                                                {
                                                    int Shield;
                                                    Shield = rnd.Next(1, 3);
                                                    Attck = (Dragon_Breath - Shield - Light_Arm);

                                                    if (Attck <= 0)
                                                    {
                                                        PrintL("No damage recieved");
                                                    }
                                                    if (Attck > 0)
                                                    {
                                                        Player_Health = Player_Health - (Attck);
                                                        PrintL("Damage recieved: " + Attck);
                                                    }
                                                }
                                                if (GetDragonShield == true)
                                                {

                                                    int Shield;
                                                    Shield = rnd.Next(2, 4);

                                                    PrintL("Dragon shield deflects all fire poured at you");
                                                }
                                                if (GetDragonShield == false && Getshield == false)
                                                {
                                                    Attck = (Dragon_Breath - Light_Arm);
                                                    Player_Health = Player_Health - (Attck);
                                                    PrintL("Damage recieved: " + Attck);
                                                }
                                            }
                                            if (GetArmor == true)
                                            {
                                                int HVYARM;
                                                HVYARM = rnd.Next(2, 5);
                                                if (Getshield == true)
                                                {
                                                    int Shield;
                                                    Shield = rnd.Next(1, 3);

                                                    Attck = (Dragon_Breath - Shield - HVYARM);
                                                    if (Attck <= 0)
                                                    {
                                                        PrintL("No damage recieved");
                                                    }
                                                    if (Attck > 0)
                                                    {
                                                        Player_Health = Player_Health - (Attck);
                                                        PrintL("Damage recieved: " + Attck);
                                                    }
                                                }
                                                if (GetDragonShield == true)
                                                {

                                                    int Shield;
                                                    Shield = rnd.Next(2, 4);

                                                    PrintL("No damage recieved, Dragon Shield deflects flame");

                                                }
                                                if (GetDragonShield == false && Getshield == false)
                                                {
                                                    Attck = (Dragon_Breath - HVYARM);
                                                    Player_Health = Player_Health - (Attck);
                                                    PrintL("Damage recieved: " + Attck);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            PrintL("The Dragons attack misses");
                                        }
                                    }
                                    #endregion


                                    #endregion
                                    PrintSomethingred("[Press Enter]");
                                    Console.ReadLine();
                                    if (Dragon_Health <= 0)// dragon has died
                                    {
                                        type("The Dragon is Dead");
                                        Dragon_Count++;// showing dead drake
                                        PrintSomethingred("[Press Enter]");
                                        Console.ReadLine();
                                        goto case "Complete";

                                    }
                                    if (Player_Health <= 0)// player has died
                                    {
                                        type("You Are Dead");
                                        PrintSomethingred("[Press Enter]");
                                        Console.ReadLine();
                                        goto case "again"; // play again case
                                    }
                                } while (Drake_health != 0 || Player_Health <= 0);

                            }

                            break;
                        #endregion
                        #region dragonling
                        case "dragonling":
                            PrintSomethingGreen("SNEAK");//choice
                            Print(" up on the baby Dragon or ");
                            PrintSomethingGreen("ATTACK.\n");//choice
                            PrintSomethingGreen("LEAVE");//choice
                            Print(" the ship.");
                            string Sneak_ATT;

                            do
                            {
                                Blue_choice();
                                Sneak_ATT = Console.ReadLine();
                                Sneak_ATT = Sneak_ATT.ToLower();
                                Console.ForegroundColor = ConsoleColor.White;
                                if (Sneak_ATT == "sneak")
                                {
                                    int Sneak;
                                    Sneak = rnd.Next(1, 20);//lucky sneak?
                                    if (Sneak <= 10)//instant kill
                                    {

                                        PrintL("you succesfully sneak up on the dragon.");
                                        PrintL("Before the dragon knows you're there you blade is in its heart.");
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        PrintL("Recieved Dragon Scale");
                                        Dragon_Scale++;
                                        Console.ForegroundColor = ConsoleColor.White;
                                        PrintSomethingred("[Press Enter]");
                                        Console.ReadLine(); Console.Clear();
                                        Dragon_Count++;
                                        goto case "ship";
                                    }
                                    if (Sneak > 10)// sneak failed
                                    {
                                        Drake_att = rnd.Next(1, 4);// random drake att dmg
                                        PrintL("The Dragon hears you coming and turns on you!");
                                        PrintL("Caught by suprise the Dragon scratches you down your leg.");
                                        Player_Health = Player_Health - (Drake_att * 2);// player injured
                                        PrintL("The Dragon now stand in front of you, time for a fight.");
                                        PrintSomethingred("[Press Enter]");
                                        Console.ReadLine();

                                        do

                                        {
                                            Console.Clear();
                                            PrintL("Player Health:" + Player_Health);//stats
                                            PrintL("Drakes Health:" + Drake_health);
                                            PrintSomethingGreen("ATTACK    USE");//choice
                                            string ATT_USE;
                                            do
                                            {
                                                Blue_choice();
                                                ATT_USE = Console.ReadLine();
                                                ATT_USE = ATT_USE.ToLower();
                                                Console.ForegroundColor = ConsoleColor.White;

                                                if (ATT_USE == "attack")// exact same as Dragons
                                                {
                                                    #region Dagger                                                                             
                                                    if (Get_Dagger == true)
                                                    {
                                                        int Dagger;
                                                        Dagger = rnd.Next(1, 3);

                                                        int ATTSEQ;
                                                        ATTSEQ = rnd.Next(1, 3);
                                                        if (ATTSEQ == 1)
                                                        {
                                                            PrintL("You swing your Dagger");
                                                        }
                                                        if (ATTSEQ == 2)
                                                        {
                                                            PrintL("You lunge at the Drake");
                                                        }
                                                        int Chance;
                                                        Chance = rnd.Next(1, 10);
                                                        if (Chance <= 8)
                                                        {
                                                            Drake_health = Drake_health - Dagger;
                                                            Print("Dealt: " + Dagger + " Dmg\n");
                                                        }
                                                        else
                                                        {
                                                            PrintL("You Missed\n");
                                                        }

                                                    }
                                                    #endregion
                                                    #region Sword                                                                             
                                                    if (GetSword == true)
                                                    {
                                                        Sword = rnd.Next(3, 6);

                                                        int ATTSEQ;
                                                        ATTSEQ = rnd.Next(1, 3);
                                                        if (ATTSEQ == 1)
                                                        {
                                                            PrintL("You swing your Sword");
                                                        }
                                                        if (ATTSEQ == 2)
                                                        {
                                                            PrintL("You lunge at the Drake");
                                                        }
                                                        int Chance;
                                                        Chance = rnd.Next(1, 10);
                                                        if (Chance <= 8)
                                                        {
                                                            Drake_health = Drake_health - Sword;
                                                            Print("Dealt: " + Sword + " Dmg\n");
                                                        }
                                                        else
                                                        {
                                                            PrintL("You Missed\n");
                                                        }

                                                    }
                                                    #endregion
                                                    #region GRTSWORD                                                                            
                                                    if (Get_Great_Sword == true)
                                                    {
                                                        int GRTsword;
                                                        GRTsword = rnd.Next(6, 9);

                                                        int ATTSEQ;
                                                        ATTSEQ = rnd.Next(1, 3);
                                                        if (ATTSEQ == 1)
                                                        {
                                                            PrintL("You swing your Great Sword");
                                                        }
                                                        if (ATTSEQ == 2)
                                                        {
                                                            PrintL("You lunge at the Drake");
                                                        }
                                                        int Chance;
                                                        Chance = rnd.Next(1, 10);
                                                        if (Chance <= 8)
                                                        {
                                                            Drake_health = Drake_health - GRTsword;
                                                            Print("Dealt: " + GRTsword + " Dmg\n");
                                                        }
                                                        else
                                                        {
                                                            PrintL("You Missed\n");
                                                        }

                                                    }
                                                    #endregion
                                                    #region DRGSWORD                                                                             
                                                    if (GetDragonS == true)
                                                    {
                                                        int DRGSWRD;
                                                        DRGSWRD = rnd.Next(6, 9);

                                                        int ATTSEQ;
                                                        ATTSEQ = rnd.Next(1, 3);
                                                        if (ATTSEQ == 1)
                                                        {
                                                            PrintL("You swing your Dragon Sword");
                                                        }
                                                        if (ATTSEQ == 2)
                                                        {
                                                            PrintL("You lunge at the Drake");
                                                        }
                                                        int Chance;
                                                        Chance = rnd.Next(1, 10);
                                                        if (Chance <= 8)
                                                        {
                                                            Drake_health = Drake_health - DRGSWRD;
                                                            Print("Dealt: " + DRGSWRD + " Dmg\n");
                                                        }
                                                        else
                                                        {
                                                            PrintL("You Missed\n");
                                                        }

                                                    }
                                                    #endregion
                                                    if (poison_use == true)
                                                    {
                                                        int Pois;
                                                        Pois = rnd.Next(5, 10);
                                                        Drake_health = Drake_health - Pois;
                                                        PrintL("Poison: " + Pois + " Dmg");
                                                    }
                                                    break;
                                                }

                                                if (ATT_USE == "use")// exact Same as Dragons
                                                {
                                                    #region Use
                                                    PrintL("Use?");
                                                    if (medKit == true)
                                                    {
                                                        PrintSomethingGreen("MEDKIT?\n");
                                                    }
                                                    if (Poison_Vial == true)
                                                    {
                                                        PrintSomethingGreen("POISON?\n");
                                                        poison_use = true;
                                                    }
                                                    if (bomb == true)
                                                    {
                                                        PrintSomethingGreen("BOMB?\n");
                                                    }
                                                    PrintSomethingGreen("BACK?");
                                                    string USE;
                                                    do
                                                    {
                                                        Blue_choice();
                                                        USE = Console.ReadLine();
                                                        USE = USE.ToLower();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        if (USE == "medkit")
                                                        {
                                                            Player_Health = Player_Health + 50;
                                                            if (Player_Health > 100)
                                                            {
                                                                Player_Health = 100;
                                                                PrintL("Fully Healed");
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                PrintL("Healed 50 points");
                                                            }
                                                            medKit = false;
                                                            break;
                                                        }
                                                        if (USE == "poison" && Poison_Vial == true)
                                                        {
                                                            PrintL("Enemy has been poisoned!");
                                                            poison_use = true;
                                                            break;
                                                        }
                                                        if (USE == "bomb" && bomb == true)
                                                        {
                                                            PrintL("You throw the bomb at the Drake");
                                                            Drake_health = Drake_health - 20;
                                                            PrintL("Bomb Dmg: 20");
                                                            bomb = false;
                                                            break;
                                                        }
                                                        if (USE == "back")
                                                        {
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            PrintSomethingred("Not an option");
                                                        }
                                                    } while (USE != "medkit" || USE != "poison" || USE != "back");
                                                    #endregion
                                                    break;
                                                }
                                                else
                                                {
                                                    PrintSomethingred("That is not an option!");
                                                }

                                            } while (ATT_USE != "attack" || ATT_USE != "use");
                                            #region Drake ATT     
                                            Drake_att = rnd.Next(3, 8);// random damage

                                            int Choice;
                                            Choice = rnd.Next(1, 3);// random att call
                                            if (Choice == 1)
                                            {
                                                PrintL("The Drake Lunges at you");
                                            }
                                            if (Choice == 2)
                                            {
                                                PrintL("The Drake swings its tail at you");
                                            }
                                            int Dodge;
                                            Dodge = rnd.Next(1, 10);// miss att?
                                            if (Dodge <= 8)
                                            {
                                                if (GetLightArmor == true)
                                                {
                                                    int Light_Arm;
                                                    Light_Arm = rnd.Next(1, 3);
                                                    if (Getshield == true)
                                                    {
                                                        int Shield;
                                                        Shield = rnd.Next(1, 3);
                                                        int Attck = (Drake_att - Shield - Light_Arm);
                                                        if (Attck <= 0)
                                                        {
                                                            PrintL("No damage recieved");
                                                        }
                                                        if (Attck > 0)
                                                        {
                                                            Player_Health = Player_Health - (Attck);
                                                            PrintL("Damage recieved: " + Attck);
                                                        }
                                                    }
                                                    if (GetDragonShield == true)
                                                    {

                                                        int Shield;
                                                        Shield = rnd.Next(2, 4);
                                                        int Attck = (Drake_att - Shield - Light_Arm);
                                                        Player_Health = Player_Health - (Attck);
                                                        PrintL("Damage recieved: " + Attck);
                                                    }
                                                    if (GetDragonShield == false && Getshield == false)
                                                    {
                                                        int Attck = (Drake_att - Light_Arm);
                                                        Player_Health = Player_Health - (Attck);
                                                        PrintL("Damage recieved: " + Attck);
                                                    }
                                                }
                                                if (GetArmor == true)
                                                {
                                                    int HVYARM;
                                                    HVYARM = rnd.Next(2, 5);
                                                    if (Getshield == true)
                                                    {
                                                        int Shield;
                                                        Shield = rnd.Next(1, 3);
                                                        int Attck = (Drake_att - Shield - HVYARM);
                                                        if (Attck <= 0)
                                                        {
                                                            PrintL("No damage recieved");
                                                        }
                                                        if (Attck > 0)
                                                        {
                                                            Player_Health = Player_Health - (Attck);
                                                            PrintL("Damage recieved: " + Attck);
                                                        }
                                                    }
                                                    if (GetDragonShield == true)
                                                    {

                                                        int Shield;
                                                        Shield = rnd.Next(2, 4);
                                                        int Attck = (Drake_att - Shield - HVYARM);
                                                        Player_Health = Player_Health - (Attck);
                                                        if (Attck <= 0)
                                                        {
                                                            PrintL("No damage recieved");
                                                        }
                                                        if (Attck > 0)
                                                        {
                                                            Player_Health = Player_Health - (Attck);
                                                            PrintL("Damage recieved: " + Attck);
                                                        }
                                                    }
                                                    if (GetDragonShield == false && Getshield == false)
                                                    {
                                                        int Attck = (Drake_att - HVYARM);
                                                        Player_Health = Player_Health - (Attck);
                                                        PrintL("Damage recieved: " + Attck);
                                                    }
                                                }
                                            }
                                            else
                                            {// att missed
                                                PrintL("The Drake barely missed\n");
                                            }

                                            #endregion
                                            PrintSomethingred("[Press Enter]");
                                            Console.ReadLine();

                                        } while (Drake_health >= 0 && Player_Health >= 0);
                                        if (Drake_health <= 0)
                                        {
                                            type("Drake is Dead");// drake is dead
                                            Dragon_Count++;
                                            Dragon_Scale++;
                                            poison_use = false;//need to reuse poison if wanted
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            PrintL("Recieved Dragon Scale");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            PrintSomethingred("[Press Enter]");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto case "ship";

                                        }
                                        if (Player_Health <= 0)// player has died
                                        {
                                            type("You Are Dead");
                                            PrintSomethingred("[Press Enter]");
                                            Console.ReadLine();
                                            goto case "again";
                                        }
                                    }

                                }
                                if (Sneak_ATT == "attack")// same as sneaks att seq
                                {

                                    do

                                    {
                                        Console.Clear();
                                        PrintL("Player Health:" + Player_Health);
                                        PrintL("Drakes Health:" + Drake_health);
                                        PrintSomethingGreen("ATTACK    USE");
                                        string ATT_USE;
                                        do
                                        {
                                            Blue_choice();
                                            ATT_USE = Console.ReadLine();
                                            ATT_USE = ATT_USE.ToLower();
                                            Console.ForegroundColor = ConsoleColor.White;

                                            if (ATT_USE == "attack")
                                            {
                                                #region Dagger                                                                             
                                                if (Get_Dagger == true)
                                                {
                                                    int Dagger;
                                                    Dagger = rnd.Next(1, 3);

                                                    int ATTSEQ;
                                                    ATTSEQ = rnd.Next(1, 3);
                                                    if (ATTSEQ == 1)
                                                    {
                                                        PrintL("You swing your Dagger");
                                                    }
                                                    if (ATTSEQ == 2)
                                                    {
                                                        PrintL("You lunge at the Drake");
                                                    }
                                                    int Chance;
                                                    Chance = rnd.Next(1, 10);
                                                    if (Chance <= 8)
                                                    {
                                                        Drake_health = Drake_health - Dagger;
                                                        Print("Dealt: " + Dagger + " Dmg\n");
                                                    }
                                                    else
                                                    {
                                                        PrintL("You Missed\n");
                                                    }

                                                }
                                                #endregion
                                                #region Sword                                                                             
                                                if (GetSword == true)
                                                {
                                                    Sword = rnd.Next(3, 6);

                                                    int ATTSEQ;
                                                    ATTSEQ = rnd.Next(1, 3);
                                                    if (ATTSEQ == 1)
                                                    {
                                                        PrintL("You swing your Sword");
                                                    }
                                                    if (ATTSEQ == 2)
                                                    {
                                                        PrintL("You lunge at the Drake");
                                                    }
                                                    int Chance;
                                                    Chance = rnd.Next(1, 10);
                                                    if (Chance <= 8)
                                                    {
                                                        Drake_health = Drake_health - Sword;
                                                        Print("Dealt: " + Sword + " Dmg\n");
                                                    }
                                                    else
                                                    {
                                                        PrintL("You Missed\n");
                                                    }

                                                }
                                                #endregion
                                                #region GRTSWORD                                                                            
                                                if (Get_Great_Sword == true)
                                                {
                                                    int GRTsword;
                                                    GRTsword = rnd.Next(6, 9);

                                                    int ATTSEQ;
                                                    ATTSEQ = rnd.Next(1, 3);
                                                    if (ATTSEQ == 1)
                                                    {
                                                        PrintL("You swing your Great Sword");
                                                    }
                                                    if (ATTSEQ == 2)
                                                    {
                                                        PrintL("You lunge at the Drake");
                                                    }
                                                    int Chance;
                                                    Chance = rnd.Next(1, 10);
                                                    if (Chance <= 8)
                                                    {
                                                        Drake_health = Drake_health - GRTsword;
                                                        Print("Dealt: " + GRTsword + " Dmg\n");
                                                    }
                                                    else
                                                    {
                                                        PrintL("You Missed\n");
                                                    }

                                                }
                                                #endregion
                                                #region DRGSWORD                                                                             
                                                if (GetDragonS == true)
                                                {
                                                    int DRGSWRD;
                                                    DRGSWRD = rnd.Next(6, 9);

                                                    int ATTSEQ;
                                                    ATTSEQ = rnd.Next(1, 3);
                                                    if (ATTSEQ == 1)
                                                    {
                                                        PrintL("You swing your Dragon Sword");
                                                    }
                                                    if (ATTSEQ == 2)
                                                    {
                                                        PrintL("You lunge at the Drake");
                                                    }
                                                    int Chance;
                                                    Chance = rnd.Next(1, 10);
                                                    if (Chance <= 8)
                                                    {
                                                        Drake_health = Drake_health - DRGSWRD;
                                                        Print("Dealt: " + DRGSWRD + " Dmg\n");
                                                    }
                                                    else
                                                    {
                                                        PrintL("You Missed\n");
                                                    }

                                                }
                                                #endregion
                                                if (poison_use == true)
                                                {
                                                    int Pois;
                                                    Pois = rnd.Next(5, 10);
                                                    Drake_health = Drake_health - Pois;
                                                    PrintL("Poison: " + Pois + " Dmg");
                                                }
                                                break;
                                            }

                                            if (ATT_USE == "use")
                                            {
                                                #region Use
                                                PrintL("Use?");
                                                if (medKit == true)
                                                {
                                                    PrintSomethingGreen("MEDKIT?\n");
                                                }
                                                if (Poison_Vial == true)
                                                {
                                                    PrintSomethingGreen("POISON?");
                                                }
                                                if (bomb == true)
                                                {
                                                    PrintSomethingGreen("BOMB?\n");
                                                }
                                                PrintSomethingGreen("BACK?");
                                                string USE;
                                                do
                                                {
                                                    Blue_choice();
                                                    USE = Console.ReadLine();
                                                    USE = USE.ToLower();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    if (USE == "medkit" && medKit == true)
                                                    {

                                                        Player_Health = Player_Health + 50;
                                                        if (Player_Health > 100)
                                                        {
                                                            Player_Health = 100;
                                                            PrintL("Fully Healed");
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            PrintL("Healed 50 points");
                                                        }
                                                        medKit = false;
                                                        break;
                                                    }
                                                    if (USE == "poison" && Poison_Vial == true)
                                                    {
                                                        PrintL("Enemy has been poisoned!");
                                                        poison_use = true;
                                                        break;
                                                    }
                                                    if (USE == "bomb" && bomb == true)
                                                    {
                                                        PrintL("You throw the bomb at the Drake");
                                                        Drake_health = Drake_health - 20;
                                                        PrintL("Bomb Dmg: 20");
                                                        bomb = false;
                                                        break;
                                                    }
                                                    if (USE == "back")
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        PrintSomethingred("Not an option");
                                                    }
                                                } while (USE != "medkit" || USE != "poison" || USE != "back");
                                                #endregion
                                                break;
                                            }
                                            else
                                            {
                                                PrintSomethingred("That is not an option!");
                                                PrintSomethingred("[Press Enter]");
                                                Console.ReadLine();

                                            }

                                        } while (ATT_USE != "attack" || ATT_USE != "use");
                                        #region Drake ATT     
                                        Drake_att = rnd.Next(3, 8);

                                        int Choice;
                                        Choice = rnd.Next(1, 2);
                                        if (Choice == 1)
                                        {
                                            PrintL("The Drake lunges at you");
                                        }
                                        if (Choice == 2)
                                        {
                                            PrintL("The Drake swings its tail at you");
                                        }
                                        int Dodge;
                                        Dodge = rnd.Next(1, 10);
                                        if (Dodge <= 8)
                                        {
                                            if (GetLightArmor == true)
                                            {
                                                int Light_Arm;
                                                Light_Arm = rnd.Next(1, 3);
                                                if (Getshield == true)
                                                {
                                                    int Shield;
                                                    Shield = rnd.Next(1, 3);
                                                    int Attck = (Drake_att - Shield - Light_Arm);
                                                    if (Attck <= 0)
                                                    {
                                                        PrintL("No damage recieved");
                                                    }
                                                    if (Attck > 0)
                                                    {
                                                        Player_Health = Player_Health - (Attck);
                                                        PrintL("Damage recieved: " + Attck);
                                                    }
                                                }
                                                if (GetDragonShield == true)
                                                {

                                                    int Shield;
                                                    Shield = rnd.Next(2, 4);
                                                    int Attck = (Drake_att - Shield - Light_Arm);
                                                    Player_Health = Player_Health - (Attck);
                                                    PrintL("Damage recieved: " + Attck);
                                                }
                                                if (GetDragonShield == false && Getshield == false)
                                                {
                                                    int Attck = (Drake_att - Light_Arm);
                                                    Player_Health = Player_Health - (Attck);
                                                    PrintL("Damage recieved: " + Attck);
                                                }
                                            }
                                            if (GetArmor == true)
                                            {
                                                int HVYARM;
                                                HVYARM = rnd.Next(2, 5);
                                                if (Getshield == true)
                                                {
                                                    int Shield;
                                                    Shield = rnd.Next(1, 3);
                                                    int Attck = (Drake_att - Shield - HVYARM);
                                                    if (Attck <= 0)
                                                    {
                                                        PrintL("No damage recieved");
                                                    }
                                                    if (Attck > 0)
                                                    {
                                                        Player_Health = Player_Health - (Attck);
                                                        PrintL("Damage recieved: " + Attck);
                                                    }
                                                }
                                                if (GetDragonShield == true)
                                                {

                                                    int Shield;
                                                    Shield = rnd.Next(2, 4);
                                                    int Attck = (Drake_att - Shield - HVYARM);
                                                    Player_Health = Player_Health - (Attck);
                                                    if (Attck <= 0)
                                                    {
                                                        PrintL("No damage recieved");
                                                    }
                                                    if (Attck > 0)
                                                    {
                                                        Player_Health = Player_Health - (Attck);
                                                        PrintL("Damage recieved: " + Attck);
                                                    }
                                                }
                                                if (GetDragonShield == false && Getshield == false)
                                                {
                                                    int Attck = (Drake_att - HVYARM);
                                                    Player_Health = Player_Health - (Attck);
                                                    PrintL("Damage recieved: " + Attck);
                                                }
                                            }

                                        }
                                        else
                                        {
                                            PrintL("\nThe Drake barely missed\n");
                                        }

                                        #endregion}
                                        PrintSomethingred("[Press Enter]");
                                        Console.ReadLine();

                                    } while (Drake_health >= 0 && Player_Health >= 0);
                                    if (Drake_health <= 0)
                                    {
                                        type("Drake is Dead");
                                        Dragon_Count++;
                                        Dragon_Scale++;
                                        poison_use = false;
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        PrintL("Recieved Dragon Scale");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Dragon_Scale++;
                                        PrintSomethingred("[Press Enter]");
                                        Console.ReadLine();
                                        Console.Clear();
                                        goto case "ship";

                                    }
                                    if (Player_Health <= 0)
                                    {
                                        type("You Are Dead");
                                        PrintSomethingred("[Press Enter]");
                                        Console.ReadLine();
                                        goto case "again";
                                    }
                                }
                                if (Sneak_ATT == "leave")
                                {
                                    Player_Room = 6;
                                    goto case "leave";
                                }
                                else
                                {
                                    PrintSomethingred("Not an option");
                                    PrintSomethingred("[Press Enter]");
                                    Console.ReadLine();
                                }
                            } while (Sneak_ATT != "sneak" || Sneak_ATT != "attack" || Sneak_ATT == "leave");

                            break;
                        #endregion

                        #region Man
                        case "man":
                            if (Alerted == true && Dead == false)// alive and alertd
                            {
                                Console.Clear();
                                Print("Merlin: ");
                                PrintSomethingTalk("Do you have a question?");
                                Print("Ask about ");
                                PrintSomethingGreen("VIALS");//choice
                                Print(" or ask about materials for ");
                                PrintSomethingGreen("MIXER? ");//choice
                                Print("What's your ");
                                PrintSomethingGreen("SECRET");//choice
                                PrintL("?");
                                Print("Or ");
                                PrintSomethingGreen("LEAVE");//choice
                                PrintL("?");

                                string Vial_LAb;
                                do
                                {

                                    Blue_choice();
                                    Vial_LAb = Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    if (Vial_LAb == "vials")
                                    {
                                        Print("Merlin: ");
                                        PrintSomethingTalk("The vials? Oh, yes, these.");
                                        Print("Merlin: ");
                                        PrintSomethingTalk("Here, you can have them.");
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        if (vial == false && VialCT == 0)//empty vial
                                        {
                                            VialCT = 1;
                                            vial = true;
                                            PrintL("Recieved vial");
                                        }
                                        if (Poison == false && poisonCT == 0)//poison
                                        {
                                            poisonCT = 1;
                                            Poison = true;
                                            PrintL("Recieved poison");
                                        }
                                        if (Powder == false && powderCT == 0)//gunpowder
                                        {
                                            powderCT = 1;
                                            Powder = true;
                                            PrintL("Recieved powder");
                                        }
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Print("Merlin: ");
                                        PrintSomethingTalk("Haven't found a way to use them yet.");
                                        Print("Merlin: ");
                                        PrintSomethingTalk("When one touches fire, it flares up(Powder).\nThe other can kill(Poison), not usable though. Crazy, right?");
                                        PrintSomethingred("[Press Enter]");
                                        Console.ReadLine();
                                        goto case "man";


                                    }
                                    if (Vial_LAb == "mixer")// learn about mini game
                                    {
                                        Print("Merlin: ");
                                        PrintSomethingTalk("The lab will mix 3 items of your choosing and make a single item.");
                                        Print("Merlin: ");
                                        PrintSomethingTalk("The combination has to be just right.");
                                        if (alch == false)
                                        {
                                            Print("Merlin: ");
                                            PrintSomethingTalk("Here are some items, for fun.");
                                            Console.ForegroundColor = ConsoleColor.Cyan;// free items!
                                            PrintL("Recieved Chunk of wood");
                                            Chunk_Wood = true;
                                            PrintL("Recieved Leather");
                                            Leather = true;
                                            PrintL("Recieved String");
                                            string1++;
                                            PrintL("Recieved Stick");
                                            stick = true;
                                            alch = true;
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        PrintSomethingred("[Press Enter]");
                                        Console.ReadLine();
                                        goto case "man";


                                    }
                                    if (Vial_LAb == "secret")
                                    {
                                        Print("Merlin: ");
                                        PrintSomethingTalk("I do know something crazy...");
                                        Print("Merlin: ");
                                        PrintSomethingTalk("Just three words:");
                                        PrintSomethingGreen("Leather String Powder");// minigame
                                        PrintSomethingred("[Press Enter]");
                                        Console.ReadLine();
                                        goto case "man";

                                    }
                                    if (Vial_LAb == "leave")
                                    {
                                        PrintL("You walk away from the alchemist");
                                        PrintSomethingred("[Press Enter]");
                                        Console.ReadLine();
                                        goto case "look";
                                    }
                                    else
                                    {
                                        PrintSomethingred("Not a valid option");
                                        PrintSomethingred("[Press Enter]");
                                        Console.ReadLine();
                                    }
                                } while (Vial_LAb != "vial" || Vial_LAb != "lab" || Vial_LAb != "secret" || Vial_LAb == "leave");
                            }
                            if (Dead == false && Alerted == false)
                            {

                                PrintL("He hasn't noticed you yet ");
                                PrintSomethingGreen("SNEAK ");//choice
                                Print("up on the man or ");
                                PrintSomethingGreen("ALERT ");//choice
                                PrintL("him of your presence");
                                string Sneak_Alert;
                                do
                                {
                                    Blue_choice();
                                    Sneak_Alert = Console.ReadLine();
                                    Sneak_Alert = Sneak_Alert.ToLower();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    if (Sneak_Alert == "sneak")
                                    {
                                        Console.Clear();
                                        PrintL("The man is mixing stuff from the two vials.");
                                        PrintL("The man puts a small flame to it, and it bursts into light.");
                                        PrintL("Another Vial near him is bubbling");
                                        Print("The man has still not noticed you, ");
                                        PrintSomethingGreen("KILL ");//choice
                                        Print("him or ");
                                        PrintSomethingGreen("TAP ");//choice
                                        PrintL("shoulder");
                                        string Kill_Tap;
                                        do
                                        {
                                            Blue_choice();
                                            Kill_Tap = Console.ReadLine();
                                            Kill_Tap = Kill_Tap.ToLower();
                                            Console.ForegroundColor = ConsoleColor.White;
                                            if (Kill_Tap == "kill")//killed him
                                            {
                                                PrintL("You snap the mans neck, he won't hurt anyone now.");
                                                vial = true;
                                                Powder = true;
                                                Poison = true;
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                PrintL("Recieved Vial");//still recieve vials
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Dead = true;//cant tallk to him
                                                PrintSomethingred("[Press Enter]");
                                                Console.ReadLine();
                                                goto case "look";

                                            }
                                            if (Kill_Tap == "tap")
                                            {
                                                Alerted = true;//now alerted can talk to
                                                PrintL("You tap the man on the shoulder.");
                                                PrintL("He turns around quite suprised.");
                                                Print("Merlin: ");
                                                PrintSomethingTalk("Well, hello there, my name is Merlin.");
                                                Print("Merlin: ");
                                                PrintSomethingTalk("I'm quite the famous alchemist.");
                                                Print("Merlin: ");
                                                PrintSomethingTalk("If you need anything let me know.");
                                                PrintSomethingred("[Press Enter]");
                                                Console.ReadLine();
                                                goto case "look";
                                            }
                                            else
                                            {
                                                PrintSomethingred("Not a valid option");
                                            }
                                        } while (Kill_Tap != "kill" || Kill_Tap != "tap");
                                        break;
                                    }
                                    if (Sneak_Alert == "alert")
                                    {
                                        Alerted = true;// alerted can talk to
                                        PrintL("He turns around, quite suprised.");
                                        Print("Merlin: ");
                                        PrintSomethingTalk("Well, hello there, my name is Merlin.");
                                        Print("Merlin: ");
                                        PrintSomethingTalk("I'm quite the famous alchemist.");
                                        Print("Merlin: ");
                                        PrintSomethingTalk("If you need anything, let me know.");
                                        PrintSomethingred("[Press Enter]");
                                        Console.ReadLine();
                                        goto case "look";

                                    }
                                    else
                                    {
                                        PrintSomethingred("Not a valid option");
                                        PrintSomethingred("[Press Enter]");
                                        Console.ReadLine();
                                    }
                                } while (Sneak_Alert != "sneak" || Sneak_Alert != "alert");

                            }
                            break;
                        #endregion
                        #region Mixer
                        case "mixer":
                            if (Player_Room == 7)
                            {
                                Console.Clear();
                                Print("Please list three things you'd like to combine or ");
                                PrintSomethingGreen("LEAVE");//choice
                                PrintL(" the area");
                                Print("Ex.");
                                PrintSomethingGreen("leather stick gold\n");//example, doesnt work
                                PrintL("Options:\n");
                                PrintSomethingGreen("Stick   Cloth   String\nLeather   Powder   Herb\nAlcohol   Wood   Poison\nWeapon   Water  Vial\n");//options
                                string Mixed;
                                do
                                {
                                    Blue_choice();
                                    Mixed = Console.ReadLine();
                                    Mixed = Mixed.ToLower();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    #region Crossbow
                                    if (Mixed == "wood stick string" || Mixed == "wood string stick" || Mixed == "stick wood string" ||
                                        Mixed == "string wood stick" || Mixed == "string stick wood" || Mixed == "stick string wood")// correct combination
                                    {
                                        if (Chunk_Wood == false)// no item
                                        {
                                            PrintSomethingred("Lacking Chunk of wood");
                                        }
                                        if (string1 < 0)//no item
                                        {
                                            PrintSomethingred("Lacking String");
                                        }
                                        if (stick == false)//  no item
                                        {
                                            PrintSomethingred("Lacking Stick");
                                        }
                                        if (Chunk_Wood == true && stick == true && string1 > 0)// required items
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            PrintL("You have made a CrossBow");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Crossbow = true;
                                            PrintSomethingred("Removed wood, string, and stick");
                                            string1--;
                                            Chunk_Wood = false;
                                            stick = false;
                                            PrintSomethingred("[Press Enter]");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto case "mixer";
                                        }

                                    }
                                    #endregion//crossbow
                                    #region Bomb
                                    if (Mixed == "leather powder string" || Mixed == "leather string powder" || Mixed == "powder string leather" ||
                                        Mixed == "powder leather string" || Mixed == "string powder leather" || Mixed == "string leather powder")//combination
                                    {
                                        if (Leather == false)//missing
                                        {
                                            PrintSomethingred("Lacking leather");
                                        }
                                        if (string1 < 0)//missing
                                        {
                                            PrintSomethingred("Lacking String");
                                        }
                                        if (Powder == false)//missing
                                        {
                                            PrintSomethingred("Lacking Powder");
                                        }
                                        if (Leather == true && Powder == true && string1 > 0)//required
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            PrintL("You have made a Bomb");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            bomb = true; Leather = false; string1--; Powder = false;
                                            PrintSomethingred("Removed Powder, string, leather");
                                            PrintSomethingred("[Press Enter]");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto case "mixer";
                                        }

                                    }
                                    #endregion
                                    #region MedKit
                                    if (Mixed == "alcohol cloth herb" || Mixed == "alcohol herb cloth" || Mixed == "cloth alcohol herb" ||
                                        Mixed == "cloth herb alcohol" || Mixed == "herb alcohol cloth" || Mixed == "herb cloth alcohol")// combinatio
                                    {
                                        if (Alcohol == false)//missing
                                        {
                                            PrintSomethingred("Lacking Alcohol");
                                        }
                                        if (herb == false)//mssing
                                        {
                                            PrintSomethingred("Lacking Herb");
                                        }
                                        if (cloth == false)//missing
                                        {
                                            PrintSomethingred("Lacking Cloth");
                                        }
                                        if (Alcohol == true && herb == true && cloth == true)//required
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            PrintL("You have made a MedKit");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            medKit = true; Alcohol = false; herb = false; ; cloth = false;
                                            PrintSomethingred("Removed Alcohol, water, cloth");
                                            PrintSomethingred("[Press Enter]");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto case "mixer";
                                        }

                                    }
                                    #endregion
                                    #region Poison
                                    if (Mixed == "weapon vial poison" || Mixed == "weapon poison vial" || Mixed == "vial weapon poison" ||
                                        Mixed == "vial poison weapon" || Mixed == "poison vial weapon" || Mixed == "poison weapon vial")//combination
                                    {
                                        if (Poison == false)//missing
                                        {
                                            PrintSomethingred("Lacking Poison");
                                        }
                                        if (vial == false)//missing
                                        {
                                            PrintSomethingred("Lacking Vial");
                                        }
                                        if (Poison == true && vial == true)//required
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            PrintL("You have made a Poison Vial");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Poison_Vial = true; vial = false; Poison = false;
                                            PrintSomethingred("Removed vial, Poison");
                                            PrintSomethingred("[Press Enter]");
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto case "mixer";
                                        }

                                    }
                                    #endregion

                                    if (Mixed == "leave")
                                    {
                                        PrintL("Leaving Mixer");
                                        PrintL("[Press Enter]");
                                        Console.ReadLine();
                                        Console.Clear();
                                        goto case "look";

                                    }
                                    else
                                    {
                                        PrintSomethingred("Nothing was made");
                                        Print("[Press Enter]");
                                        Console.ReadLine();

                                    }
                                } while (Mixed != "wood stick string" || Mixed != "wood string stick" || Mixed != "stick wood string" ||
                                        Mixed != "string wood stick" || Mixed != "string stick wood" || Mixed != "stick string wood" ||
                                        Mixed != "leave" || Mixed != "leather powder string" || Mixed != "leather string powder" || Mixed != "powder string leather" ||
                                        Mixed != "powder leather string" || Mixed != "string powder leather" || Mixed != "string leather powder"
                                        || Mixed != "alcohol cloth herb" || Mixed != "alcohol herb cloth" || Mixed != "cloth alcohol herb" ||
                                        Mixed != "cloth herb alcohol" || Mixed != "herb alcohol cloth" || Mixed != "herb cloth alcohol" ||
                                        Mixed != "weapon vial poison" || Mixed != "weapon poison vial" || Mixed != "vial weapon poison" ||
                                        Mixed != "vial poison weapon" || Mixed != "poison vial weapon" || Mixed != "poison weapon vial");//while none of these
                            }
                            break;
                        #endregion

                        #region Leave
                        case "leave":
                            Console.Clear();
                            if (Player_Room == 1)// not an option
                            {
                                PrintL("Where are you trying to Leave to?");
                            }
                            if (Player_Room == 2 && Kings_Motion == true)// if denied initiate attack
                            {
                                Player_Room = 1;
                                goto case "Dragon_Attack";
                            }
                            if (Player_Room == 2)//Notify player/set room
                            {
                                PrintL("Now leaving ThroneRoom");
                                PrintSomethingred("[Press Enter]");
                                Console.ReadLine();
                                Player_Room = 1;
                                goto case "look";
                            }
                            if (Player_Room == 2 && King_Deny == true)
                            {
                                Player_Room = 1;
                                goto case "Dragon_Attack";
                            }
                            if (Player_Room == 7)//Notify player/set room
                            {
                                PrintL("Now leaving Alchemist Study");
                                PrintSomethingred("[Press Enter]");
                                Console.ReadLine();
                                Player_Room = 6;
                                goto case "look";
                            }
                            if (Player_Room == 9)//Notify player/set room
                            {
                                PrintL("Now leaving Ship");
                                PrintSomethingred("[Press Enter]");
                                Console.ReadLine();
                                Player_Room = 6;

                                goto case "look";
                            }
                            if (Player_Room == 10)//Notify player/set room
                            {
                                PrintL("Now leaving Dragons den");
                                PrintSomethingred("[Press Enter]");
                                Console.ReadLine();
                                Player_Room = 6;

                                goto case "look";
                            }
                            if (Player_Room == 8)//Notify player/set room
                            {
                                PrintL("Now leaving Dragons Outlook");
                                PrintSomethingred("[Press Enter]");
                                Console.ReadLine();
                                Player_Room = 6;

                                goto case "look";
                            }


                            break;
                        #endregion
                        #region Exit
                        case "exit":
                            DoExit = true;//leave switch game
                            Play_Again = true;// leave program itself
                            Console.WriteLine("Goodbye Friends");
                            Console.ReadLine();
                            break;
                        case "again":
                            PrintL("Play Again?");
                            PrintSomethingGreen("Yes/No");//choice
                            Blue_choice();
                            string P_Again;
                            do
                            {
                                P_Again = Console.ReadLine();
                                P_Again = P_Again.ToLower();
                                Console.ForegroundColor = ConsoleColor.White;
                                if (P_Again == "yes")
                                {
                                    DoExit = true;//game loop reset
                                    PrintL("Have Fun!");
                                    PrintSomethingred("[Press Enter]");
                                    Console.ReadLine();
                                    Console.Clear(); break;
                                }
                                if (P_Again == "no")
                                {
                                    DoExit = true;//exit game loop
                                    Play_Again = true;// exit program loop
                                    PrintL("GoodBye");
                                    PrintSomethingred("[Press Enter]");
                                    Console.ReadLine();
                                    break;
                                }
                                else
                                {
                                    PrintSomethingred("Not and options");
                                    PrintSomethingred("[Press Enter]");
                                    Console.ReadLine();
                                }
                            } while (P_Again != "yes" || P_Again != "no");
                            break;
                        #endregion
                        default:
                            PrintL("What are you doing!?");
                            break;
                    }// Switch end

                } while (DoExit == false);//Game While
                DoExit = false;
            } while (Play_Again == false);//program exit
        }/// <summary>
         /// prints one word at a time for text
         /// </summary>
         /// <param name="text">Player input</param>
        static void type(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
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
