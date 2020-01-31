using System;
using System.Collections.Generic;

namespace Lab_10_Movie_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> MovieList = new List<Movie>
            {
                new Movie("Airplane", "Comedy"),
                new Movie("Home Alone", "Comedy"),
                new Movie("Mrs. Doubtfire", "Comedy"),
                new Movie("Frozen", "Animated"),
                new Movie("Coco", "Animated"),
                new Movie("Aladdin", "Animated"),
                new Movie("Terminator", "Action"),
                new Movie("Rambo", "Action"),
                new Movie("Black Panther", "Action"),
                new Movie("The Bourne Ultimatum", "Action"),
            };


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.ResetColor();


            //Program will continue asking user if they enter invalid input and also asks them if they want to know about another movie category 
            bool wantToContinue = true;
            bool validEntry = true;
            int index = 0;
            while (wantToContinue)
            {
                validEntry = true;

                //Display movie category list
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("There are three movie categories in this list:");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Movie.PrintMovieCategory(MovieList);
                Console.ResetColor();


                while (validEntry)
                {
                    //Asking user to select category by entering number
                    Console.ForegroundColor = ConsoleColor.Blue;
                    string userChoice = Movie.GetUserInput("What category are you interested in?\n" +
                        "Please select the category by entering a number (1-3):");
                   
                     index = int.Parse(userChoice);
                    Console.ResetColor();

                    //validating the user input
                    if (index < 1 || index > 3)
                    {
                        Console.WriteLine("Invalid Entry, please try again.");
                        validEntry = true;
                    }
                    else
                    {
                        validEntry = false;
                    }
                }

                //Showing the result of movie names based on catagory selsected by user
                List<string> CategoryTypes = Movie.GetListOfCategories(MovieList);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"You have selected category {CategoryTypes[index - 1]}, Here is the list:");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Movie.PrintMovieByCategory(MovieList, CategoryTypes[index - 1]);
                Console.ResetColor();

                
                //asking user if they want to continue
                wantToContinue = Movie.KeepGoing($"Would you like to know about another movie category (y/n)?", "n", "y");
            }

            Console.WriteLine("Thank you for your time, Goodbye!");
            Console.ReadKey();


        }
    }
}