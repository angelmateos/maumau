using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauMau.core
{
    public class Cards: List<Card>
    {

        public void Shuffle() 
        { 
        
            Random random = new Random();
            for (int i = 0;i<this.Count;i++)
            {
                int RandomIndex = random.Next(this.Count);
                Card temp = this[i];
                this[i] = this[RandomIndex];
                this[RandomIndex] = temp;
            }
        
        }
        

    }
}
