using SecondProjectEFCoreAttributes.DTOs.Tags;
using System;
using System.Collections.Generic;

namespace SecondProjectEFCoreAttributes.DTOs.Vendors
{
    public class VendorDTO
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public ICollection<TagDTO> Tags { get; set; }
        //public TagDTO Tag { get; set; }

    }
}
