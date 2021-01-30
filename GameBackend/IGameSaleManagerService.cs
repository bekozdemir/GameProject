using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    interface IGameSaleManagerService
    {
        void Sell(GameSale game, Gamer gamer, Campaign campaign);
        void Repayment(GameSale game, Gamer gamer, Campaign campaign);
    }
}
