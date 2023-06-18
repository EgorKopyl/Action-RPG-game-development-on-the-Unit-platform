using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

        public float velocity = 1.0f;
        public FixedJoystick joystick;
    void Start()
        {

        }


        void Update()
        {
            transform.position += new Vector3(velocity * -joystick.Direction.x * Time.deltaTime, 0, velocity * -joystick.Direction.y * Time.deltaTime);
    }
    }

