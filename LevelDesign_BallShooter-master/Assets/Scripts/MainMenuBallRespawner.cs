using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBallRespawner : MonoBehaviour
{
    public GameObject ball;
    public int StartingBalls = 40;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < StartingBalls; i++)
        {
            int RandomX = Random.Range(-25, 25);
            int RandomY = Random.Range(0, 150);
            int RandomZ = Random.Range(-22, -30);

            GameObject go = Instantiate(ball, new Vector3(RandomX, RandomY, RandomZ), transform.rotation);
            
            go.GetComponentInChildren<MeshRenderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {        
        Destroy(other.gameObject);

        int RandomX = Random.Range(-25, 25);
        int RandomY = Random.Range(0, 25);
        int RandomZ = Random.Range(-27, -30);
                

        GameObject go = Instantiate(ball, new Vector3(RandomX, RandomY, RandomZ), transform.rotation);

        go.GetComponentInChildren<MeshRenderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));


    }


}
