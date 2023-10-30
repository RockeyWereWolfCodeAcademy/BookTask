using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public abstract class Product
    {
        protected static uint _id = 0;
        public uint Id { get => _id; }

        public string Name { get; set; }
        public uint Price { get; set; }
        protected uint Count { get; set; }
        protected static uint TotalInCome { get; set; }
        public abstract void Sell();
        public abstract void ShowInfo();
    }
}
