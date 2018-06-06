using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommented
{
    public class Similarity
    {
        public int item { get; set; }
        public float similarity { get; set; }
        public Similarity() { }
        public Similarity(int Item, float Similarit)
        {
            this.item = Item;
            this.similarity = Similarit;
        }
        
    }
}
