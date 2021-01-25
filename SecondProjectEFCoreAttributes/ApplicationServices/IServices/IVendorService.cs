using FirstProject.DTOs.Vendors;
using Microsoft.AspNetCore.JsonPatch;
using SecondProjectEFCoreAttributes.DTOs.Vendors;
using SecondProjectEFCoreAttributes.Models;

namespace SecondProjectEFCoreAttributes.ApplicationServices.IServices
{
    public interface IVendorService
    {
        Vendor GetVendorByIdForJsonPatchDoc(int id);
        VendorDTO GetVendorsById(int id);
        VendorInsertResponseDTO Insert(VendorInsertResponseDTO dto);
        bool Update(VendorUpdateDTO dto);
        bool Delete(int id);
        Vendor GetByIdForJsonPatch(JsonPatchDocument<VendorJsonPatchDTO> vendorPatch, int id);
        int SavePatchChanges(Vendor vendor);
    }
}
