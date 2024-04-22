using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        //public void ApplyForMask(string Name, string LastNamei) => bunu böyle de yazabilirdik ama bu hiç iyi bir yol değil
        //{
        //}

        //Encapsulation
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList() // List dediğimiz yapı, içerisinde verdiğimiz tipte bir listedir.
        {
            return null;
        
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(TCKimlikNoDogrulaRequestBody(123, "NAZAN", "DENİZ", 1996))).Result.Body.TCKimlikNoDogrulaResult;

        }

        private TCKimlikNoDogrulaRequestBody TCKimlikNoDogrulaRequestBody(int v1, string v2, string v3, int v4)
        {
            throw new NotImplementedException();
        }

        bool IApplicantService.ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        List<Person> IApplicantService.GetList()
        {
            throw new NotImplementedException();
        }

        bool IApplicantService.CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
