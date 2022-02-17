using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AkwardHEYCHECKPOINT : MonoBehaviour
{

    private MeshRenderer _meshRenderer;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            _meshRenderer.enabled = true;
        }
    }
}
