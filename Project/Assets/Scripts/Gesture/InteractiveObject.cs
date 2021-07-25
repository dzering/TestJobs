using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GestuerRecognition
{
    public abstract class InteractiveObject : MonoBehaviour
    {
        private bool isInteracible;


        //private void OnTriggerEnter(Collider other)
        //{
        //    if (!isInteracible || other.CompareTag("Player"))
        //    {
        //        return;
        //    }
        //    //isInteracible = false;
        //    //Interaction();
        //}

        protected abstract void Interaction();

        private void Start()
        {
            isInteracible = true;
        }

    }
}

