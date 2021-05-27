using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineTrackingSystem.DataStructures
{
     class CustomLinkedList<T>
     {
        CustomNode<T> HeadNode;
        CustomNode<T> LastNode;
        public CustomNode<T> getNode(int index)
        {
            CustomNode<T> NodeMover = HeadNode;
            int currentIndex = 0;
            while (currentIndex < index)
            {
                currentIndex++;
                NodeMover = NodeMover.NextNode;
            }
            return NodeMover;
        }
        public void appendNewNode(T NewData)
        {

            CustomNode<T> NewNode = new CustomNode<T> (NewData);
            
            if (HeadNode == null)
            {
                HeadNode = new CustomNode <T> (NewData);
            }

            LastNode.NextNode = NewNode;

            LastNode = NewNode;
            
            return;
        }
        void deleteNodeByIndex(int targetIndex)
        {
            if(targetIndex == 0)
            {
                HeadNode = HeadNode.NextNode;
                return;
            }
            CustomNode<T> theNodeBeforeTheIndex = getNode(targetIndex - 1);
            CustomNode<T> targetNode = getNode(targetIndex);

            theNodeBeforeTheIndex.NextNode = targetNode.NextNode;
        }

    }
}
