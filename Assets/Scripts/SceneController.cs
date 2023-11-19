using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public static SceneController Instance;
    public LevelGenerator levelGenerator;
    public PlayerMovement playerMovement;
    public GameManager gameManager;
    public RateTrigger rateTrigger;
    public RangeTrigger rangeTrigger;
    public BulletTrigger bulletTrigger;
    public GetPrize getPrize;
    public MoveBullet moveBullet;
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }

       
        gameManager.Init();
        playerMovement.Init();
        bulletTrigger.Init();
        rateTrigger.Init();
        rangeTrigger.Init();
        getPrize.Init();
        //moveBullet.Init();
        levelGenerator.Init();
    }
}
