﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Models.DTO
{
    public class UpdateCategoryRequestDto
    {
        public string Name { get; set; }
        public string UrlHandle { get; set; }
    }
}
