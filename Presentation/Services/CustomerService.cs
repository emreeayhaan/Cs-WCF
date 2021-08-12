using Data.Dto;
using Presentation.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;

namespace Presentation.Services
{
    public class CustomerService : ICustomerService
    {
        //try cacth blokları kullanılarak hata mesajları mesaj ve status code ile geri dönüşler sağla.

        public void AddCustomerService(CustomerDto customerService)
        {
            
            try
            {
                Console.WriteLine("deneme");
             
            }
            catch (Exception)
            {
                Console.WriteLine("error");
                throw;
            }
        }
        public void DelCustomerService(CustomerDto deleteCustomerService)
        {
            try
            {
              
                Console.WriteLine("deneme1");

            }
            catch (Exception)
            {
                Console.WriteLine("error");
                throw;

            }
        }
        //attribute'u sadec get e yazcaksın eğer attribute den geçerse bütün customerlar gelcek
        public void GetCustomerService(int getcustomerService)
        {
            throw new NotImplementedException();
        }

        public void UpCustomerService(CustomerDto updateCutomerService)
        {
            try
            {
                Console.WriteLine("deneme12");

            }
            catch (Exception ex)
            {
                Console.WriteLine("error");
                Console.WriteLine(ex.Message);//hatanın ne olduğunu geri bildirim atar
                throw;
            }
        }
    }
}