#region License
/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.txt', which is part of this source code package.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using SelfOrganizingMapClient.Shapes;

namespace SelfOrganizingMapClient.Helpers
{
    public enum PointType
    {
        Filled,
        Unfilled
    }

    public class Drawer
    {
        private readonly Graphics _graphics;

        public Drawer(Image image)
        {
            _graphics = Graphics.FromImage(image);
        }

        public void DrawTriangle(Triangle triangle, Color color)
        {
            var pen = new Pen(color);
            _graphics.DrawLine(pen, triangle.Up, triangle.Left);
            _graphics.DrawLine(pen, triangle.Up, triangle.Right);
            _graphics.DrawLine(pen, triangle.Left, triangle.Right);
        }

        public void DrawPoint(Point point, int diameter, Color color, PointType pointType)
        {
            ValidateDiameter(diameter);

            var radius = diameter / 2;
            var location = new Point(point.X - radius, point.Y - radius);
            var size = new Size(diameter, diameter);
            var pen = new Pen(color);
            var rectangle = new Rectangle(location, size);

            _graphics.DrawEllipse(pen, rectangle);

            if (pointType == PointType.Filled)
            {
                var brush = new SolidBrush(color);
                _graphics.FillEllipse(brush, rectangle);
            }
        }

        public void DrawPoints(List<Point> points, int diameter, Color color, PointType pointType)
        {
            foreach (var point in points)
            {
                DrawPoint(point, diameter, color, pointType);
            }
        }

        public void DrawLines(List<Point> points, int width, Color color)
        {
            ValidateLineWidth(width);

            var pen = new Pen(color, width);
            var point = points.First();

            for (int index = 1; index < points.Count; index++)
            {
                _graphics.DrawLine(pen, point, points[index]);
                point = points[index];
            }
        }

        public void ClearArea()
        {
            _graphics.Clear(Color.White);
        }

        private void ValidateDiameter(int diameter)
        {
            if (diameter % 2 != 0)
            {
                throw new ArgumentException("Diameter must be an even number.");
            }
        }

        private void ValidateLineWidth(int width)
        {
            if (width % 2 == 0)
            {
                throw new ArgumentException("Line width must be an odd number.");
            }
        }
    }
}
