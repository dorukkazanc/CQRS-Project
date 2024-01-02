using Application.Features.Brands.Commands.Create;
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
    }
}
