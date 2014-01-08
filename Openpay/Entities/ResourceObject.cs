﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Openpay.Entities
{
    public class ResourceObject : OpenpayObject
    {
        [JsonProperty(PropertyName = "id")]
        public String Id { get; set; }
    }
}
