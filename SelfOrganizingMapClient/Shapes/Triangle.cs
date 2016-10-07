#region License
/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.txt', which is part of this source code package.
 */
#endregion

using System.Drawing;

namespace SelfOrganizingMapClient.Shapes
{
    public class Triangle
    {
        public Point Up { get; set; }

        public Point Left { get; set; }

        public Point Right { get; set; }

        public Triangle(Point up, Point left, Point right)
        {
            Up = up;
            Left = left;
            Right = right;
        }
    }
}
