using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lab.PlayerMovement
{
    public class PlayerMovement : MonoBehaviour
    {
        public float SPEED = 1;

        void Start()
        {

        }

        void Update()
        {
            (float inputX, float inputY) = (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

            gameObject.transform.position += new Vector3(
                inputX * SPEED * Time.deltaTime,
                inputY * SPEED * Time.deltaTime,
                0
            );
        }
    }
}