﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeridianAPI.Models
{
    public class MicroService
    {
        public string Token { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public bool IsAlive { get; set; }
        public List<String> APIPaths { get; set; }

    }
}
