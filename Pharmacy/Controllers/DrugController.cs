using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Models;
using Pharmacy.Services;

namespace Pharmacy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DrugController : ControllerBase
    {
        private readonly DrugService _drugService = null;
        
        public DrugController(DrugService drugService)
        {
            _drugService = drugService;
        }
        
        [HttpGet]
        public IEnumerable<Drug> GetAllDrugs()
        {
            var drugs = _drugService.GetAll();
            return drugs;
        }
        
        [HttpGet("{id}")]
        public Drug GetDrug(int id)
        {
            var drug = _drugService.Get(id);
            return drug;
        }

        [HttpPost]
        public Drug CreateDrug([FromBody] Drug drug)
        {
            var currentDrug = _drugService.Create(drug);
            return currentDrug;
        }
        
        [HttpPatch]
        public Drug UpdateDrug([FromBody] Drug drug)
        {
            var currentDrug = _drugService.Update(drug);
            return currentDrug;
        }
        
        [HttpDelete("{id}")]
        public bool DeleteDrug(int id)
        {
            _drugService.Delete(id);
            return true;
        }
    }
}