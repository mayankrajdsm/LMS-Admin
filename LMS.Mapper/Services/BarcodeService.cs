using LMS.Infrastructures.Interface;
using LMS.Mapper.BusinessObject;
using LMS.Mapper.ConversionHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.Services
{
    public class BarcodeService
    {
        private readonly IBarcodeRepository _barcodeRepository;
        public BarcodeService(IBarcodeRepository barcodeRepository) => _barcodeRepository = barcodeRepository;
        public async Task<List<Barcode>> GetBarcodes()
        {
            List<Barcode> barcodes = new List<Barcode>();
            var existingBarcodes = await _barcodeRepository.GetBarcodes();
            if (barcodes != null)
            {
                foreach (var barcode in existingBarcodes)
                {
                    barcodes.Add(barcode.ToBusinessObject());
                }
            }
            return barcodes;
        }
    }
}
