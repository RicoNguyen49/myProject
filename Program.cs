using System;

namespace myProject
{
    class games
    {
        private int _Year;
        private string _Title;
        private string _Company;
        private static int _Count = 0;
        public games()
        {
            _Year = 0;
            _Title = "";
            _Company = "";
        }

        public games(int year, string title, string company)
        {
            _Year = year;
            _Title = title;
            _Company = company;
        }

        public void SetYear(int year)
        {
            _Year = year;
        }

        public int GetYear()
        {
            return _Year;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public string GetTitle()
        {
            return _Title;
        }

        public void SetCompany(string company)
        {
            _Company = company;
        }

        public string GetCompany()
        {
            return _Company;
        }
        public void SetCount()
        {
            _Count++;
        }
        public static int GetCount()
        {
            return _Count;
        }
    }
    class myGames
    {
        static void Main(string[] args)
        {
            games game1 = new games();
            game1.SetYear(2020);
            game1.SetTitle("Valorant");
            game1.SetCompany("Riot Games");
            game1.SetCount();


            games game2 = new games();
            Console.WriteLine("Please enter the year the game was released: ");
            game2.SetYear(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the game title: ");
            game2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the company that created the game: ");
            game2.SetCompany(Console.ReadLine());
            game2.SetCount();


            games game3 = new games(2017, "Fornite", "Epic Games");
            game3.SetCount();


            Console.WriteLine("Please enter the year the game was released: ");
            int tempYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the game title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the company that created the game: ");
            string tempCompany = Console.ReadLine();
            games game4 = new games(tempYear, tempTitle, tempCompany);
            game4.SetCount();



            Console.WriteLine($"Total number of games: {games.GetCount()}");


            displaygames(game1);
            displaygames(game2);
            displaygames(game3);
            displaygames(game4);
        }

        static void displaygames(games games)
        {
            Console.WriteLine("Here's your game information:");
            Console.WriteLine($"year released: {games.GetYear()}");
            Console.WriteLine($"Title: {games.GetTitle()}");
            Console.WriteLine($"Company: {games.GetCompany()}");
        }
    }
}