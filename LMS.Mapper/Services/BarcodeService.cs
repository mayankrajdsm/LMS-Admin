using LMS.Infrastructures.Interface;
using LMS.Mapper.BusinessObject;
using LMS.Mapper.ConversionHelper;
using LMS.Mapper.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.Services
{
    public class BarcodeService : IBarcodeService
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
        public async Task<Barcode> GetBarcodeById(string bookingId)
        {
            var barcode = await _barcodeRepository.GetBarcodeById(Guid.Parse(bookingId));
            return barcode.ToBusinessObject();
        }
        public async Task<int> InsertBarcode(Barcode barcode) => await _barcodeRepository.InsertBarcode(barcode.ToEntityModel());
        public async Task<int> DeleteBarcode(string bookingId) => await _barcodeRepository.DeleteBarcode(Guid.Parse(bookingId));
    }
}
