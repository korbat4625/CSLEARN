using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic {
    interface IEngine {
        public void SpeedUp(int num);
        public void SpeedDown(int num);
        public void ShowSpeed();
    }
    internal class Vehicle {
        public IEngine _engine;
        public Vehicle(IEngine engine) {
            _engine = engine;
        }
    }
}
