using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleAnimationTrigger : MonoBehaviour
{
    private Animator _animator;

    [SerializeField]
    private TriggerCatwalkAnimation _tirggerCatWalkAnimation;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("I trigger Hangdle");
            _animator.SetTrigger("TriggerHandle");

            _tirggerCatWalkAnimation.TriggerCurrentCatwalkAnimation();
        }
    }

}
