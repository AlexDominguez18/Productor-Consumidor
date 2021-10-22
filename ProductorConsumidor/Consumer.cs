using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductorConsumidor
{
    class Consumer
    {
        private int state;
        private int currentPos;

        public Consumer()
        {
            state = 0;
            currentPos = 0;
        }

        public void setState(int value)
        {
            state = value;
        }

        public int getState()
        {
            return state;
        }

        public void setCurrentPos(int value)
        {
            currentPos = value;
        }

        public int getCurrentPos()
        {
            return currentPos;
        }

        public bool Consume()
        {
            return false;
        }
    }
}
