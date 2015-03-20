using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sandbox.Common;
using Sandbox.Common.Components;
using Sandbox.Common.ObjectBuilders;

using Sandbox.Definitions;
using Sandbox.Engine;
using Sandbox.Game;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;

namespace SEAutoLCDs
{
    public class Program2
    {
        public IMyGridTerminalSystem GridTerminalSystem;
        public string Storage;

        // from here
        int count = 0;

        public void Increase(IMyRadioAntenna ant)
        {
            count++; count--; count++;
            ant.SetCustomName("PROG ant: " + count.ToString());
            string val = (count > 1000 ? "" : "+");
        }

        void Main()
        {
            List<IMyTerminalBlock> blocks = new List<IMyTerminalBlock>();

            GridTerminalSystem.GetBlocksOfType<IMyRadioAntenna>(blocks);
            IMyRadioAntenna ant = blocks[0] as IMyRadioAntenna;

            while (true)
            {
                Increase(ant);
            }
        }

        // to here
    }
}
