using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GestuerRecognition
{
    public sealed class GestureTemplates
    {
        public  Gesture[] gestures;

        public GestureTemplates()
        {
            // Fire elements
            Point[] f1 = new Point[] { new Point(0, 0, 0), new Point(0, 1, 0), new Point(0, 2, 0), new Point(0, 3, 0), new Point(0, 4, 0), new Point(0, 5, 0), new Point(0, 6, 0), new Point(0, 7, 0), new Point(0, 8, 0), new Point(0, 9, 0), new Point(0, 10, 0) };
            Point[] f2 = new Point[] { new Point(0, 0, 0), new Point(1.5f, 2.5f, 0), new Point(3, 5, 0), new Point(2, 5, 0), new Point(1, 5, 0), new Point(0, 5, 0), new Point(-1, 5, 0), new Point(-2, 5, 0), new Point(-3, 5, 0), new Point(-1.5f, 7.5f, 0), new Point(0, 10, 0) };
            Point[] f3 = new Point[] { new Point(0, 0, 0), new Point(0, 5, 0), new Point(0, 10, 0), new Point(3, 7, 0), new Point(0, 5, 0), new Point(4, 2, 0) };
           // Air elements
            Point[] f4 = new Point[] { new Point(0, 0, 0), new Point(0, 2.5f, 0), new Point(0, 5, 0), new Point(0, 7.5f, 0), new Point(0, 10, 0), new Point(2, 8.5f, 0), new Point(4, 7, 0)};
            Point[] f5 = new Point[] { new Point(0, 0, 0), new Point(0, 2.5f, 0), new Point(0, 5, 0), new Point(0, 7.5f, 0), new Point(0, 10, 0), new Point(2, 8.5f, 0), new Point(4, 7, 0), new Point(2, 6, 0), new Point(1, 5.5f, 0)};
            Point[] f6 = new Point[] { new Point(0, 1, 0), new Point(1.5f, 2.5f, 0), new Point(3, 4, 0), new Point(6, 7, 0), new Point(4.5f, 8.5f, 0), new Point(3, 10, 0), new Point(1.5f, 8.5f, 0), new Point(0, 7, 0), new Point(4.5f, 2.25f, 0), new Point(6, 1, 0) };
            //Water elements
            Point[] f7 = new Point[] { new Point(4, 0, 0), new Point(0, 5, 0), new Point(4, 10, 0) };
            Point[] f8 = new Point[] { new Point(-3, 3, 0), new Point(0, 0, 0), new Point(0, 5, 0), new Point(0, 10, 0), new Point(3, 7, 0) };
            Point[] f9 = new Point[] { new Point(0, 0, 0), new Point(0, 2, 0), new Point(4, 0, 0), new Point(2, 3, 0), new Point(4, 2, 0), new Point(6, 1, 0), new Point(8, 0, 0), new Point(8, 2, 0), new Point(8, 4, 0), new Point(6, 3, 0), new Point(2, 1, 0) };
            //Earth elements

            Point[] f10 = new Point[] { new Point(0, 0, 0), new Point(0, 5, 0), new Point(0, 10, 0), new Point(3, 7.5f, 0), new Point(3, 5, 0), new Point(3, 0, 0) };
            Point[] f11 = new Point[] { new Point(0, 0, 0), new Point(0, 5, 0), new Point(0, 10, 0), new Point(3, 7, 0), new Point(6, 10, 0), new Point(6, 5, 0), new Point(6, 0, 0)};
            Point[] f12 = new Point[] { new Point(0, 0, 0), new Point(0, 5, 0), new Point(0, 10, 0), new Point(3, 7.5f, 0), new Point(0, 5, 0), new Point(3, 2.5f, 0), new Point(0, 0, 0) };

            gestures = new Gesture[] { new Gesture(f1, SpellName.FireOne), new Gesture(f2, SpellName.FireTwo), new Gesture(f3, SpellName.FireThree), 
                new Gesture(f4, SpellName.AirOne), new Gesture(f5, SpellName.AirTwo), new Gesture(f6, SpellName.AirThree),
                new Gesture(f7, SpellName.WaterOne), new Gesture(f8, SpellName.WaterTwo), new Gesture(f9, SpellName.WaterThree),
                new Gesture(f10, SpellName.EarthOne), new Gesture(f11, SpellName.EarthTwo), new Gesture(f12, SpellName.EarthThree)};
        }

    }

}

