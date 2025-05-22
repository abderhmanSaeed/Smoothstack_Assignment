using Smoothstack_Assignment.Core.Interfaces;
using Smoothstack_Assignment.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoothstack_AssignmentCore
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Order> Orders { get; }
        IGenericRepository<OrderItem> OrderItems { get; }

        Task<int> CompleteAsync();
    }
}