﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GDFSYSTEMS.Models.WebApi
{
   public class PostModel
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
