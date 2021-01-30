using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    interface IGamerManagerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);

    }
}
