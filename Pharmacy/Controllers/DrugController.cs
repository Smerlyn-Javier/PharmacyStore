using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Models;

namespace Pharmacy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DrugController
    {
        private readonly DataContext _context = null;
        
        public DrugController(DataContext ctx)
        {
            _context = ctx;
        }
        
        [HttpGet]
        public IEnumerable<Drug> Get()
        {
            var drugs = _context.Drugs.ToList();
            return drugs;
        }

        [HttpPost]
        public IEnumerable<Drug> Post()
        {
            var drugs = _context.Drugs.ToList();
            return drugs;
        }
        
        
    }
}