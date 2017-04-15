﻿using System.ComponentModel.DataAnnotations;

namespace CHSAuction.Models
{
    public class ItemListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public int Value { get; set; }
        [Display(Name = "Minimum")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public int MinimumBid { get; set; }
        [Display(Name = "My Bid")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public int NewBid { get; set; }
        [Display(Name = "Highest")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public int HighestBid { get; set; }
        public int? UserId { get; set; }
    }
}