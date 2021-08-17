using GeometricFigures.Business.Interfaces.Services;
using GeometricFigures.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GeometricFigures.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CircleController : ControllerBase
    {
        private readonly ICircleService _circleService;

        public CircleController(ICircleService circleService)
        {
            _circleService = circleService;
        }
        // GET: api/<CircleeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
       

        // POST api/<CircleeController>
        [HttpPost]
        public Response PostCircle(Circle circle)
        {
            double result;
            Response response = new  Response();

            try
            {
                result = _circleService.CircleArea(circle);
                response.Code = 200;
                response.Message = "The area of the circle " + result;
            }
            catch (Exception e)
            {
                response.Code = 500;
                response.Message = e.Message;
            }

            return response;
        }      
    }
}
