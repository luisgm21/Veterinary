using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Models
{
    public interface IPetRepository
    {
        void AddPet(PetModel pet);
        void EditPet(PetModel pet);
        void DeletePet(int id);
        IEnumerable<PetModel> GetAlls();
        IEnumerable<PetModel> GetByValue(); // Searchs


    }
}
