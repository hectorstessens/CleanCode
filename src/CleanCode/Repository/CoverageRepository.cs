using System.Collections.Generic;
using System.Threading.Tasks;
using CleanCode.Domain;

namespace CleanCode.Repository
{
    public class CoverageRepository : ICoverageRepository
    {
        public async Task<List<Coverage>> GetCoverageByBranch(int branch)
        {
            List<Coverage> listacoberturas = new List<Coverage>(); 
            // rama auto
            if (branch == 1) 
            {
                listacoberturas.Add(new Coverage() { Id = "1", CoverageName = "Responsabilidad Civil", Value = 1000000 });
                listacoberturas.Add(new Coverage() { Id = "1", CoverageName = "Granizo", Value = 150000 });

            }
            else if (branch == 2)
                listacoberturas.Add(new Coverage() { Id = "1", CoverageName = "Responsabilidad Civil", Value = 50000 });


            return listacoberturas;
        }
    }
}
