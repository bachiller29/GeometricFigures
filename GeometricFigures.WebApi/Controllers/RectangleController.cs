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
    public class RectangleController : ControllerBase
    {
        private readonly IRectangleService _rectangleService;

        public RectangleController(IRectangleService rectangleService)
        {
            _rectangleService = rectangleService;
        }

        // GET: api/<preubaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/<preubaController>
        [HttpPost]
        public Response PostRectangle(Rectangle rectangle)
        {
            int result;          
            Response response = new Response();

            try
            {
                result = _rectangleService.RectangleArea(rectangle);
                response.Code = 200;
                response.Message = "The area of the rectangle is " + result;
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
