using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using SecondProjectEFCoreAttributes.ApplicationServices.IServices;
using SecondProjectEFCoreAttributes.DTOs.Vendors;

namespace SecondProjectEFCoreAttributes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorsController : ControllerBase
    {
        private readonly IVendorService _vendorService;

        public VendorsController(IVendorService vendorService)
        {
            _vendorService = vendorService;
        }
        [HttpGet("{id}")]
        public IActionResult GetVendors([FromRoute] int id)
        {
            var result = _vendorService.GetAll(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult InsertVendor([FromBody] VendorInsertDTO dto)
        {
            var result = _vendorService.Insert(dto);

            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public IActionResult UpdateVendor(VendorUpdateDTO dto)
        {
            var result = _vendorService.Update(dto);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }       
        [HttpPatch("{id}")]
        public StatusCodeResult PatchVendor([FromBody] JsonPatchDocument<VendorDTO> patch, [FromRoute] int id)
        {
            VendorDTO res = _vendorService.GetByIdForPatch(id);
            if (res != null)
            {
                patch.ApplyTo(res);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVendor([FromRoute] int id)
        {
            var result = _vendorService.Delete(id);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
