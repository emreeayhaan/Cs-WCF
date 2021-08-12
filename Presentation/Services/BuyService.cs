using Data.Dto;
using Presentation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentation.Services
{
    //BuyService
    //POST : BuyService.svc/AddSales : (SaveSalesDto) almalıdır.  EF sınıfına(product) dönüştürülüp kayıt edilmelidir. 
    //DELETE: BuyService.svc/DeleteSales: (DeleteSalesDto) almalı ve EF ile veritabanından silinmelidir.
    //PUT: BuyService.svc/UpdateSales: (UpdateSalesDto) almalı ve EF ile veritabanından güncellemelidir.
    //GET : BuyService.svc/GetSales SearchSalesDto alınıp satışlar çekilmelidir.
    public class BuyService : IBuyService
    {
        public void AddBuyService(BuyDto buyService)
        {
            try
            {
                Console.WriteLine("deneme");
                throw new NotImplementedException();
            }
            catch(NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message , ex.StackTrace);
            }

        }

        public void DelBuyService(BuyDto delbuyService)
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

        public void GetBuyService(BuyDto GetbuyService)
        {
            try
            {

                Console.WriteLine("deneme2");
            }
            catch (Exception)
            {

                Console.WriteLine("error");
                throw;
            }
          
        }

        public void UpBuyService(BuyDto upbuyService)
        {
            try
            {

                Console.WriteLine("deneme3");
            }
            catch (Exception)
            {

                Console.WriteLine("error");
                throw;
            }
           
        }
    }
}