using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository :IRepository<Category>
    {
        //It will now have al the base functionality from IRepository additionally it will have the below methods
        void Update(Category obj);
        //void Save();
    }
}
