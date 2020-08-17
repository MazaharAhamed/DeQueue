using System;
using System.Collections.Generic;
using System.Text;

namespace StackLinkedListProject
{
    class Node
    {
        public Node link;
        public int info;

        public Node(int i)
        {
            info = i;
            link = null;
        }
    }
}