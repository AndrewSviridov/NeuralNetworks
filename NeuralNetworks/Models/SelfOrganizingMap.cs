using System;
using System.Collections.Generic;
using NeuralNetworks.SelfOrganizingMapHelpers;

namespace NeuralNetworks.Models
{
    public class SelfOrganizingMap
    {
        public List<Node> _nodes;


        public SelfOrganizingMap(List<Node> nodes)
        {
            _nodes = nodes;
        }

        public List<Node> StartModifyNodes(Node randomizedPoint, int neighborRadius, double shiftFactor)
        {
            var nearestNode = FindNearestNode(randomizedPoint);
            var nearestNodeIndex = _nodes.IndexOf(nearestNode);

            MoveAdjacentNodes(randomizedPoint, nearestNodeIndex, neighborRadius, shiftFactor);

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

        private void MoveAdjacentNodes(Node randomizedPoint, int winnerIndex, int neighborRadius, double shiftFactor)
        {
            MoveWinner(randomizedPoint, winnerIndex, shiftFactor);
            if (neighborRadius != 0)
            {
                MoveLeftNeighbours(randomizedPoint, winnerIndex, neighborRadius, shiftFactor);
                MoveRightNeighbours(randomizedPoint, winnerIndex, neighborRadius, shiftFactor);
            }
        }

        private void MoveWinner(Node randomizedPoint, int winnerIndex, double shiftFactor)
        {
            _nodes[winnerIndex].X += (int)((randomizedPoint.X - _nodes[winnerIndex].X) * shiftFactor);
            _nodes[winnerIndex].Y += (int)((randomizedPoint.Y - _nodes[winnerIndex].Y) * shiftFactor);
        }

        private void MoveLeftNeighbours(Node randomizedPoint, int winnerIndex, int neighborRadius, double shiftFactor)
        {
            for (int index = winnerIndex - 1; index >= winnerIndex - neighborRadius; index--)
            {
                if (index >= 0)
                {
                    shiftFactor *= 0.95;
                    _nodes[index].X += (int)((randomizedPoint.X - _nodes[index].X) * shiftFactor);
                    _nodes[index].Y += (int)((randomizedPoint.Y - _nodes[index].Y) * shiftFactor);
                }
                else
                {
                    break;
                }
            }
        }

        private void MoveRightNeighbours(Node randomizedPoint, int winnerIndex, int neighborRadius, double shiftFactor)
        {
            for (int index = winnerIndex + 1; index <= winnerIndex + neighborRadius; index++)
            {
                if (index < _nodes.Count)
                {
                    shiftFactor *= 0.95;
                    _nodes[index].X += (int)((randomizedPoint.X - _nodes[index].X) * shiftFactor);
                    _nodes[index].Y += (int)((randomizedPoint.Y - _nodes[index].Y) * shiftFactor);
                }
                else
                {
                    break;
                }
            }
        }

        #region Not done yet

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

        private double GaussianInfluence(double distance, double radius)
        {
            return Math.Exp(-Math.Pow(distance, 2) / (2 * Math.Pow(radius, 2)));
        }

        private int RectangularInfluence(double distance, double radius)
        {
            return distance <= radius ? 1 : 0;
        }

        #endregion
    }
}
