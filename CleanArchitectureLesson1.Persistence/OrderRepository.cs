using CleanArchitectureLesson1.Core.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitectureLesson1.Core.Models;

namespace CleanArchitectureLesson1.Persistence
{
    public class OrderRepository: IOrderStore

    {
        public async Task<IReadOnlyList<Order>> GetByFilter(OrderFilter filter)
        {
            throw new NotImplementedException();
        }

        public async Task<Order> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Order> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task Add(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
