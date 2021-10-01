using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform teleportTarget;
    

    void OnTriggerEnter(Collider other)
    {
        other.transform.position = teleportTarget.transform.position;
        other.GetComponent<Rigidbody>().velocity = Vector2.zero;
    }
}
