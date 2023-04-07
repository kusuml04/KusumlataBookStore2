using System;
using System.Collections.Generic;
using System.Text;

namespace KusumlataBooks.DataAccess.Repository.IRepository.cs
{
   public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository CategoryRepository { get; } 
        ISP_Call SP_Call { get; }
    }
}
