using FrameworkOne.Domain;
using FrameworkOne.Repository.Interface;
using System;

namespace FrameworkOne.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private FrameworkOneContext _context;

        public UnitOfWork(FrameworkOneContext context)
        {
            this._context = context;
            this._context.Configuration.LazyLoadingEnabled = false;
        }

        public FrameworkOneContext DbContext
        {
            get
            {
                return this._context;
            }
        }

        public int Save()
        {
            return this._context.SaveChanges();
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this._context != null)
                {
                    this._context.Dispose();
                    this._context = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
