using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        //Classları yazmak zorunda deyilsin

        IProductRepository Product { get; }

        ICategoryRepository category { get;  }


        //commit SaveChange metodunu çagırcak arka planda

        Task CommitAsync();


        void Commit();

    }
}
