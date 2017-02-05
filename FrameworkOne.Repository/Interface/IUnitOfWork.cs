using FrameworkOne.Domain;
using System;

namespace FrameworkOne.Repository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        FrameworkOneContext DbContext { get; }

        int Save();
    }
}