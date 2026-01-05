
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
    public class TaskAssignmentRep : Repository<TaskAssignment>, ITaskAssignment
    {
        private readonly ApplicationDbContext _db;

        public TaskAssignmentRep(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<bool> ContainsAsync(TaskAssignment taskAssignment)
        {
            throw new NotImplementedException();
        }

        public Task<TaskAssignment> UpdateAsync(TaskAssignment taskAssignment)
        {
            throw new NotImplementedException();
        }
    }
}
