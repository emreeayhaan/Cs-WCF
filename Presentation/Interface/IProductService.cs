using Data.Database;
using Data.Dto;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Presentation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Presentation.Interface
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void AddProduct(ProductDto product);
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void DelProduct(ProductDto delProduct);
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void UpdateProduct(ProductDto upProduct);
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        void GetProduct(int ProductId);
    }
}
