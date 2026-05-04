using CashFlowTwo.Communication.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CashFlowTwo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        [HttpPost]

        public IActionResult Register([FromBody] RequestRegisterExpenseJson request)
        {
            return Created();
        }
    }
}
