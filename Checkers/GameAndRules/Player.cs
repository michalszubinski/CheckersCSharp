using Checkers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.GameAndRules
{
    internal abstract class Player
    {
        internal int teamId;
        internal string inputType;
        internal string name;

        internal virtual Move getMove()
        {
            return null;
        }
    }    
}
