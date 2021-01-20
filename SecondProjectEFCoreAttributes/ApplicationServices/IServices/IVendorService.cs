using SecondProjectEFCoreAttributes.DTOs.Vendors;

namespace SecondProjectEFCoreAttributes.ApplicationServices.IServices
{
    public interface IVendorService
    {
        VendorDTO GetAll(int id);
        bool Insert(VendorInsertDTO dto);
        bool Update(VendorUpdateDTO dto);
        bool Delete(int id);
        bool Patch(int id);
        VendorDTO GetByIdForPatch(int id);
    }
}
