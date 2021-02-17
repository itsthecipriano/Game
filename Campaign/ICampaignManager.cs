using System;
using System.Collections.Generic;
using System.Text;

namespace Campaign
{
    interface ICampaignManager
    {
        void Add(CampaignS campaign);
        void Update(CampaignS campaign);
        void Delete(CampaignS campaign);
    }
}
