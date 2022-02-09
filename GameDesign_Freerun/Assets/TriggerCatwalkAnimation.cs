using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCatwalkAnimation : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void TriggerCurrentCatwalkAnimation()
    {
        _animator.SetTrigger("ShouldAllowPass");
    }

}
