using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField]
    private Transform _currentRespawnPoint;

    private void SetNewRespawnPoint(Transform respawnPoint)
    {
        _currentRespawnPoint = respawnPoint;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RespawnPoint")
        {
            SetNewRespawnPoint(other.gameObject.transform);

            Debug.Log("I hit a respawn point");
        }
    }

    public void MovePlayerToLastCheckpoint()
    {
        gameObject.transform.position = _currentRespawnPoint.position;
        gameObject.transform.rotation = _currentRespawnPoint.rotation;
    }
    

    

}
