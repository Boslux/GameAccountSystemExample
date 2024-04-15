using GameSystemExample.Abstract;
using GameSystemExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystemExample.Concrete
{
    class GamerValidationManager : IGamerValidateService
    {
        public bool Validate(Gamer gamer)
        {
            if (
                gamer.Id == 1 &&
                gamer.GamerName == "admin" &&
                gamer.GamerLastName == "admin"&&
                gamer.Password=="admin"
                )
            {
                Console.WriteLine("User Security Passed ");
                return true;
            }
            else
            {
                Console.WriteLine("Wrong İnformation");
                return false;
            }
        }
    }
}
