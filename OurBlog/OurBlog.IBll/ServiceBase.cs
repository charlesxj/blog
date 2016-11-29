﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OurBlog.IBll
{
    public class ServiceBase : IDisposable
    {
        public IList<IDisposable> DisposableObjects { get; private set; }
        public ServiceBase()
        {
            this.DisposableObjects = new List<IDisposable>();
        }
        protected void AddDisposableObject(object obj)
        {
            IDisposable disposable = obj as IDisposable;
            if (null != disposable)
            {
                this.DisposableObjects.Add(disposable);
            }
        }
        public void Dispose()
        {
            foreach (IDisposable item in this.DisposableObjects)
            {
                if (null != item)
                {
                    item.Dispose();
                }
            }
        }
    }
}