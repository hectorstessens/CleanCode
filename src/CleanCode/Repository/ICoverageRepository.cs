using CleanCode.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanCode.Repository
{
    public interface ICoverageRepository
    {
        Task<List<Coverage>> GetCoverageByBranch(string branch);
    }
}
