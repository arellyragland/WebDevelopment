﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface IPizza
    {
        public string[] ingredients { get; set; }
        public StringBuilder Prepare();
        public string AddToppings();
    }
}
