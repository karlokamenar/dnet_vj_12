using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Services;

namespace dnet_vj_12
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [WebGet(UriTemplate = "klub/{id}", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        Klub DajKlub(string id);

        [WebGet(UriTemplate = "sviKlubovi", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<Klub> DajSveKlubove();

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "dnet_vj_12.ContractType".
    [DataContract]
    public class Klub
    {
        public Klub(int id, string naziv, string sport, string drzava, int godinaosnivanja)
        {
            Id = id;
            Naziv = naziv;
            Sport = sport;
            Drzava = drzava;
            GodinaOsnivanja = godinaosnivanja;
        }


        [DataMember]
        public int Id;


        [DataMember]
        public string Naziv;


        [DataMember]
        public string Sport;


        [DataMember]
        public string Drzava;


        [DataMember]
        public int GodinaOsnivanja;

    }
}
