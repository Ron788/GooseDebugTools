using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using GooseShared;
using SamEngine;
using GooseDebugTools;

namespace GooseDebugTools
{
    class Draws
    {
        private GooseEntity _goose;
        private Graphics _graphics;
        private int _lineNum;
        private string[] _tasks;
        public Draws(GooseEntity goose, Graphics graphics, string[] tasks)
        {
            _goose = goose;
            _graphics = graphics;
            _lineNum = 0;
            _tasks = tasks;

            Task();
            Position();
        }
        private void Task()
        {
            float walk = _goose.parameters.WalkSpeed;
            float run = _goose.parameters.RunSpeed;
            float charge = _goose.parameters.ChargeSpeed;

            string speed = _goose.currentSpeed == walk ?
                             "Walk (" : _goose.currentSpeed == run ?
                                          "Run (" : _goose.currentSpeed == charge ?
                                                      "Charge (" : "Custom (";
            speed += _goose.currentSpeed + ")";



            DebugTools.OutputLine(_goose, _graphics, _lineNum, _tasks[_goose.currentTask] + " " + speed);
        }
        private void Position()
        {
            Vector2 goosePos = _goose.position;
            string line = "xy: (" + Math.Round(goosePos.x) + ", " + Math.Round(goosePos.y) + ")";
            DebugTools.OutputLine(_goose, _graphics, _lineNum + 1, line);
        }
    }
}
