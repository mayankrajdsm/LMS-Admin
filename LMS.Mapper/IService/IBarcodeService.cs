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
        Task<List<Barcode>> GetBarcodes();
        Task<int> InsertBarcode(Barcode barcode);
    }
}
