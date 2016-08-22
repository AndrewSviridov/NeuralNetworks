using System;
using System.Collections.Generic;
using NeuralNetworks.SelfOrganizingMapHelpers;

namespace NeuralNetworks.Models
{
    public class SelfOrganizingMap
    {
        private List<Node> _nodes;

        public SelfOrganizingMap(List<Node> nodes)
        {
            _nodes = nodes;
        }

        public List<Node> ModifyNodes(Node randomizedPoint, double radius, double learningRate, int neighborRadius)
        {
            var nearestNode = FindNearestNode(randomizedPoint);
            var nearestNodeIndex = _nodes.IndexOf(nearestNode);

            //MoveAdjacentNodesWithGaussian(randomizedPoint, nearestNodeIndex, radius, learningRate);
            //MoveAdjacentNodesWithRectangular(randomizedPoint, nearestNodeIndex, radius, learningRate);
            MoveAdjacentNodesWithFactor(randomizedPoint, nearestNodeIndex, 0.2, neighborRadius);

            return _nodes;
        }

        private Node FindNearestNode(Node randomizedPoint)
        {
            Node nearestNode = null;
            double minDistance = double.MaxValue;

            foreach (var node in _nodes)
            {
                var distance = CalculateEuclideanDistance(randomizedPoint, node);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearestNode = node;
                }
            }

            return nearestNode;
        }

        private double CalculateEuclideanDistance(Node firstNode, Node secondNode)
        {
            var powResult = Math.Pow(firstNode.X - secondNode.X, 2) + Math.Pow(firstNode.Y - secondNode.Y, 2);
            return Math.Sqrt(powResult);
        }

        private void MoveAdjacentNodesWithRectangular(Node randomizedPoint, int winnerIndex, double radius, double learningRate)
        {
            for (int index = winnerIndex; index < _nodes.Count; index++)
            {
                var distance = CalculateEuclideanDistance(randomizedPoint, _nodes[index]);

                if (distance <= radius)
                {
                    var influence = RectangularInfluence(distance, radius);
                    _nodes[index].X =
                        (int)(_nodes[index].X + learningRate * influence * (randomizedPoint.X - _nodes[index].X));
                    _nodes[index].Y =
                        (int)(_nodes[index].Y + learningRate * influence * (randomizedPoint.Y - _nodes[index].Y));
                }
                else
                {
                    break;
                }
            }

            for (int index = winnerIndex - 1; index >= 0; index--)
            {
                var distance = CalculateEuclideanDistance(randomizedPoint, _nodes[index]);

                if (distance <= radius)
                {
                    var influence = RectangularInfluence(distance, radius);
                    _nodes[index].X =
                        (int)(_nodes[index].X + learningRate * influence * (randomizedPoint.X - _nodes[index].X));
                    _nodes[index].Y =
                        (int)(_nodes[index].Y + learningRate * influence * (randomizedPoint.Y - _nodes[index].Y));
                }
                else
                {
                    break;
                }
            }
        }

        private void MoveAdjacentNodesWithGaussian(Node randomizedPoint, int winnerIndex, double radius, double learningRate)
        {
            for (int index = winnerIndex; index < _nodes.Count; index++)
            {
                var distance = CalculateEuclideanDistance(randomizedPoint, _nodes[index]);

                if (distance <= radius)
                {
                    var influence = GaussianInfluence(distance, radius);
                    _nodes[index].X =
                        (int)(_nodes[index].X + learningRate * influence * (randomizedPoint.X - _nodes[index].X));
                    _nodes[index].Y =
                        (int)(_nodes[index].Y + learningRate * influence * (randomizedPoint.Y - _nodes[index].Y));
                }
                else
                {
                    break;
                }
            }

            for (int index = winnerIndex - 1; index >= 0; index--)
            {
                var distance = CalculateEuclideanDistance(randomizedPoint, _nodes[index]);

                if (distance <= radius)
                {
                    var influence = GaussianInfluence(distance, radius);
                    _nodes[index].X =
                        (int)(_nodes[index].X + learningRate * influence * (randomizedPoint.X - _nodes[index].X));
                    _nodes[index].Y =
                        (int)(_nodes[index].Y + learningRate * influence * (randomizedPoint.Y - _nodes[index].Y));
                }
                else
                {
                    break;
                }
            }
        }

        private void MoveAdjacentNodesWithFactor(Node randomizedPoint, int winnerIndex, double neighborFactor, int neighborRadius)
        {
            for (int index = winnerIndex - neighborRadius; index <= winnerIndex + neighborRadius; index++)
            {
                if (index < 0 || index >= _nodes.Count)
                {
                    continue;
                }

                _nodes[index].X = (int)(_nodes[index].X + neighborFactor * (randomizedPoint.X - _nodes[index].X));
                _nodes[index].Y = (int)(_nodes[index].Y + neighborFactor * (randomizedPoint.Y - _nodes[index].Y));
            }
        }

        private double GaussianInfluence(double distance, double radius)
        {
            return Math.Exp(-Math.Pow(distance, 2) / (2 * Math.Pow(radius, 2)));
        }

        private int RectangularInfluence(double distance, double radius)
        {
            return distance <= radius ? 1 : 0;
        }
    }
}
