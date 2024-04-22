using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.PttManager
{
    public class PttManager: ISupplierService
    {// Bir business sınıfı başka bir business (veri erişim sınıfını)
     //kullanırken new kullanıyorsa ileriye dönük değişikliklere direnç gösterir. Mesela bu örnekte devlet dedi ki ben bundan sonra
     // kendi vatandaşım olmayana da maske vereceğim. Bu noktada ptt bu maskeyi verecek ve bu person olan vatandaş idi. Ve bu sitem
     //Tamamen vatandaşa bağımlı!! : 
     //public void GiveMask(Person person)
     //{
     //    PersonManager personManager = new PersonManager(); //#LANOL-MAZZZZ!
     //    if (personManager.CheckPerson(person))
     //    {
     //        Console.WriteLine(person.FirstName + "için maske verildi!");
     //    }


        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi!");
            } 

            
        }
    }
}