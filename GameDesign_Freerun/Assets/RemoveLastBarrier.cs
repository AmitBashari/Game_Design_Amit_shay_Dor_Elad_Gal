using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveLastBarrier : MonoBehaviour
{

    public GameObject _lastBarrier;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _lastBarrier.SetActive(false);
            gameObject.SetActive(false);
        }
    }

}
