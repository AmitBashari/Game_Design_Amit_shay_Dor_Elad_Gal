using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPointUI : MonoBehaviour
{
    public GameObject RespawnCanvas;
    public GameObject StartRoundCanvas;
    public GameObject Bottle;

    private bool _isFirstCheckPoint = true;


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "FirstRespawnPoint")
        {
                StartRoundCanvas.SetActive(true);
                Invoke(nameof(SetStartRunCanvasActiveFalse), 2f);
        }

        if (other.gameObject.tag == "RespawnPoint")
        {
            RespawnCanvas.SetActive(true);
            Invoke(nameof(SetCheckPointCanvasActiveFalse), 2f);
        }

        if (other.gameObject.tag == "Bottle")
        {
            Bottle.SetActive(true);
            Invoke(nameof(SetBottlesActiveFalse), 2f);
        }
    }

    private void SetCheckPointCanvasActiveFalse()
    {
        RespawnCanvas.SetActive(false);
    }

    private void SetStartRunCanvasActiveFalse()
    {
        StartRoundCanvas.SetActive(false);
    }
    private void SetBottlesActiveFalse()
    {
        Bottle.SetActive(false);
    }
}
