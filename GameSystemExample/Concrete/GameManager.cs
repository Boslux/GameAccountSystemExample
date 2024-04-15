using GameSystemExample.Abstract;
using GameSystemExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystemExample.Concrete
{
    class GameManager : IGameService
    {
        public void Select(Game game)
        {
            Console.WriteLine("Gamer Started Succsesfully");
        }

        public void Refund(Game game)
        {
            while (true)
            {
                Console.WriteLine($"Are you Sure for the refund {game} - yes/no");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("Game Refunded Succsesfully.");
                    break;
                }
                else if (answer == "no")
                {
                    Console.WriteLine("Game Refunded Canceled.");
                    break;
                }
                else
                    Console.WriteLine("Please Entry 'yes' or 'no'.");

            }

        }
        
    }
}
