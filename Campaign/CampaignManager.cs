using System;
using System.Collections.Generic;
using System.Text;

namespace Campaign
{
    class CampaignManager : ICampaignManager
    {
        public void Add(CampaignS campaign)
        {
            Console.WriteLine("Here it is, the 'New Campaign!' ");
        }

        public void Delete(CampaignS campaign)
        {
            Console.WriteLine("Sorry :( The campaign is gone for now.");
        }

        public void Update(CampaignS campaign)
        {
            Console.WriteLine("There's an improvement the campaign!");
        }
    }
}
