using SecondProjectEFCoreAttributes.DTOs.Tags;
using System;

namespace SecondProjectEFCoreAttributes.DTOs.Vendors
{
    public class VendorUpdateDTO
    {
        public VendorUpdateDTO()
        {
            Tags = new TagDTO();            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public TagDTO Tags { get; set; }
    }
}
