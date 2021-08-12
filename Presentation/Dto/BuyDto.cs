using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dto
{

    /// <summary>
    ///Kullanıcının bilgilerini(BHid,ProductName,Price,Count,CustomerId ve ProductId)görüntülemek ve kullanmak için oluşturduğumuz DTO class'ı. 
    /// </summary>
    public class BuyDto
    {
        public int BHid { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
    }
}
