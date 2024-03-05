//using DataAccess.Abstract;
//using Entity.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccess.Concrete.InMemory
//{
//    public class InMemoryProductDal : IProductDal
//    {
//        List<Product> _products;

//        public InMemoryProductDal()
//        {
//            _products = new List<Product>
//            {
//                new Product{ProductID=1, CategoryID=1, ProductName="Kalem", UnitsInStock=5},
//                new Product{ProductID=2, CategoryID=1, ProductName="Silgi", UnitsInStock=10},
//                new Product{ProductID=3, CategoryID=1, ProductName="Defter", UnitsInStock=10},
//                new Product {ProductID=4, CategoryID=2, ProductName="Klavye", UnitsInStock=15},
//                new Product{ProductID=5, CategoryID=2, ProductName="Fare", UnitsInStock=15}
//            };
//        }

//        public void Add(Product product)
//        {
//            _products.Add(product);
//        }

//        public void Delete(Product product)
//        {
//            Product productToDelete= _products.SingleOrDefault(p=> p.ProductID==product.ProductID);
//            _products.Remove(productToDelete);
//        }

//        public Product Get(Expression<Func<Product, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Product> GetAll()
//        {
//            return _products;
//        }

//        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Product> GetAllByCategory(int categoryId)
//        {
//            return _products.Where(p => p.CategoryID == categoryId).ToList();
//        }

//        public void Update(Product product)
//        {
//            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
//            productToUpdate.ProductID = product.ProductID;
//            productToUpdate.ProductName = product.ProductName;
//            productToUpdate.CategoryID = product.CategoryID;
//            productToUpdate.UnitsInStock = product.UnitsInStock;
//        }
//    }
//}
