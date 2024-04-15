using GameSystemExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystemExample.Abstract
{
    public interface IGamerValidateService
    {
        bool Validate(Gamer gamer);
    }
}
