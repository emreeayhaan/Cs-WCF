using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dto
{
    //Kullanıcının bilgilerini(ID,username,password ve mail)görüntülemek ve kullanmak için oluşturduğumuz DTO class'ı.
     public class CustomerDto 
    {
        public int IdCostumer { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public string Mail { get; set; }
    }
}
