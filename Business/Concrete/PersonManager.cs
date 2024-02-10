using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // Çıplak class kalmasın

    // PersonManager benim için vatantaşa maske verdiğim bir ortam sunuyor olmalı. Bu sınıf sadece operasyon tutmalıdır
    public class PersonManager : IApplicantService  
    {
        // Person class ında person a ait özellikleri tutma durumuna encapsulation denir
        public void ApplyForMask(Person person)  // Maske için başvur.Buna kim başvuracak Person parametre olarakta person
        {


        }

        // List<Person> dediğimiz yapı içerisnde verdiğimiz tipte yani (Person) un Liste şeklinde tutulmasını sağlar
        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)  // CheckPerson metodu bu kişi vatandaş mı bunun kontrolünü yapacak. 
        {
            // Mernis'e bağlanıp kontrol edecek. Mernis kontrolü yapılacak

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            //return client.TCKimlikNoDogrulaAsync(
            //    new TCKimlikNoDogrulaRequest
            //    (new TCKimlikNoDogrulaRequestBody(123,"TUĞÇE","ERASLAN",1995)))
            //    .Result.Body.TCKimlikNoDogrulaResult;  // Bana bir tane client üzerinden TCKimlikNoDogrulaRequest i geç şeklinde istekte bulunuyor. Parametresi bu

            return client.TCKimlikNoDogrulaAsync(
             new TCKimlikNoDogrulaRequest
             (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthYear)))
             .Result.Body.TCKimlikNoDogrulaResult;  // Bana bir tane client üzerinden TCKimlikNoDogrulaRequest i geç şeklinde istekte bulunuyor. Parametresi bu
        }
    }
}
