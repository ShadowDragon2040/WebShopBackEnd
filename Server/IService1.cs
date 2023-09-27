using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Server.Iservices;
using Server.Models;

namespace Server
{
    [ServiceContract]
    public interface IService1 : IFelhasznalokService
    {

    }
}
