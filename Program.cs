/**
 * ITC366-899 HOMEWORK TEMPLATE
 * 
 * author
 * Matthew Taylor
 *
 * SOURCE LINK
 * 
 * VIDEO LINK
 *  
 */

//package declarations
using System;
using System.IO;
using System.Text;

namespace Homework_Template
{
    class HomeworkAssignment
    {
        //// DECLARE ANY ENUM's HERE 
        ///BETWEEN CLASS DECLARATION & MAIN METHOD ////

        //Rock, Paper, Scissors Enum
        public enum RPS
        {
            ROCK = 1, PAPER, SCISSOR
        }

        public enum rps { r = 1, p, s }

        //Main method
        public static void Main(string[] args)
        {
            //Headers and Instructions strings
            String headerBar = new string('*', 40);
            String header = "\n  -  ITC366-899 Homework  -\nMatthew Taylor\nmatt271@live.missouristate.edu\n";
            String instructions = "Enter the number from one the following to run the corresponding exercise code: \n";
            String exerciseList = ": Exercise ";

            //Main method control variable declaration and initialization
            Boolean continueStatus = true; //initialize and set loop control boolean
            int length = 5; //sets number of exercises
            char exerciseSelection, continueChoice; //character variables to hold exercise selection

            Console.WriteLine(headerBar + header + headerBar);

            //Console.Write("Enter your name: ");
            //String enteredName = Console.ReadLine(); 

            /*
            * While loop runs as long as users choose to continue program
            * 
            * Improvement notes: implement break and continue statements
            */

            while (continueStatus == true)
            {

                ///// Write Program Instructions /////
                Console.WriteLine(instructions);


                //loop through exercises and display menu
                for (int loopIndex = 1; loopIndex <= length; loopIndex++)
                {
                    Console.WriteLine(loopIndex + exerciseList + loopIndex);

                }//end menu text for loop

                //prompt for and retrieve exercise selection
                Console.WriteLine("Enter exercise selection: ");
                exerciseSelection = (char)Console.Read();
                ClearKeys();


                switch (exerciseSelection)
                {
                    case '1':

                        Exercise1();

                        break; // end case 1


                    case '2':

                        //Exercise Header and instructions
                        Console.WriteLine("Exercise 2 has been chosen.");
                        Exercise2();

                        break; // end case 2


                    case '3':

                        Console.WriteLine("Exercise 3 has been chosen.");
                        Exercise3();
                        break; //end case 3

                    case '4':
                        Console.WriteLine("Exercise 4 has been chosen.\n{0}");


                        break; //end case 4

                    case '5':

                        Console.WriteLine("Exercise 5 has been chosen.\n{0}");
            
                        break; //end case 5
                    default:
                        Console.WriteLine("Invalid input.");
                        break;

                } ////// end exercise selection switch //////


                ///// Continue program section /////
                Console.WriteLine("Continue (y/n)?");
                continueChoice = (char)Console.Read();
                ClearKeys();

                // conditionals to determine whether to exit while loop
                if (continueChoice == 'y')
                {
                    continueStatus = true;
                    Console.WriteLine("Choose another exercise.\n");

                }//end if

                else
                {
                    continueStatus = false;
                    Console.WriteLine("Thank you for using this application.\n");
                }//end else

            }//end program continuation while loop

        }//end main method


        // ClearKeys method code located through research to ensure that characters are read correctly

        public static void ClearKeys()
        {
            while (Console.In.Peek() != -1)
                Console.In.Read();
        }

        public static void Exercise1()
        {
            //declare strings
            String StrMsgPrompt = "Enter a short message: ";
            String StrAcceptable = "The message is okay.";
            String StrDecline = "The message is too long.";

            Console.Write(StrMsgPrompt);
            String message = Console.ReadLine();
            int messageLength = message.Length;

            if (messageLength > 140)
            {
                Console.WriteLine(StrDecline);
            }
            else if (messageLength <= 140)
            {
                Console.WriteLine(StrAcceptable);
            }
            else
            {
                Console.WriteLine("There has been an error.");
            }

        } //end Exercise1 method


        /*
         * Exercise 2
         */

        public static void Exercise2()
        {
            //Exercise Header
            Console.WriteLine("*", 40);
            Console.WriteLine("     - Admission Decision -     ");
            Console.WriteLine("*", 40);

            //Prompt strings
            String StrGPA = "Enter student grade point average: ";
            String StrTestScore = "Enter test score: ";

            //input section
            Console.WriteLine($"{StrGPA}: ");
            String StrGPAentry = Console.ReadLine();
            double GPAentry = Convert.ToDouble(StrGPAentry);
            Console.Write($"{StrTestScore}: ");
            double testScore = Convert.ToDouble(Console.ReadLine());

            //Determine admission section
            if (GPAentry > 3.0 && testScore > 60 || GPAentry < 3.0 && testScore > 80)
            {
                Console.WriteLine("ACCEPTED");
            } //end if
            else
            {
                Console.WriteLine("Sorry, the application has been rejected.");
            } //end else


        } // end Exercise2 method

        /**
         * Exercise 3 
         * 
         * Rock Paper Scissors
         * 
         **/

        public static void Exercise3()
        {
            // Initialize random number generator
            Random randomGenerator = new Random();
            
            rps gameChoice = (rps)randomGenerator.Next(1, 3); // create an rps enum object to store the randomly generated value, which has been cast to match the rpc type
            RPS gameState, userState;
            //rps playerState;
            int gameNumber = (int)gameChoice;

            gameState = (RPS)gameChoice;

            //debug section
            Console.WriteLine("gameState " + gameState);
            Console.WriteLine("gameChoice " + gameChoice);
            Console.WriteLine("gameNumber  " + gameNumber);


            // INPUT SECTION //
            String StrPlayerChoiceMsg = "Enter r, p, or s to choose Rock, Paper, or Scissors: ";
            Console.WriteLine(StrPlayerChoiceMsg);
            char userChoiceChar = (char)Console.Read();
            ClearKeys();
            //int userNumber = (int)

            if (userChoiceChar == 'r')
            {
                Console.WriteLine("r was chosen");
                int userChoiceInt = 1;
            }
            else if (userChoiceChar) == ''

            rps userChoice = (rps)userChoiceChar;
            //rps userChoice = (int)rps.userrps;
            int userNumber = (int)userChoice;
            userState = (RPS)userChoice;

            
            //debug section
            Console.WriteLine($"userChoiceChar: {userChoiceChar}");
            Console.WriteLine($"userChoice:  " + userChoice);
            Console.WriteLine($"userNumber: {userNumber}");
            Console.WriteLine("userState: " + userState);
            

            
            // Check Game State // 
            //Console.WriteLine($"Computer choice: {gameChoice}");
            //Console.WriteLine($"Player choice: {userState}");
            //int userNumber = (rps)userChoice;

            //Console.WriteLine("(int)rps.r " + (int)rps.r); // (int)rps.r >> 1

            //int rpcValue = (int)rpc.userChoice;
            //playerState.userChoice;
            //Console.WriteLine();


            //Console.WriteLine("userChoice= " + (int)rps.);

            // Check input validity
            /*
            switch ((rps)userChoiceChar)
            {
                case rps.r:
                    Console.WriteLine("rps.r " + rps.r);
                    break;
                case rps.p:
                    Console.WriteLine("rps.p " + rps.s);
                    break;
                case rps.s:
                    Console.WriteLine("rps.s" + rps.s);
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
            */

            //if (userChoice != 'r' && gameChoice != 'p' && gameChoice != 's')
            //{
            //    Console.WriteLine($"Invalid Input. {StrPlayerChoiceMsg}");
            //    userChoice = (char)Console.Read();
            //    ClearKeys();

            //} // end invalid input case

            ////else // valid input case
            //{
            //    Console.WriteLine("Begin valid input case.");
            //    //Console.WriteLine($"Player chose {(int)rpc.userChoice} ");
            //    Console.WriteLine($"Computer chose: {(RPS)gameChoice}");

            //    ////computer selects choice
            //    //gameChoice = randomGenerator.Next(1, 3);
            //    //String StrCompuChoiceMsg = "Computer picked: "; 
            //    //Console.WriteLine(StrCompuChoiceMsg + (RPC)gameChoice);

            //    /*
            //     * Determine game outcome by testing against the different game states.
            //     * 
            //     * user/computer choice     (u,c)
            //     * Rock breaks scissors,    (r,s)
            //     * Scissors cuts paper,     (s,p)
            //     * Paper covers Rock,       (p,r)
            //     * 
            //     */


            //    //if ()
            //    //{
            //    //    Console.WriteLine("User input equals computer choice. Choose again.");

            //    //}

            //    //else if ((int)RPC.r == randomNumber)
            //    //{

            //    //}



            //} //end valid input case}



        } //end Exercise3

    } //end HomeworkAssignment class

} //end namespace

