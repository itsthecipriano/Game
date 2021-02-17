using System;

namespace Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new CampaignS { CampaignId = 2, CampaignName = "You'll Regret It If You Miss This Campaign", DeadlineOfTheCampaign = "10.03.2021" });
        }
    }
}
