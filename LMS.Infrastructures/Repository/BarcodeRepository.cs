using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Repository
{
    public class BarcodeRepository: IBarcodeRepository
    {
        private readonly TestContext _context;
        public BarcodeRepository(TestContext context) => _context = context;
        public async Task<IEnumerable<Barcode>> GetBarcodes() => await _context.Barcodes.ToListAsync();
        public async Task<Barcode> GetBarcodeById(Guid barcodeId) => await _context.Barcodes.FindAsync(barcodeId);
        public async Task<int> InsertBarcode(Barcode barcode)
        {
            _context.Barcodes.Add(barcode);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> DeleteBarcode(Guid barcodeId)
        {
            var barcode = await _context.Barcodes.FindAsync(barcodeId);
            _context.Barcodes.Remove(barcode);
            return await _context.SaveChangesAsync();
        }
    }
}
