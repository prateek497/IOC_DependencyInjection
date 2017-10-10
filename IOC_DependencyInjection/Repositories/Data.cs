using System.Collections.Generic;

namespace IOC_DependencyInjection.Repositories
{
    public class Data : IData
    {
        public List<string> Names()
        {
            return new List<string> { "Prateek", "Gangwar" };
        }
    }
}