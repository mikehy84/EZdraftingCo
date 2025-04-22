using EZD_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZD_DAL.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IProject Projects { get; }
        IAppUser AppUsers { get; }

        Task Save();
    }
}
