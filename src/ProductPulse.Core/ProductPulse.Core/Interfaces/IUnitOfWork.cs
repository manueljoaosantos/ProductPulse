﻿

namespace ProductPulse.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }

        int Save();
    }
}
