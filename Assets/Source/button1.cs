using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : MonoBehaviour
{
    public GameObject button2;
    public GameObject Player1_Time;
    public GameObject Player2_Time;
    public void onButtonClick()
    {
        GameManager.instance.Player1Status = 1;
        GameManager.instance.Player2Status = 0;
        GameManager.instance.Timerstate = 1;

        // Debug.Log(GameManager.instance.Player1Status);

        Player1_Time.SetActive(true);
        Player2_Time.SetActive(true);
        GameObject.Find("Square").GetComponent<Defense>().enabled = true;
        button2.SetActive(false);
        gameObject.SetActive(false);
    }
}
