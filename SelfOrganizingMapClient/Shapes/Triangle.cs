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
