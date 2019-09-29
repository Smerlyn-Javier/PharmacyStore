using System;
using System.Collections.Generic;
using System.Linq;
using Pharmacy.Models;

namespace Pharmacy.Repositories
{
    public class DrugRepository
    {
        private readonly DataContext _context = null;
        
        public DrugRepository(DataContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<Drug> GetAll()
        {
            return _context.Drugs.ToList();
        }

        public Drug Get(int id)
        {
            return _context.Drugs.FirstOrDefault(drug => drug.Id == id);
        }

        public Drug Create(Drug drug)
        {
            _context.Drugs.Add(drug);
            _context.SaveChanges();
            return drug;
        }

        public Drug Update(Drug drug)
        {
            _context.Drugs.Update(drug);
            _context.SaveChanges();
            return drug;
        }


        public bool Delete(int id)
        {
            var currentDrug = Get(id);
            _context.Remove(currentDrug);
            _context.SaveChanges();
            return true;
        }
    }
}