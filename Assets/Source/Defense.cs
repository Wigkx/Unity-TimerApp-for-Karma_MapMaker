using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Defense : MonoBehaviour
{
    public Text Player1_Time;
    public Text Player2_Time;
    public GameObject Pass_Button;
    public int defense;
    // Start is called before the first frame update
    void OnEnable()
    {
        Player1_Time = GameObject.Find("Player1_Time").GetComponent<Text>();
        Player2_Time = GameObject.Find("Player2_Time").GetComponent<Text>();
        Pass_Button.SetActive(true);
        if (GameManager.instance.Player1Status == 1)
        {
            GameManager.instance.Player1Time = 30;
            GameManager.instance.Player2Time = 120;
            defense = 2;
        }
        else
        {
            GameManager.instance.Player1Time = 120;
            GameManager.instance.Player2Time = 30;
            defense = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (defense == 1)
        {
            GameManager.instance.Player1Time -= Time.deltaTime * 1.1f;
            GameManager.instance.elapsedTime += Time.deltaTime * 1.1f;
        }
        else
        {
            GameManager.instance.Player2Time -= Time.deltaTime;
            GameManager.instance.elapsedTime += Time.deltaTime;
        }

        Player1_Time.text = Mathf.RoundToInt(GameManager.instance.Player1Time).ToString();
        Player2_Time.text = Mathf.RoundToInt(GameManager.instance.Player2Time).ToString();

        if (GameManager.instance.Player1Time <= 0 || GameManager.instance.Player2Time <= 0)
            TimeEnd();
    }



    void TimeEnd()
    {
        GameManager.instance.elapsedTime = 120;
        GameManager.instance.Timerstate = 2;
        GameObject.Find("Square").GetComponent<Attack>().enabled = true;
        gameObject.GetComponent<Defense>().enabled = false;

        return;
    }
}
