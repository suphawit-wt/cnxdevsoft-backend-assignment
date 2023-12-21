using cnxdevsoft_backend_assignment.Models;
using cnxdevsoft_backend_assignment.Models.Requests;

namespace cnxdevsoft_backend_assignment.Services
{
    public interface IMathService
    {
        double CalculateXY(MathCalculateRequest request);

        Task<List<MathOperation>> GetAll();
        Task Create(MathOperation mathOperation);
    }
}
