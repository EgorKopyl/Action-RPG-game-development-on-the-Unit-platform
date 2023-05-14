using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    public int HP = 100;
    public Animator animator;
    public Slider HealthBar;

    void Update()
    {
        HealthBar.value = HP;
    }
    public void TakeDamege(int Amountdamage)
    {
        HP -= Amountdamage;
        if (HP <= 0)
        {
            animator.SetTrigger("DeathEnemy");
            Destroy(gameObject, 2f);
            GetComponent<Collider>().enabled = false;
            HealthBar.gameObject.SetActive(false);
        }
    }
}
