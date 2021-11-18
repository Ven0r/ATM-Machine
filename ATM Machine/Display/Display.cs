using System;

namespace ATM_Machine
{
    class Menu
    {
        private int SelectedIndex;
        private string Prompt; 
        private string[] Options; 
        
        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }
        
        public void DisplayOptions()
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                Console.WriteLine($"<<{currentOption}>>");
            }
        }
    }
}