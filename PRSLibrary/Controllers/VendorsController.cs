using PRSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRSLibrary.Controllers {
    public class VendorsController {

        private readonly PrsDbContext _context;

        public VendorsController(PrsDbContext context) {
            this._context = context;

        }

        public IEnumerable<Vendor> GetAll() {
            return _context.Vendors.ToList();
        }

        public Vendor GetbyPk(int id) {
            return _context.Vendors.Find(id);
        }

        public Vendor Create(Vendor vendor) {
            if(vendor is null) {
                throw new ArgumentNullException("vendor");
            }
            if (vendor.Id != 0) {
                throw new ArgumentException("Vendor.Id must be zero!");
            }
            _context.Vendors.Add(vendor);
            _context.SaveChanges();
            return vendor;

        }

        public void Remove(int id) {
            var vendor = _context.Vendors.Find(id);
            if(vendor is null) {
                throw new Exception("Vendor not found!");
            }
            _context.Vendors.Remove(vendor);
            _context.SaveChanges();
        }
        
    }

}
