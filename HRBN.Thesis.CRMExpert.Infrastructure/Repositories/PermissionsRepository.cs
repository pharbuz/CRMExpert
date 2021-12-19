using System;
using System.Threading.Tasks;
using HRBN.Thesis.CRMExpert.Domain;
using HRBN.Thesis.CRMExpert.Domain.Core.Entities;
using HRBN.Thesis.CRMExpert.Domain.Core.Enums;
using HRBN.Thesis.CRMExpert.Domain.Core.Pagination;
using HRBN.Thesis.CRMExpert.Domain.Core.Repositories;

namespace HRBN.Thesis.CRMExpert.Infrastructure.Repositories;

public class PermissionsRepository : IPermissionsRepository
{
    private readonly CRMContext _dbContext;

    public PermissionsRepository(CRMContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public Task<Permission> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Permission entity)
    {
        throw new NotImplementedException();
    }

    public Task<IPageResult<Permission>> SearchAsync(string searchPhrase, int pageNumber, int pageSize, string orderBy, SortDirection sortDirection)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Permission entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Permission entity)
    {
        throw new NotImplementedException();
    }
}