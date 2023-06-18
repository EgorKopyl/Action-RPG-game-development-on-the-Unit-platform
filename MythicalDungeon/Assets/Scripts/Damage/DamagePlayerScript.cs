using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayerScript : MonoBehaviour
{
    public int damege = 20;
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<CharacterStats>().TakeDamage(damege);
        }
    }
}
