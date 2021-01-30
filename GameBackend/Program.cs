using System;

namespace GameBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1996, FirstName = "BERKAY", LastName = "ÖZDEMİR", IdentityNumber = 12345 });

            GameSaleManager gameSaleManager = new GameSaleManager(new CampaignManager());
            gameSaleManager.Sell(new GameSale { GameName = "xxxx", GamePrice = 10 },
                new Gamer { FirstName = "BERKAY", LastName = "ÖZDEMİR" },
                new Campaign { CampaignName = "ocakindirimleri", CampaignValidationTime = 30 });
        }
    }
}
