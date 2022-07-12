using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestNet5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
         
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secundNumber}")]
        public IActionResult Get(string firstNumber,string secundNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secundNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secundNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("invalid Input");
        }  
        
        [HttpGet("menos/{firstNumber}/{secundNumber}")]
        public IActionResult GetMenos(string firstNumber,string secundNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secundNumber))
            {
                var sum = ConvertToDecimal(firstNumber) - ConvertToDecimal(secundNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("invalid Input");
        }  

        [HttpGet("vezes/{firstNumber}/{secundNumber}")]
        public IActionResult GetVezes(string firstNumber,string secundNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secundNumber))
            {
                var sum = ConvertToDecimal(firstNumber) * ConvertToDecimal(secundNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("invalid Input");
        }
        [HttpGet("divisao/{firstNumber}/{secundNumber}")]
        public IActionResult GetDivisao(string firstNumber,string secundNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secundNumber))
            {
                var sum = ConvertToDecimal(firstNumber) / ConvertToDecimal(secundNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("invalid Input");
        }

        private bool IsNumeric(string numero)
        {
            double number ;
            bool isNumber = double.TryParse(numero, System.Globalization.NumberStyles.Any, 
                System.Globalization.NumberFormatInfo.InvariantInfo, out number);


            return isNumber;
        }
        private decimal ConvertToDecimal(string numero)
        {
            decimal DecimalValue;

            if (decimal.TryParse(numero, out DecimalValue))
               return DecimalValue;


            return 0;
        }
    }
}
