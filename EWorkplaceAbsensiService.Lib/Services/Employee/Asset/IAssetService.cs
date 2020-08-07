namespace EWorkplaceAbsensiService.Lib.Services.Employee.Asset
{
    public interface IAssetService
    {
        void Create(FormDto form);
        void Update(int id, FormDto form);
        Models.Employee.Asset GetById(int id);
        IndexResponse<Models.Employee.Asset> GetIndexResponse(string keyword, int page, int size);
    }
}
