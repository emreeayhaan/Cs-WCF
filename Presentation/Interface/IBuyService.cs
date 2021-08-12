using Data.Dto;
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

    public interface IBuyService
    {

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "AddBuyService")]
        void AddBuyService(BuyDto buyService);
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "DelBuyService")]
        void DelBuyService(BuyDto delbuyService);
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "UpBuyService")]
        void UpBuyService(BuyDto upbuyService);
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST ", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetBuyService")]
        void GetBuyService(BuyDto GetbuyService);

    }
}
