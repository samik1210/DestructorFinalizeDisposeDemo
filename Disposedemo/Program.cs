using System;

namespace Disposedemo
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class ResourceManagement : IDisposable

        {

            public ResourceManagement()

            { }

            private bool IsDisposed = false;

            public void Free()

            {

                if (IsDisposed)

                    throw new System.ObjectDisposedException("Object Name");

            }

          

            public void Dispose()

            {                Dispose(true);

               

                GC.SuppressFinalize(this);

            }

            ~ResourceManagement()

            {

 
                Dispose(false);

            }

            protected virtual void Dispose(bool disposedStatus)

            {

                if (!IsDisposed)

                {

                    IsDisposed = true;

                

                    if (disposedStatus)

                    {

                 

                    }

                }

            }

        }
    }
}