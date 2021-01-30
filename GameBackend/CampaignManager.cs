using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class CampaignManager : ICampaignManagerService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine( campaign.CampaignName + " kampanyası eklendi. Geçerlilik süresi: " + campaign.CampaignValidationTime);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
