using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class GameSaleManager : IGameSaleManagerService
    {
        ICampaignManagerService _campaignManagerService;

        public GameSaleManager(ICampaignManagerService campaignManagerService)
        {
            _campaignManagerService = campaignManagerService;
        }

        public void Repayment(GameSale game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(game.GameName+ "," + gamer.FirstName + gamer.LastName+ " tarafından iade edildi.");
        }

        public void Sell(GameSale game, Gamer gamer, Campaign campaign)
        {
            _campaignManagerService.Add(campaign);
            Console.WriteLine(game.GameName + ", " + gamer.FirstName + " " + gamer.LastName + " tarafından " + game.GamePrice + " tlye satın alındı.");
        }
    }
}
