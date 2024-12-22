using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IBarcodeService
    {
        Task<IEnumerable<Barcode>> GetBarcodes();
        Task<Barcode> GetBarcodeById(Guid bookingId);
        Task<int> InsertBarcode(Barcode barcode);
        Task<int> DeleteBarcode(Guid bookingId);
    }
}