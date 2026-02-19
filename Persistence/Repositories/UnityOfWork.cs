using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Persistence.Context;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Persistence.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly AppDbContext _context;

        public UnityOfWork(AppDbContext context)
        {
            _context = context;
        }
        public async Task Commit(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
