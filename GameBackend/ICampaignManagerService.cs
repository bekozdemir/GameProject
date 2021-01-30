using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    interface ICampaignManagerService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
