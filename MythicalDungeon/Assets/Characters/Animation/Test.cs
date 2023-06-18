using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public AnimationClip[] animations; // масив, в який будуть додані анімації


    private void Start()
    {
        Animator animator = GetComponent<Animator>();
        animations = new AnimationClip[2]; // створюємо масив з розміром 2
        for (int i = 0; i < animator.runtimeAnimatorController.animationClips.Length; i++)
        {
            // перевіряємо, чи назва анімації відповідає Attack1 або Attack2
            if (animator.runtimeAnimatorController.animationClips[i].name == "Armature|attack-loop" ||
                animator.runtimeAnimatorController.animationClips[i].name == "Attack2")
            {
                // додаємо анімацію до масиву
                animations[i] = animator.runtimeAnimatorController.animationClips[i];
            }
        }
    }
}
