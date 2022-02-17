using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTIltedPlatfromResetPosition : MonoBehaviour
{
    public GameObject OriginalTiltPlatform;

    private Transform _transform;

    private void Start()
    {
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Invoke(nameof(ResetPlatformTransorm), 3f);
        }
    }

    private void ResetPlatformTransorm()
    {
        Instantiate(OriginalTiltPlatform, OriginalTiltPlatform.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
