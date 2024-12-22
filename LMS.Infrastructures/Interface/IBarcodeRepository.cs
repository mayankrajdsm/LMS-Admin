using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IBarcodeRepository
    {
        Task<IEnumerable<Barcode>> GetBarcodes();
        Task<Barcode> GetBarcodeById(Guid barcodeId);
        Task<int> InsertBarcode(Barcode barcode);
        Task<int> DeleteBarcode(Guid barcodeId);
    }
}
