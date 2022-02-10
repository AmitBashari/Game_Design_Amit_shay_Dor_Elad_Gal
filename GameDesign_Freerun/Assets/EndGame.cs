using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField]
    private GameObject _canvas;

    [SerializeField]
    private GameObject _player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("I hit player");
            _player.GetComponent<Rigidbody>().isKinematic = true;
            _canvas.SetActive(true);

        }
    }


}
