using System;
using Glimpse.Core2;
using Glimpse.Core2.Extensibility;

namespace Glimpse.Test.Core2
{
    [GlimpsePlugin(RequestContextType = typeof(string))]
    public class TestPlugin : IGlimpsePlugin
    {
        public object GetData(IServiceLocator locator)
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get { return "Test Plugin"; }
        }
    }
}