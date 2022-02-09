using UnityEngine;

public class OpenGate : MonoBehaviour
{
    [SerializeField]
    private GameObject _gate;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "TriggerPlatform")
        {
            Debug.Log("I Hit Trigger");
            _gate.GetComponent<Animator>().SetBool("ShouldOpenGate", true);
        }
    }
}
