using System;
        
    class Menu
    {
        // Initialize some variables
        int balance = 10000; // The initial balance
        int pin = 1234; // The initial PIN
        bool exit = false; // A flag to exit the program

        public void Run()
        {
            // Greet the user
            Console.WriteLine("Welcome to the Y.G.T Banking ATM!");

            // Ask the user to enter the PIN
            Console.WriteLine("Please kindly enter your PIN:");
            int inputPin = int.Parse(Console.ReadLine());

            // Check if the PIN is correct
            if (inputPin == pin)
            {
                // Show the main menu
                ShowMenu();
            }
            else
            {
                // Show an error message and exit
                Console.WriteLine("Wrong PIN. Goodbye!");
                return;
            }
        }
        
        public void ShowMenu()
        {
            // Loop until the user chooses to exit
            while (!exit)
            {
                // Show the options
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Withdraw money");
                Console.WriteLine("3. Deposit money");
                Console.WriteLine("4. Change PIN");
                Console.WriteLine("5. Transfer Money");
                Console.WriteLine("6. Exit");

                // Get the user's choice
                int choice = int.Parse(Console.ReadLine());

                // Perform the corresponding action
                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        WithdrawMoney();
                        break;
                    case 3:
                        DepositMoney();
                        break;
                    case 4:
                        ChangePIN();
                        break;
                    case 5:
                        TransferMoney();
                        break;
                    case 6:
                        exit = true;
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }