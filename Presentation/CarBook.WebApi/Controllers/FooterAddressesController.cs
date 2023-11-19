using CarBook.Application.Features.Mediator.Commands.FooterAddressCommands;
using CarBook.Application.Features.Mediator.Queries.FooterAddressQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterAddressesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FooterAddressesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> FooterAddressList()
        {
            var values = await _mediator.Send(new GetFooterAddressQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFooter(string id)
        {
            var value = await _mediator.Send(new GetFooterAddressByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFooter(CreateFooterAddressCommand command)
        {
            await _mediator.Send(command);
            return Ok("Footer oluşturuldu");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveFooter(string id)
        {
            await _mediator.Send(new RemoveFooterAddressCommand(id));
            return Ok("Footer Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFooter(UpdateFooterAddressCommand command)
        {
            await _mediator.Send(command);
            return Ok("Footer Güncellendi");
        }
    }
}
