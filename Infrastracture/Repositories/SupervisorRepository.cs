using Application.IRepository;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;


namespace Infrastracture.Repositories
{
    public class SupervisorRepository : AsyncRepository<Supervisor>, ISupervisorRepository
    {
        private readonly ApplicationDbContext _db;

        public SupervisorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


    }
}
