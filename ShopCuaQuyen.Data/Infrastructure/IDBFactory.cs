using System;

namespace ShopCuaQuyen.Data.Infrastructure
{
    public interface IDBFactory : IDisposable
    {
        ShopCuaQuyenDbContext Init();
    }
}