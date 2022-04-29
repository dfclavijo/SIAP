using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAP.Application.Interfaces
{
    public interface IUnitOfWork
    {
        //ITournamentsRepository Tournaments {get;}

        Task CompleteAsync();  
        
    }
}