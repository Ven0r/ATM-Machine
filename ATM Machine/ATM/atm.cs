using System;
using DB;
using Display;

namespace ATM
{
    // Transaction class that handles all the basic functions of the atm.
    // Withdraw, Deposit, Check Balance.
    
    public class Start
    {
       public static void Run()
       {
           Screen.Banner();

           // Grab key pressed
           ConsoleKeyInfo keyPressed = Console.ReadKey();
           
           // Check the key pressed
           



           
           // Check the key pressed
           //if (keyPressed.Key == ConsoleKey.Enter)
           //{
           //    Console.WriteLine("You Pressed Enter");
           //}
           //else if (keyPressed.Key == ConsoleKey.UpArrow)
           //{
           //    Console.WriteLine("Your Pressed the up arrow");
           //}
           //
           //Console.WriteLine("Press any key to exit");
           //Console.ReadKey(false);
           
           
       }
    }
    public class Transaction{
           public static int Withdraw(){
               return 0;
           } 
           public static int Deposit(){
               return 0;
           } 
           public static int GetBalance(){
               return 0;
           } 
    }
}