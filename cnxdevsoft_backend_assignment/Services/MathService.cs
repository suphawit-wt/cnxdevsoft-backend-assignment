using cnxdevsoft_backend_assignment.Data;
using cnxdevsoft_backend_assignment.Models;
using cnxdevsoft_backend_assignment.Models.Requests;
using cnxdevsoft_backend_assignment.Models.Responses;
using Microsoft.EntityFrameworkCore;

namespace cnxdevsoft_backend_assignment.Services
{
    public class MathService : IMathService
    {
        private readonly DataContext _dbContext;

        public MathService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public double CalculateXY(MathCalculateRequest request)
        {
            double calculateResult;

            if (request.Operator == "add")
            {
                calculateResult = request.X + request.Y;
            }
            else if (request.Operator == "sub")
            {
                calculateResult = request.X - request.Y;
            }
            else if (request.Operator == "mul")
            {
                calculateResult = request.X * request.Y;
            }
            else if (request.Operator == "div")
            {
                calculateResult = request.X / request.Y;
            }
            else
            {
              throw new Exception("400");
            }

            return calculateResult;
        }

        public async Task<List<MathOperation>> GetAll()
        {
            List<MathOperation> mathOperations = await _dbContext.MathOperations.OrderByDescending(m => m.Id).ToListAsync();

            return mathOperations;
        }

        public async Task Create(MathOperation mathOperation)
        {
            await _dbContext.MathOperations.AddAsync(mathOperation);
            await _dbContext.SaveChangesAsync();
        }
    }
}
