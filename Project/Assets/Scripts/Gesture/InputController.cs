using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GestuerRecognition
{
    public delegate void FireSpellChanged(object value);
    public sealed class InputController
    {
        public ParticleSystem spellFaled;
        private readonly GestureTemplates gestureTemplates;
        private SpellName result;
        private List<Point> list;
        public bool isSpell;
        private bool isFire;

        public event EventHandler<SpellName> HappenedSpell;

        public InputController(GestureTemplates _gestureTemplates)
        {
            var gameObject = GameObject.FindGameObjectWithTag("SpellFailed");
            spellFaled = gameObject.GetComponent<ParticleSystem>();
            gestureTemplates = _gestureTemplates;
            isSpell = false;
            isFire = false;
        }
        public void Execute()
        {
            if (Input.GetMouseButtonDown(1))
            {
                if (isFire)
                {
                    Fire();
                }
            }
            if (Input.GetMouseButtonDown(0))
            {
                list = new List<Point>(); 
            }

            if (Input.GetMouseButton(0))
            {
                list.Add(new Point(Input.mousePosition.x, Input.mousePosition.y, 0));
            }
            if (Input.GetMouseButtonUp(0) && LengthList(list) && !isSpell)
            {
                var gesture = new Gesture(list.ToArray());
                result = PointCloudRecognizer.Classify(gesture, gestureTemplates.gestures);
                if (result != 0)
                {
                    Interaction();
                }
                else
                {
                    spellFaled.Play();
                }
            }
     
        }

        public void Fire()
        {
            EventBroker.CallSpellPerformed();
            isFire = false;
            isSpell = false;
        }

        public void Interaction()
        {
            HappenedSpell(this, result);
            isSpell = true;
            isFire = true;
        }

        //private bool Distance(Point a, Point b)
        //{
        //    float d = Geometry.Distance(a, b);
        //    return Geometry.Distance(a, b) > 150 ;

        //}

        private bool LengthList(List<Point> list)
        {
            var arr = list.ToArray();
            float length = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                float d = Geometry.Distance(list[i - 1], list[i]);
                length += d;
            }
            return length > 300;
        }
    }
}

