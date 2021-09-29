using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
// this script is added to the Gamemanager object 
// it sets itself, and all childer as a Single Instance
// When a new scene is loaded the object with this script (and all children)
// will not be deleted.
// allows you to carry main functionality objects between scenes

    static Singleton Instance;


    void Start()
    {
        if (Instance != null)
        {
            GameObject.Destroy(gameObject);
        }
        else
        {
            GameObject.DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }

 
}
