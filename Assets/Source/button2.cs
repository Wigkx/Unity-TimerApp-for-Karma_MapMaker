using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button2 : MonoBehaviour
{
    public GameObject button1;
    public GameObject Player1_Time;
    public GameObject Player2_Time;
    public void onButtonClick()
    {
        GameManager.instance.Player1Status = 0;
        GameManager.instance.Player2Status = 1;
        GameManager.instance.Timerstate = 1;

        // Debug.Log(GameManager.instance.Player2Status);
        
        Player1_Time.SetActive(true);
        Player2_Time.SetActive(true);
        GameObject.Find("Square").GetComponent<Defense>().enabled = true;
        button1.SetActive(false);
        gameObject.SetActive(false);
    }
}
