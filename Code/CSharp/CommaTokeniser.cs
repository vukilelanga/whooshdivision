﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityProvider
{
    class CommaTokeniser: Tokeniser
    {
        public CommaTokeniser()
        {
            separatorCharacter = ',';
        }

        public override string[] tokenise(string line)
        {
            if (line == null) throw new NullReferenceException();

            string[] toBeReturned = line.Split(separatorCharacter);
            return toBeReturned;
        }
    }
}
