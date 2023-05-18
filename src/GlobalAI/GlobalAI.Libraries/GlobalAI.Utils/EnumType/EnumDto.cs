﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalAI.Utils.EnumType
{
    public class EnumDto
    {
        public EnumDto()
        {

        }

        public EnumDto(string value, string name)
        {
            Value = value;
            Name = name;
        }

        public string Value { get; set; }
        public string Name { get; set; }
    }
}
