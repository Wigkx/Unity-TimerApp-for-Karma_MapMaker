using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    public Text Player1_Time;
    public Text Player2_Time;
    public GameObject Player1_T;
    public GameObject Player2_T;
    public int attack;
    // Start is called before the first frame update
    void OnEnable()
    {
        Player1_Time = GameObject.Find("Player1_Time").GetComponent<Text>();
        Player2_Time = GameObject.Find("Player2_Time").GetComponent<Text>();
        if (GameManager.instance.Player1Status == 0)
        {
            Player1_T.SetActive(false);
            GameManager.instance.Player2Time += GameManager.instance.elapsedTime;
            attack = 2;
        } 
        else {
            Player2_T.SetActive(false);
            GameManager.instance.Player1Time += GameManager.instance.elapsedTime;
            attack = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (attack == 1)
        {
            GameManager.instance.Player1Time -= Time.deltaTime * 1.1f;
            Player1_Time.text = Mathf.RoundToInt(GameManager.instance.Player1Time).ToString();
            if (GameManager.instance.Player1Time <= 0)
                TimeEnd();
        }
        else
        {
            GameManager.instance.Player2Time -= Time.deltaTime;
            Player2_Time.text = Mathf.RoundToInt(GameManager.instance.Player2Time).ToString();
            if (GameManager.instance.Player2Time <= 0)
                TimeEnd();
        }
    }

    void TimeEnd()
    {
        GameManager.instance.Timerstate = 0;
        GameObject.Find("Square").GetComponent<Attack>().enabled = false;

        return;
    }
}
