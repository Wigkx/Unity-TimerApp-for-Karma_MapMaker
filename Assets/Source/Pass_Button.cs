using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pass_Button : MonoBehaviour
{
    public void onButtonClick()
    {
        if (GameManager.instance.Timerstate == 1)
        {
            GameObject.Find("Square").GetComponent<Defense>().enabled = false;
            GameObject.Find("Square").GetComponent<Attack>().enabled = true;
            GameManager.instance.Timerstate++;
        }
        else
            GameManager.instance.Timerstate = 0;
    }
}
