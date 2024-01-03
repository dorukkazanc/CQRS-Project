using Application.Features.Brands.Commands.Create;
using Core.Persistence.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Repositories
{
    public interface IBrandRepository : IAsyncRepository<Brand, Guid>, IRepository<Brand, Guid>
    {
        Task<CreatedBrandResponse> Create(CreateBrandCommand createBrandCommand);

    }
}
