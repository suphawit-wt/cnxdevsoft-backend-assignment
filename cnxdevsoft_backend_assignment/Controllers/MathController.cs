using cnxdevsoft_backend_assignment.Data;
using cnxdevsoft_backend_assignment.Models;
using cnxdevsoft_backend_assignment.Models.Requests;
using cnxdevsoft_backend_assignment.Models.Responses;
using cnxdevsoft_backend_assignment.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cnxdevsoft_backend_assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        private readonly IMathService _mathService;

        public MathController(IMathService mathService)
        {
            _mathService = mathService;
        }

        [HttpGet]
        public async Task<ActionResult<List<MathOperation>>> GetAll()
        {
            return await _mathService.GetAll();
        }

        [HttpPost("Calculate")]
        public async Task<ActionResult<ApiResponse>> CalculateXY([FromQuery] MathCalculateRequest request)
        {
            try
            {
                double result = _mathService.CalculateXY(request);

                MathOperation mathOperation = new()
                {
                    X = request.X,
                    Y = request.Y,
                    Operator = request.Operator,
                    Result = result
                };

                await _mathService.Create(mathOperation);

                ApiResponse response = new()
                {
                    StatusCode = 201,
                    Message = "Created Math Operation Successfully!"
                };

                return StatusCode(201, response);
            } catch (Exception ex)
            {
                ApiResponse response = new()
                {
                    StatusCode = 500,
                    Message = "Internal Server Error"
                };

                switch (ex.Message)
                {
                    case "400":
                        response.StatusCode = 400;
                        response.Message = "Valid Operator is add,sub,mul and div.";

                        return BadRequest(response);
                    default:
                        return StatusCode(500, response);
                }
            }
            
        }
    }
}