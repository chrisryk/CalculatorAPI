using Application.Commands.Add;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Parameters;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("operations")]
    public class OperationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OperationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("add")]
        [ProducesResponseType(typeof(int), 200)]
        public async Task<ActionResult<int>> Add([FromQuery] Addition parameters)
        {
            var addCommand = new AddCommand
            {
                FirstOperand = parameters.FirstOpereand,
                SecondOperand = parameters.SecondOperand
            };

            return await _mediator.Send(addCommand);
        }
    }
}