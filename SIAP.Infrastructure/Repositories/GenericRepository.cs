using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SIAP.Application.Interfaces;
using SIAP.Infrastructure.Data.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAP.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected SiapContext _context;
        internal DbSet<T> dbSet;
        protected readonly ILogger _logger;
        public readonly IMapper _mapper;

        public GenericRepository(SiapContext context, ILogger logger, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
            _logger = logger;
            dbSet = context.Set<T>();
        }

        public virtual async Task<bool> Add(T entity)
        {
            await dbSet.AddAsync(entity);
            return true;
        }
        

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }

        
    }
}
