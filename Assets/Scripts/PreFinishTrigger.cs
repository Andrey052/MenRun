using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerBehaviour playerBehavior = other.attachedRigidbody.GetComponent<PlayerBehaviour>();

        if (playerBehavior)
        {
            playerBehavior.StartPreFinishBehaviour();
        }
    }
}
