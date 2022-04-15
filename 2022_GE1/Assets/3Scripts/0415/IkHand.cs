using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class IkHand : MonoBehaviour
{
    private Animator _animator;

    public Transform handPosition;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    
    private void OnAnimatorIK()
    {
        _animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
        _animator.SetIKPosition(AvatarIKGoal.RightHand, handPosition.position);
        _animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);
        _animator.SetIKRotation(AvatarIKGoal.RightHand, handPosition.rotation);
    }
}
