using System;

namespace SelfOrganizingMapClient.Helpers
{
    public class CoordRange
    {
        public int MinX { get; private set; }

        public int MaxX { get; private set; }

        public int MinY { get; private set; }

        public int MaxY { get; private set; }

        public CoordRange(int minX, int maxX, int minY, int maxY)
        {
            ValidateRange(minX, maxX);
            ValidateRange(minY, maxY);

            MinX = minX;
            MaxX = maxX;
            MinY = minY;
            MaxY = maxY;
        }

        private void ValidateRange(int min, int max)
        {
            if (min >= max)
            {
                throw new ArgumentException("Min value must be smaller than Max value.");
            }
        }
    }
}
