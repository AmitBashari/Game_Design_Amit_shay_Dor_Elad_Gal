using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveLastBarrier : MonoBehaviour
{

    public GameObject LastBarrier;

    public GameObject Arrow;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Arrow.SetActive(true);

            LastBarrier.SetActive(false);
            gameObject.SetActive(false);
        }
    }

    private void BarrierUnlocked()
    {

    }

}
