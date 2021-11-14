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
            
            while (!endApp){
                //TODO: Ask user Name and pin Login
                if (Console.ReadLine() == 1) User.Login();
                //TODO: Give authorized user access to account 
                //TODO: Give options to Transact or pull balance
                //TODO: Logout
                if (Console.ReadLine() == 9) User.Logout();
            }
        }
    }
    
    // TODO: create users
    class User{
        //TODO: Login
        public bool Login(){
            return endApp = true; 
        }
        public bool Logout(){
            return endApp = true; 
        }

    }

    // TODO: Deposil/Withdraw
    class Transaction{
        
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
