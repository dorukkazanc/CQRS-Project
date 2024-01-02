﻿using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create
{
    public class CreateBrandCommand: IRequest<CreatedBrandResponse>
    {
        public string Name { get; set; }

        public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
        {
            public async Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
            {
                CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
                createdBrandResponse.Id = Guid.NewGuid();
                createdBrandResponse.Name = request.Name;
                return await Task.FromResult(createdBrandResponse);
            }
        }
    }
}