using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficLight
{
    class TrafficLight
    {
        private int _phase;
        public bool IsRedOn => _phase < 2;
        public bool IsYellowOn => _phase % 2 == 1;
        public bool IsGreenOn => _phase == 2;


        public void Next()
        {
            _phase = (_phase + 1) % 4;
        }
    }
}
