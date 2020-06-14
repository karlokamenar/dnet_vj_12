using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace dnet_vj_12
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        List<Klub> sviKlubovi = new List<Klub>()
        {
            new Klub(1,"prvi", "Nogomet", "Hrvatska", 1900),
            new Klub(2,"drugi", "Rukomet", "Njemacka", 1901),
            new Klub(3,"treci", "Košarka", "Rusija", 1915),
            new Klub(4,"cetvrti", "Boks", "Turska", 1925),
            new Klub(12,"peti", "Vaterpolo", "Egipat", 1945),
        };
        public Klub DajKlub(string id)
        {
            try
            {
                int praviId = Int32.Parse(id);
                return sviKlubovi.Find(klub => klub.Id == praviId);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Id nije broj kakav očekujemo!");
            }
        }

        public List<Klub> DajSveKlubove()
        {
            return sviKlubovi;
        }
    }
}
