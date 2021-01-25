﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SecondProjectEFCoreAttributes.CustomAnnotation
{
    public class TagsIcollectionAnnotation : Attribute
    {
        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
        [Required]
        [MaxLength(128)]
        public string Value { get; set; }
    }
}
