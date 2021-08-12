using Data.Dto;
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
    //CUSTOMER: 
    //POST : CustomerService.svc/AddCustomer : (SaveCustomerDto) almalıdır.EF sınıfına(customer) dönüştürülüp kayıt edilmelidir. 
    //DELETE: CustomerService.svc/DeleteCustomer: (DeleteCustomerDto) almalı ve EF ile veritabanından silinmelidir.
    //PUT: CustomerService.svc/UpdateCustomer: (UpdateCustomerDto) almalı ve EF ile veritabanından güncellemelidir.
    //GET : CustomerService.svc/GetCustomer Auth Key verilip tüm customerları çekebilmelidir. AUTHANTICATION kullan.
    [ServiceContract]

    public interface ICustomerService
    {

        [OperationContract]//metotları bu sözleşmede belirtyoruz.
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "AddCustomerService")]
        void AddCustomerService(CustomerDto customerService);
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "DeleteCustomerService")]
        void DelCustomerService(CustomerDto deleteCustomerService);
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "UpdateCustomerService")]
        void UpCustomerService(CustomerDto updateCutomerService);
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetCustomerService")]
        //auth key verilip tüm customerlar çekilmelidir
        void GetCustomerService(int CustomerDto);
    }
}
