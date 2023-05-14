using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] public FixedJoystick joystick;

    void Update()
    {
        Vector3 moveVector = (Vector3.up * joystick.Horizontal + Vector3.right * joystick.Vertical);
        if (joystick.Horizontal !=0 || joystick.Vertical !=0)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, moveVector);
        }
    }
}
