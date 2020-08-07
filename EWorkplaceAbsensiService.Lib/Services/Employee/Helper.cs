using System;
using System.Collections.Generic;
using System.Text;

namespace EWorkplaceAbsensiService.Lib.Services.Employee
{
    public class IndexResponse<T>
    {
        public IndexResponse(List<T> data, int total, int page, int size)
        {
            Data = data;
            Total = total;
            Page = page;
            Size = size;
        }

        public List<T> Data { get; }
        public int Total { get; }
        public int Page { get; }
        public int Size { get; }
    }
}
