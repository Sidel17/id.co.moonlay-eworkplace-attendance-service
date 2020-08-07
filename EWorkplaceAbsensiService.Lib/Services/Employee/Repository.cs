using Com.Moonlay.Models;
using EWorkplaceAbsensiService.Lib.Helpers.IdentityService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace EWorkplaceAbsensiService.Lib.Services.Employee
{
    public class Repository<T> : IRepository<T>
        where T : StandardEntity
    {
        private const string UserAgent = "attendance-service";
        private readonly AbsensiDbContext _dbContext;
        private readonly IIdentityService _identityService;
        private readonly DbSet<T> _dbSet;

        public Repository(AbsensiDbContext dbContext, IServiceProvider serviceProvider)
        {
            _dbContext = dbContext;
            _identityService = serviceProvider.GetService<IIdentityService>();

            _dbSet = dbContext.Set<T>();
        }

        public int Create(T model)
        {
            EntityExtension.FlagForCreate(model, _identityService.Username, UserAgent);
            _dbSet.Add(model);
            _dbContext.SaveChanges();
            return model.Id;
        }

        public int Delete(T model)
        {
            EntityExtension.FlagForDelete(model, _identityService.Username, UserAgent);
            _dbSet.Update(model);
            _dbContext.SaveChanges();
            return model.Id;
        }

        public T GetById(int id)
        {
            return _dbSet.FirstOrDefault(entity => entity.Id == id);
        }

        public DbSet<T> GetQuery()
        {
            return _dbSet;
        }

        public int Update(T model)
        {
            EntityExtension.FlagForUpdate(model, _identityService.Username, UserAgent);
            _dbSet.Update(model);
            _dbContext.SaveChanges();
            return model.Id;
        }
    }
}
