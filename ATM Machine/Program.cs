//This is a basic ATM Simulator. 
using System;

namespace ATM_Machine
{
    // Main Operation for ATM-Machine
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            
            while (!endApp)
            {
                Start.Run();
            }
        }
    }
}