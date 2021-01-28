using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer 
            { Id = 1, 
                BirthYear = 1985, 
                FirstName = "ENGİN", 
                LastName = "DEMİROĞ", 
                IdentityNumber = 12345 
            });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign 
            { Id = 1, 
                CampaignName = "Black Friday" 
            });
            OrderManager orderManager = new OrderManager(new CampaignManager());
            orderManager.Order(new Campaign { CampaignName = "Black Friday" });

            

        }
    }
}
