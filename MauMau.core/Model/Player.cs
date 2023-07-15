using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauMau.core.Model
{
    public class Player
    {

        public Player(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public Cards Hand { get;  } = new Cards();
    }
}
