using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitectureLesson1.Core.Models;

namespace CleanArchitectureLesson1.Core.Stores
{
    public interface IOrderStore
    {
        Task<IReadOnlyList<Order>> GetByFilter(OrderFilter filter);
        Task<Order> GetById(Guid id);
        Task<Order> GetByName(string name);
        Task Add(Order order);
    }
}
