using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace EWorkplaceAbsensiService.Lib.Services.Employee.Asset
{
    public class AssetService : IAssetService
    {
        private readonly IRepository<Models.Employee.Asset> _repository;

        public AssetService(IServiceProvider serviceProvider)
        {
            _repository = serviceProvider.GetService<IRepository<Models.Employee.Asset>>();
        }

        public void Create(FormDto form)
        {
            var model = new Models.Employee.Asset(form.IdentityNumber, form.Name, form.Type.GetValueOrDefault());
            _repository.Create(model);
        }

        public Models.Employee.Asset GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IndexResponse<Models.Employee.Asset> GetIndexResponse(string keyword, int page, int size)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, FormDto form)
        {
            throw new NotImplementedException();
        }
    }
}
