﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidFire
{
    public class Shortcut
    {
        public string Keys { get; set; }
        public string NodeName { get; set; }

        public Shortcut(string key, string name)
        {
            Keys = key;
            NodeName = name;
        }
    }
}
