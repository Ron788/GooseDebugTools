using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using GooseShared;
using SamEngine;
using static GooseShared.API;
using static GooseShared.API.TaskDatabaseQueryFunctions;

using GooseDebugTools;

namespace GooseDebugTools
{
    public class Main : IMod
    {
        private string[] _tasks;
        void IMod.Init()
        {
            _tasks = TaskDatabase.getAllLoadedTaskIDs();

            InjectionPoints.PostRenderEvent += PostRender;
        }

        private void PostRender(GooseEntity goose, Graphics graph)
        {
            Draws draws = new Draws(goose, graph, _tasks);
        }
    }
}
