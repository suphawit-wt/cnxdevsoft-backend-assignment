using cnxdevsoft_backend_assignment.Models;

namespace cnxdevsoft_backend_assignment.Services
{
    public interface IMathService
    {
        double CalculateXY(MathOperation request);

        Task<List<MathOperation>> GetAll();
        Task Create(MathOperation mathOperation);
    }
}
