using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AppVeyorSample.Controllers;

namespace AppVeyorSample.Tests.Fixtures
{
    public class ValuesControllerFixture : IDisposable
    {
        private bool _disposed;

        public ValuesControllerFixture()
        {
            this.ValuesController = new ValuesController();
        }

        public ValuesController ValuesController { get; }

        public void Dispose()
        {
            if (this._disposed)
            {
                return;
            }

            this._disposed = true;
        }
    }
}
