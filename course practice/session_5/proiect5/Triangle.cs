using System;
namespace proiect5
{
    internal class Triangle
    {
        private readonly Point[] peaks;

        public Point[] Peaks
        {
            get
            {
                Point[] result = new Point[peaks.Length];
                for (int i = 0; i < peaks.Length; i++)
                {
                    result[i] = new Point(peaks[i].x, peaks[i].y, peaks[i].z);
                }
                return result;
            }
        }

        public Triangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            peaks = new Point[3] {firstPoint, secondPoint, thirdPoint};
        }
    }
}

