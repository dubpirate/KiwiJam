 using UnityEngine;
 using System.Collections;
  
 public class PlayerMovement : MonoBehaviour
  
 {

      public float speed = 1.5f;
      public Rigidbody rigid;
      public float rotation = 90f;
        void Start()
        {

        }
         void Update ()
         {
            if (Input.GetKey(KeyCode.E) && transform.position.x > -720)
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.Q) && transform.position.x < 540)
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }

            if (Input. GetKeyDown ("a")) {
            transform. Rotate (0, rotation, 0);
            }
            if (Input. GetKeyDown ("d")) {
            transform. Rotate (0, -(rotation), 0);
            }

            if (Input. GetKeyDown ("w")) {
            transform. Rotate (rotation, 0, 0);
            }
            if (Input. GetKeyDown ("s")) {
            transform. Rotate ((rotation), 0, 0);
            }

        }
 }