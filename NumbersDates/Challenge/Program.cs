// See https://aka.ms/new-console-template for more information
            while (true)
            {
                Console.WriteLine("Enter a date (YYYY-MM-DD) or type 'exit' to quit:");
                string userInput = Console.ReadLine().Trim();

                
                if (userInput.ToLower() == "exit") 
                {
                    Console.WriteLine("Exiting the program.");
                    break;
                }

                
                if (DateTime.TryParse(userInput, out DateTime enteredDate))
                {
                    CalculateDaysDiff(enteredDate);
                
                }
                else
                {
                    Console.WriteLine("Invalid date format :(. Please enter the date in the correct  YYYY-MM-DD format.");
                }
            }
        }

        static void CalculateDaysDiff(DateTime inputDate)
        {
            DateTime currentDate = DateTime.Now.Date;

            
            TimeSpan difference = inputDate.Date - currentDate;

            if (diff.Days > 0)
            {
                Console.WriteLine($"The date {inputDate:yyyy-MM-dd} is {diff.Days} days from now.");
            }
            else if (diff.Days < 0)
            {
                Console.WriteLine($"The date {inputDate:yyyy-MM-dd} was {-diff.Days} days ago.");
            }
            else
            {
                Console.WriteLine($"The date {inputDate:yyyy-MM-dd} is today.");
            }
        }
    
