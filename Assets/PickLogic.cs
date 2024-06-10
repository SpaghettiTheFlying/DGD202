using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickLogic : MonoBehaviour
{
    public GameObject RockOnPlayer;
    void Start()
    {
        RockOnPlayer.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (true)
            {
                this.RockOnPlayer.SetActive(false);
                RockOnPlayer.SetActive(false);
            }
        }
    }
}
