using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RevisaoWEBApi.Utils
{
    public class Single<T> : DbContext,IDisposable
    {

        private static object _instance = null;

        public static T GetInstance()
        {
            if (_instance == null)
            {
                _instance = Activator.CreateInstance<T>();
            }

            return (T)_instance;
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

                disposedValue = true;
            }
        }

        void IDisposable.Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}