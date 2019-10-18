using System.Collections.Generic;
using System.Threading.Tasks;
using CleanCode.Domain;

namespace CleanCode.Repository
{
    public class CoverageRepository : ICoverageRepository
    {
        public async Task<List<Coverage>> GetCoverageByBranch(string branch)
        {
            List<Coverage> listacoberturas = new List<Coverage>(); 
            // rama auto
            if (branch == "auto") 
            {
                listacoberturas.Add(new Coverage() { Id = "1", CoverageName = "Responsabilidad Civil", Value = 100000 });
                listacoberturas.Add(new Coverage() { Id = "2", CoverageName = "Granizo", Value = 50000 });

            }
            else if (branch == "motos")
                listacoberturas.Add(new Coverage() { Id = "1", CoverageName = "Responsabilidad Civil", Value = 100000 });
            else if (branch == "hogar") { 
                listacoberturas.Add(new Coverage() { Id = "3", CoverageName = "Incendio", Value = 2000000 });
                listacoberturas.Add(new Coverage() { Id = "4", CoverageName = "Electrodomesticos", Value = 100000 });

            }

            return listacoberturas;
        }
    }
}
