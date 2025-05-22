using Smoothstack_Assignment.Core;
using Smoothstack_Assignment.Core.Interfaces;
using Smoothstack_Assignment.Core.Models;
using Smoothstack_Assignment.EF.Repositories;
using Smoothstack_AssignmentCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoothstack_Assignment.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IGenericRepository<Customer> Customers { get; private set; }
        public IGenericRepository<Order> Orders { get; private set; }
        public  IGenericRepository<OrderItem> OrderItems { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            Customers = new GenericRepository<Customer>(_context);
            Orders = new GenericRepository<Order>(_context);
            OrderItems = new GenericRepository<OrderItem>(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}