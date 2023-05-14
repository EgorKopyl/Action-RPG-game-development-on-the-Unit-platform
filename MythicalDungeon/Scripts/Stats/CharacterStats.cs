using UnityEngine;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth { get; private set; }
    public Stats statDamage;
    public Stats statArmor;
    public static int AmountDamege;
    public Animator animator;
    public Slider PlayerHealthBar;

    void Awake()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
       if(Input.GetKeyUp(KeyCode.T))
        {
            TakeDamage(10);
        }
        AmountDamege = statDamage.GetValue();
    }
    public void TakeDamage (int damage)
    {
        damage -= statArmor.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);

        currentHealth -= damage;
        PlayerHealthBar.value = currentHealth;
        Debug.Log(transform.name + "takes" + damage + " damage.");
        if(currentHealth <= 0)
        {
            Die();
        }
        return;
    }   
    public virtual void Die()
    {
        Debug.Log(transform.name + " died.");
        animator.SetTrigger("Death");
    }
}
