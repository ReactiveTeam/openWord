using PluginCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openWord
{
    public class Main : IPlugin
    {
        public string navItem
        {
            get
            {
                return "openWord";
            }
        }

        public string pluginAuthor
        {
            get
            {
                return "Reactive Team";
            }
        }

        public string pluginDescription
        {
            get
            {
                return "An open-source office app";
            }
        }

        public string pluginName
        {
            get
            {
                return "openWord";
            }
        }

        public string pluginVersion
        {
            get
            {
                return "1.0";
            }
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Tick()
        {
            throw new NotImplementedException();
        }
    }
}
