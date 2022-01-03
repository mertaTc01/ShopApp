using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using ShopApp.Entities;

namespace ShopApp.DataAccess.Abstract
{
    public interface ICategoryDal
    {
        Category GetById(int Id);
        Category GatOne(Expression<Func<Category, bool>> filter);
        IQueryable<Category> GetAll(Expression<Func<Category, bool>> filter);

        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
    }
}
