using Com.Moonlay.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EWorkplaceAbsensiService.Lib.Services.Employee
{
    public interface IRepository<T>
        where T : StandardEntity
    {
        int Create(T model);
        int Update(T model);
        int Delete(T model);
        T GetById(int id);
        DbSet<T> GetQuery();
    }
}
