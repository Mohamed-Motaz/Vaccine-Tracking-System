using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineTrackingSystem.DataStructures
{
    class CustomNode <T>
    {

        public CustomNode<T> NextNode;
        T Value;
        public CustomNode(T val)
        {
            Value = val;
            NextNode = null;
        }

    }
}
