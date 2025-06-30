using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using BulkyWeb.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class CompanyRepository:Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
            //Company companyFromDb = _db.Companies.FirstOrDefault(u => u.Id == obj.Id);
            //if (companyFromDb != null) { 
            //    companyFromDb.Name = obj.Name;
            //    companyFromDb.StreetAddress = obj.StreetAddress;
            //    companyFromDb.City = obj.City;
            //    companyFromDb.State = obj.State;
            //    companyFromDb.PostalCode = obj.PostalCode;
            //    companyFromDb.PhoneNumber = obj.PhoneNumber;
            //}
        }
    }
}
