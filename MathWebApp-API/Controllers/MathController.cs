using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MathLibrary;

namespace MathWebApp_API.Controllers
{
    [Route("api/[controller]/[actions]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        //MathCAlculations is a method in MathLibrary which performs the mathematical operations.
        MathCalculations math = new MathCalculations();

        [HttpGet]
        public double Add(int lVal, int rVal)
        {
            //CROS is basically allowing the content to share explicitly between different origins.
            Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:44371");
            
            // here CAlculate function will be called from the MathLibrary
            return math.Calculate(lVal, rVal, "Add");
        }

        [HttpGet]
        public double Subtract(int lVal, int rVal)
        {
            //CROS is basically allowing the content to share explicitly between different origins.
            Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:44371");

            // here CAlculate function will be called from the MathLibrary
            return math.Calculate(lVal, rVal, "Subtract");
        }

        [HttpGet]
        public double Multiply(int lVal, int rVal)
        {
            //CROS is basically allowing the content to share explicitly between different origins.
            Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:44371");

            // here CAlculate function will be called from the MathLibrary
            return math.Calculate(lVal, rVal, "Multiply");
        }

        [HttpGet]
        public double Divide(int lVal, int rVal)
        {
            //This will check for the denominator , if equal to 0 than response "Bad Request"
        if(rVal ==0)
            {
                Response.StatusCode = 400;
                return null;
            }

            //CROS is basically allowing the content to share explicitly between different origins.
            Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:44371");

            // here CAlculate function will be called from the MathLibrary
            return math.Calculate(lVal, rVal, "Divide");
        }

    }
}
