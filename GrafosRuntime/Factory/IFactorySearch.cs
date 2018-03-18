using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace Factory
{
    public interface IFactorySearch
    {
        string CreateFactorySearch(XmlDocument configuratorFile);
    }
}
