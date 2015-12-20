using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebAPI.Models;

namespace API
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        Users GetUser(string username, string password);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        Roles GetRoles(string userId);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        Addresses GetAddress(string userId);


        //[OperationContract]
        //[WebGet(ResponseFormat = WebMessageFormat.Json)]
        //Users GetUserRest(string username, string password);

        //[OperationContract]
        //[WebGet(ResponseFormat = WebMessageFormat.Json)]
        //Roles GetRolesRest(string userId);

        //[OperationContract]
        //[WebGet(ResponseFormat = WebMessageFormat.Json)]
        //Addresses GetAddressRest(string userId);


    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
   
   
}
