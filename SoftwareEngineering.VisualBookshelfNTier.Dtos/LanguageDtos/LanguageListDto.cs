﻿using SoftwareEngineering.VisualBookshelfNTier.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Dtos
{
    public class LanguageListDto : IDto
    {
        public int Id { get; set; }

        public string LanguageDefinition { get; set; }
    }
}
