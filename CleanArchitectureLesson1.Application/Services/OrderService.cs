using CleanArchitectureLesson1.Core.Models;
using CleanArchitectureLesson1.Core.Stores;

namespace CleanArchitectureLesson1.Application.Services
{
    public class OrderService
    {
        private readonly IOrderStore _orderStore;

        public OrderService(IOrderStore orderStore)     
        {
            _orderStore = orderStore;
        }

        public async Task Get(Guid id)
        {
            await _orderStore.GetById(id);
        }

        public async Task Update(Order order)
        {
        }
        public async Task Get()
        {

        }

        public async Task Create(Order order)
        {
            var existedOrder = await _orderStore.GetByName(order.Name);
            if (existedOrder != null)
            {
                throw new InvalidOperationException("Error");
            }

            await _orderStore.Add(order);
        }
    }
}
