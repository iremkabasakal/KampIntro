using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        ICampaignService _campaignService;

        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void Add(Gamer gamer)
        {
            
            Console.WriteLine("Sipariş alındı");
        }

        public void Order(Gamer gamer)
        {
            if (_campaignService(Add)="Black Friday"
           
            Console.WriteLine(gamer.FirstName);
        }
}
