using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using SIAP.Application.Interfaces;
using SIAP.Infrastructure.Data.DbContext;

namespace SIAP.Infrastructure.Data.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork, IDisposable
    {
        private readonly SiapContext _context;
        private readonly ILogger _logger;

        public UnitOfWork(SiapContext context, ILoggerFactory loggerFactory, IMapper mapper)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("db_logs");
            
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}