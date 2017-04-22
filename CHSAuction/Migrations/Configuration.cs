namespace CHSAuction.Migrations
{
    using CHSAuction.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CHSAuction.Models.AuctionDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "CHSAuction.Models.AuctionDb";
        }

        protected override void Seed(CHSAuction.Models.AuctionDb context)
        {
            context.Items.AddOrUpdate(
                r => r.Name,
                new Item
                {
                    Name = "Fist Item",
                    Description = "First Description...",
                    Image = "1.jpg",
                    Value = 42,
                    MinimumBid = 43,
                    Bids = new List<ItemBid> { 
                        new ItemBid { Bid = 44, ItemId = 1, UserId = 1}
                     }
                });
        }
    }
}
