using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Data;
using System.Collections.Generic;
using Microsoft.Practices.Unity.Utility;
using OurBlog.IDal;
using OurBlog.Model;

namespace OurBlog.Dal
{
    public class OurBlogRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public OBDbContext DbContext { get; private set; }
       // public DbSet<TEntity> DbSet { get; private set; }
        public OurBlogRepository(OBDbContext context)
        {
            Guard.ArgumentNotNull(context, "context");
            this.DbContext = context;
           // this.DbSet = this.DbContext.Set<TEntity>();
        }

        public int Count(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

       

        public IEnumerable<TEntity> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Get<TOderKey>(Expression<Func<TEntity, bool>> filter, int pageIndex, int pageSize, Expression<Func<TEntity, TOderKey>> sortKeySelector, bool isAsc = true)
        {
            Guard.ArgumentNotNull(filter, "predicate");
            Guard.ArgumentNotNull(sortKeySelector, "sortKeySelector");
            throw new NotImplementedException();
        }

        public int Add(TEntity instance)
        {
            Guard.ArgumentNotNull(instance, "instance");
            throw new NotImplementedException();
        }

        public int Update(TEntity instance)
        {
            Guard.ArgumentNotNull(instance, "instance");
            throw new NotImplementedException();
        }

        public int Delete(TEntity instance)
        {
            Guard.ArgumentNotNull(instance, "instance");
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~OurBlogRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}