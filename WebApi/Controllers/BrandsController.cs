using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Queries.GetList;
using Core.Application.Requests;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBrandCommand createBrandCommand)
        {
            return Ok(await Mediator!.Send(createBrandCommand));
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            return Ok(await Mediator!.Send(new GetListBrandQuery { PageRequest = pageRequest }));
        }
    }
}
