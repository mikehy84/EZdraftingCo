
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
    public class ProjectRep : Repository<Project>, IProject
    {
        private readonly ApplicationDbContext _db;

        public ProjectRep(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Project> UpdateAsync(Project project)
        {

            _db.Projects.Update(project);
            await SaveAsync();
            return project;
        }

        public async Task<bool> ContainsAsync(Project project)
        {
            if (project == null)
                throw new ArgumentNullException(nameof(project));

            return await _db.Projects.AnyAsync(p => p.BuildingName.Equals(project.BuildingName));
        }

    }
}
