using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Dtos.Basket
{
    public class BasketDto
    {
        public int Id { get; set; }
        public string BuyerId { get; set; }
        public List<BasketItemDto> Items { get; set; }
    }
}