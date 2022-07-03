using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject PassButton;
    public GameObject Player1_Time;
    public GameObject Player2_Time;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.Timerstate == 0)
        {
            GameManager.instance.Player1Status = -1;
            GameManager.instance.Player2Status = -1;
            GameManager.instance.Player1Time = 0;
            GameManager.instance.Player2Time = 0;
            GameManager.instance.elapsedTime = 0;
            ButtonActive();
        }
    }
    
    void ButtonActive()
    {
        gameObject.GetComponent<Defense>().enabled = false;
        button1.SetActive(true);
        button2.SetActive(true);
        Player1_Time.SetActive(false);
        Player2_Time.SetActive(false);
        PassButton.SetActive(false);

        return;
    }
}
