using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ShipMove : MonoBehaviour
{    
        public float speed;
        public float tilt;
        public Boundary boundary;
        public Rigidbody ship;

      
    //Le otorga movimiento a la nave en los ejes x, y. Con un efecto de inclinación
        void FixedUpdate()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
            ship.velocity = movement * speed;

            ship.position = new Vector3
            (
                Mathf.Clamp(ship.position.x, boundary.xMin, boundary.xMax),
                Mathf.Clamp(ship.position.y, boundary.yMin, boundary.yMax),
                0.0f
            );

            ship.rotation = Quaternion.Euler(0.0f, 0.0f, ship.velocity.x * -tilt);
        }

}

