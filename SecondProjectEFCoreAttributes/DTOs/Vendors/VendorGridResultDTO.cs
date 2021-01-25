using SecondProjectEFCoreAttributes.CustomAnnotation;
using System.Collections.Generic;

namespace SecondProjectEFCoreAttributes.DTOs.Vendors
{
    public class VendorGridResultDTO
    {
        public VendorGridResultDTO(ICollection<VendorDTO> vendorDTOs)
        {
            VendorDTOs = vendorDTOs;
        }
        [TagsIcollectionAnnotation]
        public ICollection<VendorDTO> VendorDTOs { get; set; }
    }
}
