using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GreetCalc(decimal num1, decimal num2, char key)
        {
            string result;

            switch (key)
            {
                case '+':
                    result = $"Sum = {num1 + num2}";
                    break;
                case '-':
                    result = $"Subtract = {num1 - num2}";
                    break;
                case '*':
                    result = $"Multiply = {num1 * num2}";
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        return BadRequest("Division by zero is not allowed.");
                    }
                    result = $"Divide = {num1 / num2}";
                    break;
                default:
                    return BadRequest("Invalid operation key.");
            }

            return Ok(result);
        }
    }
}
