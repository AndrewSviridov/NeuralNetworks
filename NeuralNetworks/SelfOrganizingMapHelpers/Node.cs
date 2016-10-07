#region License
/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.txt', which is part of this source code package.
 */
#endregion

namespace NeuralNetworks.SelfOrganizingMapHelpers
{
    public class Node
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Node(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
