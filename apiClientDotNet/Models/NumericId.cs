﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace apiClientDotNet.Models
{
    public class NumericId
    {
    
        [JsonProperty("id")]
        public long id { get; set; }
    }
}
