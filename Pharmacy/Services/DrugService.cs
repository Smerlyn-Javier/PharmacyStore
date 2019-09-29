using System.Collections.Generic;
using Pharmacy.Models;
using Pharmacy.Repositories;

namespace Pharmacy.Services
{
    public class DrugService
    {
        private readonly DrugRepository _drugRepository = null;
        
        public DrugService(DrugRepository repository)
        {
            _drugRepository = repository;
        }

        public IEnumerable<Drug> GetAll()
        {
            return _drugRepository.GetAll();
        }

        public Drug Get(int id)
        {
            return _drugRepository.Get(id);
        }

        public Drug Create(Drug drug)
        {
            return _drugRepository.Create(drug);
        }

        public Drug Update(Drug drug)
        {
            return _drugRepository.Update(drug);
        }


        public bool Delete(int id)
        {
            return _drugRepository.Delete(id);
        }
    }
}