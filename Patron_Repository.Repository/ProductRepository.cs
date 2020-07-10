using Patron_Repository.Data;
using Patron_Repository.Data.Models;
using Patron_Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Repository.Repository
{
    public class ProductRepository : BaseRepository<Products>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context){
        }
    }
}
