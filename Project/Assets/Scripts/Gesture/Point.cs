using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GestuerRecognition
{
    public sealed class Point
    {
        public float X, Y;
        public int PointID;

        public Point(float X, float Y, int PointID)
        {
            this.X = X;
            this.Y = Y;
            this.PointID = PointID;
        }
    }
}

