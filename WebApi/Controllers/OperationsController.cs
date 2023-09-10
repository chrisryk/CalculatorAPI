using Application.Commands.DoubleOperands;
using Application.Commands.SingleOperand;
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

        [HttpPost("double-operands")]
        [ProducesResponseType(typeof(float), 200)]
        [ProducesResponseType(typeof(string), 400)]
        public async Task<ActionResult<float>> DoubleOperands([FromBody] DoubleOperandsCommandParameters parameters)
        {
            var divideCommand = new DoubleOperandsCommand
            {
                FirstOperand = parameters.FirstOperand,
                SecondOperand = parameters.SecondOperand,
                Operator = parameters.Operator,
            };

            try
            {
                return await _mediator.Send(divideCommand);
            }
            catch (Exception ex)
            {
                if (ex is DivideByZeroException || ex is ArgumentException)
                {
                    return BadRequest(ex.Message);
                }
                throw;
            }
        }

        [HttpPost("single-operand")]
        [ProducesResponseType(typeof(long), 200)]
        [ProducesResponseType(typeof(string), 400)]
        public async Task<ActionResult<long>> SingleOperand([FromBody] SingleOperandCommandParameters parameters)
        {
            var factorialCommand = new SingleOperandCommand
            {
                Value = parameters.Value,
                Operator = parameters.Operator,
            };

            try
            {
                return await _mediator.Send(factorialCommand);
            }
            catch (Exception ex)
            {
                if (ex is ArgumentException || ex is OverflowException)
                {
                    return BadRequest(ex.Message);
                }
                throw;
            }
        }
    }
}
