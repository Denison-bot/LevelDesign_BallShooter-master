using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
    
{
    private GameObject gameManager;
    private GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindWithTag("GameController");
        _gameManager = gameManager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _gameManager.ResetBallPos();
    }
}
