using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerBehaviour playerBehavior = other.attachedRigidbody.GetComponent<PlayerBehaviour>();

        if (playerBehavior)
        {
            playerBehavior.StartFinishBehaviour();

            FindObjectOfType<GameManager>().ShowFinishWindiw();
        }
    }
}
