using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int Timerstate = 0;
    public int Player1Status = -1;
    public int Player2Status = -1;
    public float Player1Time = 0;
    public float Player2Time = 0;
    public float elapsedTime = 0;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
