using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackButton : MonoBehaviour
{
    public Animator animator;
    public void onDown()
    {
        animator.SetBool("Attak", true);
    }
    public void onUp()
    {
        animator.SetBool("Attak", false);
    }
}
