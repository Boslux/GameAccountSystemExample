using GameSystemExample.Abstract;
using GameSystemExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystemExample.Concrete
{
    class GamerManager : IGamerService
    {
        IGamerValidateService _gameValidateService;
        public GamerManager(IGamerValidateService gamerValidateService)
        {
            _gameValidateService = gamerValidateService;
        }

        public void Add(Gamer gamer)
        {

            if (_gameValidateService.Validate(gamer)==true)
                Console.WriteLine("Gamer Adding Succsesfully");
            
            else
                Console.WriteLine("Gamer Adding Could't be done");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted Succsesfully");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated Succsusfully");
        }
    }
}
