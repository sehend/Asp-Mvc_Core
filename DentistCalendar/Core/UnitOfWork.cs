using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IUnitOfWork
    {
      
     


        void Commit();
    }
}
