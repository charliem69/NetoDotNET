﻿using NetoDotNET.Entities;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Categories
{
    public class AddCategoryResponse : NetoResponseBase
    {
        [JsonProperty("Category")]
        [JsonConverter(typeof(SingleOrArrayConverter<AddedCategory>))]
        public List<AddedCategory> Category { get; private set; }
    }
}
