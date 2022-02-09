using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private PlayerRespawn _playerRespawn;

    private void Awake()
    {
        _playerRespawn = GetComponent<PlayerRespawn>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Death")
        {
            _playerRespawn.MovePlayerToLastCheckpoint();
            Debug.Log("Player Is Dead");
        }
    }

}
