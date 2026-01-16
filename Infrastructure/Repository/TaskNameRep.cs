
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class TaskNameRep : Repository<TaskName>, ITaskName
    {
        private readonly ApplicationDbContext _db;

        public TaskNameRep(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<bool> ContainsAsync(TaskName taskName)
        {
            throw new NotImplementedException();
        }

        public Task<TaskName> UpdateAsync(TaskName taskName)
        {
            throw new NotImplementedException();
        }
    }
}
