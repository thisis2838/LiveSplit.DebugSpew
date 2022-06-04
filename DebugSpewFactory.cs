using LiveSplit.DebugSpew;
using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: ComponentFactory(typeof(DebugSpewFactory))]

namespace LiveSplit.DebugSpew
{
    class DebugSpewFactory : IComponentFactory
    {
        public string ComponentName
        {
            get { return "Debug Spew Viewer"; }
        }

        public string Description => "";

        public ComponentCategory Category => ComponentCategory.Information;

        public IComponent Create(LiveSplitState state)
        {
            return new DebugSpewComponent(state);
        }

        public string UpdateName => this.ComponentName;

        public string UpdateURL => null;

        public Version Version
        {
            get { return Version.Parse("1.2.0"); }
        }

        public string XMLURL => null;
    }
}
