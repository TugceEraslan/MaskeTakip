using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService  // PersonManager sınıfında ki metodların imzasını tutuyor. Bunun sebebi de yazılımda ki bağımlılığı çözmek için
    {
        void ApplyForMask(Person person);
        List<Person> GetList();
        bool CheckPerson(Person person);  

    }
}
