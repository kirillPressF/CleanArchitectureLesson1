using System.ComponentModel.DataAnnotations;

namespace CleanArchitectureLesson1.API.Contracts
{
    public record CreateOrderRequest(
        [MaxLength(100)] string Name
    );
}
