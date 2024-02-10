using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicantService;  // Bunlar field aslında. Daha önce yaptığımız string ad; gibi

        public PttManager(IApplicantService applicantService) // Constructor class ı hazırlıyoruz . Class oluştuğunda new yapıldığında(PttManager dan  bahsediyoruz) bu blok önce çalışır
        {
            // Ben IApplicantService e bağımlıyım. Beni oluşturduğun zaman bana parametre olarak 1 tane aday servis ver o da applicantService i verdi
            _applicantService = applicantService;  // Class larda field ların alt çizgiyle başlama sebebi budur.
            // Çünkü Constructor içerisinde onu set ederiz.  _applicantService = applicantService; burada olduğu gibi 
        }


        public void GiveMask(Person person)  // Ptt  maskeyi dağıtan kişi
        {
            // Maskeyi vermem için PersonManager dan bir operasyonu çağırmam gerekiyor
            // PttManager ın PersonManager a ihtiyacı var


            /*
            PersonManager personManager = new PersonManager();  // new lediysen bağımlıyımdır.
            // Bu bağımlılığı kaldırmak için tasarım desenlerinden Dependecy Injection yapmalıyım
            Yani artık bağımlı olduğu sını değilde üstte kodda o sınıfların interface'ini kullanacağım
            */
           /* if(personManager.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
           */
           if(_applicantService.CheckPerson(person)) 
            { 
                Console.WriteLine(person.FirstName + " için maske verildi" );
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
            }
        }
    }
}
