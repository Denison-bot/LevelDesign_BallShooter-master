using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumppad : MonoBehaviour
{
    public int speed;
    private void OnTrigger()
    {
       
            gameObject.GetComponent<Rigidbody>
                ().AddForce(Vector3.up * speed);
        
    }
}
