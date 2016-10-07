#region License
/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.txt', which is part of this source code package.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Drawing;
using NeuralNetworks.SelfOrganizingMapHelpers;

namespace SelfOrganizingMapClient.Helpers
{
    public class Randomizer
    {
        private readonly Random _random;

        public Randomizer()
        {
            _random = new Random();
        }

        public Point RandomizePointInTriangle(CoordRange coordRange, int areaSize)
        {
            int pointX, pointY, xBoundMin, xBoundMax;

            do
            {
                pointY = ExclusiveRandomizeInRange(coordRange.MinY, coordRange.MaxY);
                xBoundMin = (areaSize + (areaSize / 10) - pointY) / 2;
                xBoundMax = (pointY + areaSize - (areaSize / 10)) / 2;
                pointX = ExclusiveRandomizeInRange(coordRange.MinX, coordRange.MaxX);
            } while (pointX < xBoundMin || pointX > xBoundMax);

            return new Point(pointX, pointY);
        }

        public List<Node> RandomizeStartedNodesInTriangle(int nodesCount, CoordRange startedRange, int areaSize)
        {
            var points = new List<Point>(nodesCount);

            for (int index = 0; index < nodesCount; index++)
            {
                points.Add(RandomizePointInTriangle(startedRange, areaSize));
            }

            return Translator.TranslatePointsToNodes(points);
        }

        private int ExclusiveRandomizeInRange(int min, int max)
        {
            return _random.Next(min + 1, max);
        }
    }
}
