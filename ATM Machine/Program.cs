//This is a basic ATM Simulator. 
using System;

namespace ATM_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("--------------------------");
            Console.WriteLine("------= ATM MACHINE =-----");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1. Login");
            Console.WriteLine("9. Close App");
            Console.WriteLine("--------------------------");
            
            while (!endApp){
                //TODO: Ask user Name and pin Login
                if (Console.ReadLine() == 1){
                   User.Login(); 
                } 
                
                // Admin Secret Login
                if (Console.ReadLine() == "admin"){
                   User.AdminPanel(); 
                } 

                //TODO: Give authorized user access to account 
                
                //TODO: Give options to Transact or pull balance
                
                //TODO: Logout
                if (Console.ReadLine() == 9) User.Logout();
            }
        }
    }
    
    //Test
    // TODO: create users
    class User{
        //TODO: Login
        public bool Login(){
            Transaction();
        }
        public bool Logout(){
            return endApp = true; 
        }

    }

    // TODO: Deposil/Withdraw
    class Transaction{
           static int Withdraw(){
            Console.WriteLine("--------------------------");
            Console.WriteLine("------= ATM MACHINE =-----");
            Console.WriteLine("--------Transaction-------");
           } 
           static int Deposit(){
            Console.WriteLine("--------------------------");
            Console.WriteLine("------= ATM MACHINE =-----");
            Console.WriteLine("--------Transaction-------");
           } 
    }

    // TODO: Admin Panel
    class AdminPanel{
        
    }
    
    
    // TODO: Store users funds
    class ManageDB{
        
    }

    // TODO: encrypt pin
    class Encryption{
        
    }
}








            //Console.WriteLine("--------------------------");
            //Console.WriteLine("------= ATM MACHINE =-----");
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("1. Login");
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("--------------------------");