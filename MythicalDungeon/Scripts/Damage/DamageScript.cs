using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    int Amountdamage;
    private void Update()
    {
        Amountdamage = CharacterStats.AmountDamege;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("урон");
            other.GetComponent<EnemyScript>().TakeDamege(Amountdamage);
        }
    }
}