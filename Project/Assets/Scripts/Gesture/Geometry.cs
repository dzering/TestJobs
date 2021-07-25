using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GestuerRecognition
{
    public sealed class Geometry
    {
        /// <summary>
        /// Computes the Squared Euclidean Distance between two points in 2D
        /// </summary>
        public static float SqrDistance(Point a, Point b)
        {
            return (a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y);
        }

        /// <summary>
        /// Computes the Euclidean Distance between two points in 2D
        /// </summary>
        public static float Distance(Point a, Point b)
        {
            return (float)Math.Sqrt(SqrDistance(a, b));
        }
}
}

