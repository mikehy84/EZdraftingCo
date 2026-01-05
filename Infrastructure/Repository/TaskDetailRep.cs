
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
    public class TaskDetailRep : Repository<TaskDetail>, ITaskDetail
    {
        private readonly ApplicationDbContext _db;

        public TaskDetailRep(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<bool> ContainsAsync(TaskDetail taskLog)
        {
            throw new NotImplementedException();
        }

        public Task<TaskDetail> UpdateAsync(TaskDetail taskLog)
        {
            throw new NotImplementedException();
        }
    }
}
