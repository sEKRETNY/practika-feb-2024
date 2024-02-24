using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarInteraction : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    void Start()
    {
        _animator.speed = 0;
    }

    public void AnimationOnOff()
    {
        if (_animator.speed <= 0)
            _animator.speed = 0.5f;
        else if (_animator.speed > 0)
            _animator.speed = 0;
    }
}