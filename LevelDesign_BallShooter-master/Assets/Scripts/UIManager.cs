using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //Script references
    public GameObject ball;
    private BallController _ballController;

    //private GameObject gameManager;
    //private GameManager _gameManager;


    public Text modeText;    
    public Text ShotsLeftCount;

    public Text LevelCount;
    
    public void UpdateShotsleft(int count)
    {        
        ShotsLeftCount.text = count.ToString();
    }

    public void UpdateLevelCount(int count)
    {
        LevelCount.text = count.ToString();
    }
        


}
