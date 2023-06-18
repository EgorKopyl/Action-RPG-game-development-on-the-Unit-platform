using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public AnimationClip[] animations; // �����, � ���� ������ ����� �������


    private void Start()
    {
        Animator animator = GetComponent<Animator>();
        animations = new AnimationClip[2]; // ��������� ����� � ������� 2
        for (int i = 0; i < animator.runtimeAnimatorController.animationClips.Length; i++)
        {
            // ����������, �� ����� ������� ������� Attack1 ��� Attack2
            if (animator.runtimeAnimatorController.animationClips[i].name == "Armature|attack-loop" ||
                animator.runtimeAnimatorController.animationClips[i].name == "Attack2")
            {
                // ������ ������� �� ������
                animations[i] = animator.runtimeAnimatorController.animationClips[i];
            }
        }
    }
}
