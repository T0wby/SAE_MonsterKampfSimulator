﻿using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace Monsterkampfsimulator
{
    static class Messages
    {
        // Variable used for the color of the user input
        public static ConsoleColor green = ConsoleColor.Green;

        /** Writes messages in red **/
        public static void PrintErrorColor(string Input, ConsoleColor cc = ConsoleColor.Red)
        {
            Console.ForegroundColor = cc;
            Console.WriteLine(Input);
            Console.ResetColor();
        }

        /** Writes messages in DarkMagenta **/
        public static void PrintConsoleMessageColor(string Input, ConsoleColor cc = ConsoleColor.DarkMagenta)
        {
            Console.ForegroundColor = cc;
            Console.WriteLine(Input);
            Console.ResetColor();
        }

        /** Writes messages in Yellow **/
        public static void PrintOrkMessageColor(string Input, ConsoleColor cc = ConsoleColor.Yellow)
        {
            Console.ForegroundColor = cc;
            Console.WriteLine(Input);
            Console.ResetColor();
        }

        /** Writes messages in DarkGreen **/
        public static void PrintTrollMessageColor(string Input, ConsoleColor cc = ConsoleColor.DarkGreen)
        {
            Console.ForegroundColor = cc;
            Console.WriteLine(Input);
            Console.ResetColor();
        }

        /** Writes messages in DarkCyan **/
        public static void PrintGoblinMessageColor(string Input, ConsoleColor cc = ConsoleColor.DarkCyan)
        {
            Console.ForegroundColor = cc;
            Console.WriteLine(Input);
            Console.ResetColor();
        }

        public static string UserInputMessage(ConsoleColor cc = ConsoleColor.Green)
        {
            string input;
            Console.ForegroundColor = cc;
            input = Console.ReadLine();
            Console.ResetColor();
            return input;
        }

        /** Starting with setting the console size if possible, writing a text and looping the main song **/
        public static void WelcomeMessage(SoundPlayer MenuStartSound)
        {
            try
            {
                Console.SetWindowSize(150, 60);
            }
            catch
            {
                PrintErrorColor("Console SetWindowSize failed");
            }
            PrintConsoleMessageColor(@"                   ██╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗███████╗    ████████╗ ██████╗     ███╗   ███╗██╗   ██╗      
                   ██║    ██║██╔════╝██║     ██╔════╝██╔═══██╗████╗ ████║██╔════╝    ╚══██╔══╝██╔═══██╗    ████╗ ████║╚██╗ ██╔╝      
                   ██║ █╗ ██║█████╗  ██║     ██║     ██║   ██║██╔████╔██║█████╗         ██║   ██║   ██║    ██╔████╔██║ ╚████╔╝       
                   ██║███╗██║██╔══╝  ██║     ██║     ██║   ██║██║╚██╔╝██║██╔══╝         ██║   ██║   ██║    ██║╚██╔╝██║  ╚██╔╝        
                   ╚███╔███╔╝███████╗███████╗╚██████╗╚██████╔╝██║ ╚═╝ ██║███████╗       ██║   ╚██████╔╝    ██║ ╚═╝ ██║   ██║         
                    ╚══╝╚══╝ ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝       ╚═╝    ╚═════╝     ╚═╝     ╚═╝   ╚═╝         
                                                                                                                                     
                   ███████╗██╗ ██████╗ ██╗  ██╗████████╗    ███████╗██╗███╗   ███╗██╗   ██╗██╗      █████╗ ████████╗ ██████╗ ██████╗ 
                   ██╔════╝██║██╔════╝ ██║  ██║╚══██╔══╝    ██╔════╝██║████╗ ████║██║   ██║██║     ██╔══██╗╚══██╔══╝██╔═══██╗██╔══██╗
                   █████╗  ██║██║  ███╗███████║   ██║       ███████╗██║██╔████╔██║██║   ██║██║     ███████║   ██║   ██║   ██║██████╔╝
                   ██╔══╝  ██║██║   ██║██╔══██║   ██║       ╚════██║██║██║╚██╔╝██║██║   ██║██║     ██╔══██║   ██║   ██║   ██║██╔══██╗
                   ██║     ██║╚██████╔╝██║  ██║   ██║       ███████║██║██║ ╚═╝ ██║╚██████╔╝███████╗██║  ██║   ██║   ╚██████╔╝██║  ██║
                   ╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚══════╝╚═╝╚═╝     ╚═╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝

                                                   ____                               ____                             
                                                  |  _ \  _ __  ___  ___  ___        / ___|                            
                                                  | |_) || '__|/ _ \/ __|/ __|       \___ \                            
                                                  |  __/ | |  |  __/\__ \\__ \        ___) |                           
                                                  |_|    |_|   \___||___/|___/       |____/                            
                        _                _                _     _    _                                           
                       | |_  ___    ___ | |_  __ _  _ __ | |_  | |_ | |__    ___    __ _   __ _  _ __ ___    ___ 
                       | __|/ _ \  / __|| __|/ _` || '__|| __| | __|| '_ \  / _ \  / _` | / _` || '_ ` _ \  / _ \
                       | |_| (_) | \__ \| |_| (_| || |   | |_  | |_ | | | ||  __/ | (_| || (_| || | | | | ||  __/
                        \__|\___/  |___/ \__|\__,_||_|    \__|  \__||_| |_| \___|  \__, | \__,_||_| |_| |_| \___|
                                                                                   |___/                         ");

            MenuStartSound.LoadAsync();
            MenuStartSound.PlayLooping();
        }

        /** While loop which ends as soon as we get the correct input **/
        public static void WaitingForSKey()
        {
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if ((key.KeyChar == 'S') || (key.KeyChar == 's'))
                {
                    Console.Clear();
                    break;
                }
            }
        }

        /** ASCII messages for the first display of fighters **/
        public static void DisplayFightersOne()
        {
            PrintConsoleMessageColor(@"
██     ██ ██   ██ ██  ██████ ██   ██                                                                                                       
██     ██ ██   ██ ██ ██      ██   ██                                                                                                       
██  █  ██ ███████ ██ ██      ███████                                                                                                       
██ ███ ██ ██   ██ ██ ██      ██   ██                                                                                                       
 ███ ███  ██   ██ ██  ██████ ██   ██                                                                                                       
                                                                                                                                           
                                                                                                                                           
 ██████  ███████     ████████ ██   ██ ███████ ███████ ███████     ██████      ███████ ██  ██████  ██   ██ ████████ ███████ ██████  ███████ 
██    ██ ██             ██    ██   ██ ██      ██      ██               ██     ██      ██ ██       ██   ██    ██    ██      ██   ██ ██      
██    ██ █████          ██    ███████ █████   ███████ █████        █████      █████   ██ ██   ███ ███████    ██    █████   ██████  ███████ 
██    ██ ██             ██    ██   ██ ██           ██ ██               ██     ██      ██ ██    ██ ██   ██    ██    ██      ██   ██      ██ 
 ██████  ██             ██    ██   ██ ███████ ███████ ███████     ██████      ██      ██  ██████  ██   ██    ██    ███████ ██   ██ ███████ 
                                                                                                                                           
                                                                                                                                           
██████   ██████      ██    ██  ██████  ██    ██     ██████  ██  ██████ ██   ██     ███████ ██ ██████  ███████ ████████ ██████              
██   ██ ██    ██      ██  ██  ██    ██ ██    ██     ██   ██ ██ ██      ██  ██      ██      ██ ██   ██ ██         ██         ██             
██   ██ ██    ██       ████   ██    ██ ██    ██     ██████  ██ ██      █████       █████   ██ ██████  ███████    ██      ▄███              
██   ██ ██    ██        ██    ██    ██ ██    ██     ██      ██ ██      ██  ██      ██      ██ ██   ██      ██    ██      ▀▀                
██████   ██████         ██     ██████   ██████      ██      ██  ██████ ██   ██     ██      ██ ██   ██ ███████    ██      ██");

            PrintOrkMessageColor(@"
 ██╗        ██████╗ ██████╗ ██╗  ██╗
███║       ██╔═══██╗██╔══██╗██║ ██╔╝
╚██║       ██║   ██║██████╔╝█████╔╝ 
 ██║       ██║   ██║██╔══██╗██╔═██╗ 
 ██║██╗    ╚██████╔╝██║  ██║██║  ██╗
 ╚═╝╚═╝     ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝");

            PrintTrollMessageColor(@"
██████╗        ████████╗██████╗  ██████╗ ██╗     ██╗     
╚════██╗       ╚══██╔══╝██╔══██╗██╔═══██╗██║     ██║     
 █████╔╝          ██║   ██████╔╝██║   ██║██║     ██║     
██╔═══╝           ██║   ██╔══██╗██║   ██║██║     ██║     
███████╗██╗       ██║   ██║  ██║╚██████╔╝███████╗███████╗
╚══════╝╚═╝       ╚═╝   ╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚══════╝");

            PrintConsoleMessageColor(@"
 ██████ ██████  
██    ████   ██ 
██    ████████  
██    ████   ██ 
 ██████ ██   ██ ");

            PrintGoblinMessageColor(@"
██████╗         ██████╗  ██████╗ ██████╗ ██╗     ██╗███╗   ██╗
╚════██╗       ██╔════╝ ██╔═══██╗██╔══██╗██║     ██║████╗  ██║
 █████╔╝       ██║  ███╗██║   ██║██████╔╝██║     ██║██╔██╗ ██║
 ╚═══██╗       ██║   ██║██║   ██║██╔══██╗██║     ██║██║╚██╗██║
██████╔╝██╗    ╚██████╔╝╚██████╔╝██████╔╝███████╗██║██║ ╚████║
╚═════╝ ╚═╝     ╚═════╝  ╚═════╝ ╚═════╝ ╚══════╝╚═╝╚═╝  ╚═══╝");
        }

        /** Explanation message for the attributes and how we collect them **/
        public static void ExplanationMessage()
        {
            PrintConsoleMessageColor($"\nNow we need your help! Each of our fighters has different attributes which we need YOU to set for us.\n" +
                $"Those attributes are the following:\n" +
                $"1. Healthpoints\n" +
                $"2. Attackpoints\n" +
                $"3. Defensepoints\n" +
                $"4. Speed\n" +
                $"----------------\n" +
                $"We will ask for each attribute seperately from 1 to 4 and start with your first picked fighter the {FightLogic.FighterOne}.\n");
        }

        /** Transition message between the collection of the attributes of both fighters **/
        public static void TransitionMessage()
        {
            PrintConsoleMessageColor($"\n\nGreat! The {FightLogic.FighterOne} now has stats for each of their attributes.\n" +
                $"----------------\n" +
                $"We will now proceed with the stats for our 2nd fighter the {FightLogic.FighterTwo}.\n" +
                $"----------------\n");
        }

        /** Message ending the attribute collection and telling the user to press any button to start the fight **/
        public static void AttributeEndMessage()
        {
            Messages.PrintConsoleMessageColor($"\nAmazing! Now that both our fighters the {FightLogic.FighterOne} and {FightLogic.FighterTwo} are ready to start their battle please give us the start signal " +
                $"by pressing any BUTTON on your keyboard!!\n");
        }

        /** ASCII Art and sound for the start of the fight **/
        public static void StartFightMessageAndSound(SoundPlayer FightStartSound)
        {
            FightStartSound.LoadAsync();
            FightStartSound.PlaySync();
            PrintConsoleMessageColor(@"
  _____  _         _      _    _  _ 
 |  ___|(_)  __ _ | |__  | |_ | || |
 | |_   | | / _` || '_ \ | __|| || |
 |  _|  | || (_| || | | || |_ |_||_|
 |_|    |_| \__, ||_| |_| \__|(_)(_)
            |___/                   ");
        }

        /** Gives out the message which is shown after a fight ended **/
        public static void FightEndMessage()
        {
            PrintConsoleMessageColor(@"
███████╗██╗ ██████╗ ██╗  ██╗████████╗    ███████╗███╗   ██╗██████╗ ███████╗██████╗ 
██╔════╝██║██╔════╝ ██║  ██║╚══██╔══╝    ██╔════╝████╗  ██║██╔══██╗██╔════╝██╔══██╗
█████╗  ██║██║  ███╗███████║   ██║       █████╗  ██╔██╗ ██║██║  ██║█████╗  ██║  ██║
██╔══╝  ██║██║   ██║██╔══██║   ██║       ██╔══╝  ██║╚██╗██║██║  ██║██╔══╝  ██║  ██║
██║     ██║╚██████╔╝██║  ██║   ██║       ███████╗██║ ╚████║██████╔╝███████╗██████╔╝
╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚══════╝╚═╝  ╚═══╝╚═════╝ ╚══════╝╚═════╝ 
-----------------------------------------------------------------------------------");
        }

        /** Contains the credits to all the content used by 3rd parties **/
        public static void Credits()
        {
            Console.WriteLine("\n\n\n\n\n");
            PrintConsoleMessageColor(@"
-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------
██████╗██████╗ ███████╗██████╗ ██╗████████╗███████╗
██╔════╝██╔══██╗██╔════╝██╔══██╗██║╚══██╔══╝██╔════╝
██║     ██████╔╝█████╗  ██║  ██║██║   ██║   ███████╗
██║     ██╔══██╗██╔══╝  ██║  ██║██║   ██║   ╚════██║
╚██████╗██║  ██║███████╗██████╔╝██║   ██║   ███████║
 ╚═════╝╚═╝  ╚═╝╚══════╝╚═════╝ ╚═╝   ╚═╝   ╚══════╝");

            Console.WriteLine("This programm uses the following sounds from Freesound.org:\n\n" +
                "Content Under 'Creative Commons 0 License':\n" +
                "Countdown To Fight by Nakamurasensei | https://freesound.org/people/Nakamurasensei/sounds/472853/ \n" +
                "Game_Over_01 by MATRIXXX_ | https://freesound.org/people/MATRIXXX_/sounds/345666/ \n\n" +
                "Content Under 'Attribution Noncommercial License':\n" +
                "Dramatic Scroller by FoolBoyMedia | https://freesound.org/people/FoolBoyMedia/sounds/270366/" +
                "-----------------------------------------------------------------------------------");
        }

    }
}
