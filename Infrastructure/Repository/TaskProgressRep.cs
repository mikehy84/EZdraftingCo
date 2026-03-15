
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
    public class TaskProgressRep : Repository<TaskProgress>, ITaskProgress
    {
        private readonly ApplicationDbContext _db;

        public TaskProgressRep(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<bool> ContainsAsync(TaskProgress taskProgress)
        {
            throw new NotImplementedException();
        }

        public Task<TaskProgress> UpdateAsync(TaskProgress taskProgress)
        {
            throw new NotImplementedException();
        }
    }
}
