using Data.Database;
using Data.Dto;
using DataAccess.RepositoryPattern;
using DataAccess.UnitOfWorkPatten;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Presentation.Interface;
using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;

namespace Presentation.Services
{

    public class ProductService : IProductService
    {
        public void AddProduct(ProductDto product)
        {
            if (product == null)
            {
                HttpWebRequest myReq =
               (HttpWebRequest)WebRequest.Create("http://localhost:50874/ProductService/AddProduct");
                
                   
                //return HttpStatusCode.Gone.ToString();
                // 400 Bad Request dön


            }

            using (UnitOfWorkPattern<bnetEntities> uow = new DataAccess.UnitOfWorkPatten.UnitOfWorkPattern<bnetEntities>(new bnetEntities()))
            {
                var de = uow.RepositoryPattern<product>().GetAll();
            }

            // UnitOfWorkPattern unitOfWorkPattern = new UnitOfWorkPattern(new bnetEntities1);
            //  unitOfWorkPattern.GetRepository<product>().Add();
            //  unitOfWorkPattern.GetRepository<customer>().Add();

            //RepositoryPattern product = new DataAccess.RepositoryPattern.RepositoryPattern(product);
            //product.GetAll();
            //RepositoryPattern customer = new...





            /// <summary>
            /// METOTUN içinde using nasıl kullamılıyo ve using i unit of work e bağla
            /// </summary>
            throw new NotImplementedException();
        }

        public void DelProduct(ProductDto delProduct)
        {
            Console.WriteLine("deneme1234");
            throw new NotImplementedException();
        }

        public void GetProduct(int ProductId)
        {
            Console.WriteLine("deneme12345");
            throw new NotImplementedException();
        }

        public void UpdateProduct(ProductDto upProduct)
        {
            Console.WriteLine("deneme123456");
            throw new NotImplementedException();
        }
    }
}
