using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10_Movie_List
{
    class Movie
    {//variable instance
        private string title;
        private string category;

     //Properties
        public string Title
        {
            get {return title;}
            set {title = value;}
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        //Constructor
        public Movie()
        {

        }
        public Movie (string _title, string _category)
        {
            Title = _title;
            Category = _category;
        }

        //Method to get movie category
        public static List<string> GetListOfCategories(List<Movie> categoryList)
        {
            List<string> CategoryTypes = new List<string>();
            foreach (Movie category in categoryList)
            {
                if (!CategoryTypes.Contains(category.Category))
                {
                    CategoryTypes.Add(category.Category);
                }
            }
            return CategoryTypes;
        }



        //Method to get movie category
        public static void PrintMovieCategory(List<Movie> categoryList)
        {
            byte index = 1;
            List<string> CategoryTypes = GetListOfCategories(categoryList);
            foreach (string type in CategoryTypes)
            {
                Console.WriteLine($"{index}. {type}");
                index++;
            }
            Console.WriteLine();
        }


        //Getting input from user
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }



        ////Method to display movie category
        public static void PrintMovieByCategory(List<Movie> categoryList, string categorySelected)
        {
            List<string> tempList = new List<string>();
            foreach (Movie movie in categoryList)
            {
                if (categorySelected == movie.Category)
                {
                    if (movie.Category == "Comedy")
                    {
                        tempList.Add(movie.Title);
                        
                    }
                    else if (movie.Category == "Animated")
                    {
                        tempList.Add(movie.Title);
                       
                    }
                    else if (movie.Category == "Action")
                    {
                        tempList.Add(movie.Title);
                        
                    }

                }
            }

            //print aplphabetically sorted list
            tempList.Sort();
            for (int i = 0; i < tempList.Count; i++)
            {
                Console.WriteLine(tempList[i]);
            }
        }


        //Method to ask user if they want to continue
        public static bool KeepGoing(string message, string option1, string option2)
        {
            string keepGoing = GetUserInput(message).ToLower();
            if (keepGoing == option1)
            {
                return false;
            }
            else if (keepGoing == option2)
            {
                return true;
            }
            else
            {
                return KeepGoing("Not valid! " + message, option1, option2);
            }
        }




    }
}
