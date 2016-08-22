using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using NeuralNetworks.SelfOrganizingMapHelpers;

namespace SelfOrganizingMapClient.Helpers
{
    public static class Translator
    {
        public static Node TranslatePointToNode(Point point)
        {
            return new Node(point.X, point.Y);
        }

        public static Point TranslateNodeToPoint(Node node)
        {
            return new Point(node.X, node.Y);
        }

        public static List<Node> TranslatePointsToNodes(List<Point> points)
        {
            return points.Select(point => new Node(point.X, point.Y)).ToList();
        }

        public static List<Point> TranslateNodesToPoints(List<Node> nodes)
        {
            return nodes.Select(node => new Point(node.X, node.Y)).ToList();
        }
    }
}
