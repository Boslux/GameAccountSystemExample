using GameSystemExample.Concrete;
using GameSystemExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystemExample
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            GameManager gameManager = new GameManager();

            Console.WriteLine("Please Enter Your Account Information");
            Gamer gamer = new Gamer
            {
                Id = 1,
                GamerName =  Console.ReadLine(),
                GamerLastName = Console.ReadLine(),
                Password = Console.ReadLine()
            };

            gamerManager.Add(gamer);
            Game game = new Game
            {
                GameID=1,
                GameName="Run Little Thing",
                GamePrice=10
            };

            gameManager.Select(game);
            Console.WriteLine(game.GameName + game.GamePrice);
            gameManager.Refund(game);
            Console.WriteLine("All Progress Complete");

        }
    }
}
