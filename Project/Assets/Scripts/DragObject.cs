using System.Collections;
using System.Collections.Generic;
using UnityEngine;


   public class DragObject : MonoBehaviour
   {
        private Vector3 offset; 
        private float zMove;
        private Rigidbody RB;
        private Vector3 mousePosition;
       
        
        private void Awake()
        {
            RB = GetComponent<Rigidbody>();
        }

        private void OnMouseDown()
        {
            zMove = Camera.main.WorldToScreenPoint(transform.position).z;
            offset = transform.position - GetMouseInWorld();
            RB.isKinematic = true;

        }

        private void OnMouseUp()
        {
            RB.isKinematic = false;
        }

        Vector3 GetMouseInWorld()
        {
            mousePosition = Input.mousePosition;
            zMove += Input.GetAxis("Mouse ScrollWheel") * 5f;
            mousePosition.z = zMove;
            return Camera.main.ScreenToWorldPoint(mousePosition);
        }


        private void OnMouseDrag()
        {
            transform.position = GetMouseInWorld()+ offset;
        }
    }


