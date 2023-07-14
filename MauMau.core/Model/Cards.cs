using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauMau.core.Model
{
    public class Cards : List<Card>
    {

        public void Shuffle()
        {

            Random random = new Random();
            for (int i = 0; i < Count; i++)
            {
                int RandomIndex = random.Next(Count);
                Card temp = this[i];
                this[i] = this[RandomIndex];
                this[RandomIndex] = temp;
            }

        }


    }
}
