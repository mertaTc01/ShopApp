﻿using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace ShopApp.DataAccess.Abstract
{
    public interface IProductDal
    {
        Product GetById(int Id);
        Product GatOne(Expression<Func<Product, bool>> filter);
        IQueryable <Product> GetAll(Expression<Func<Product, bool>> filter);

        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);


    }
}
