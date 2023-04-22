using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Time : MonoBehaviour
{

    public int hour = 12;
    public Text TimeText;
    public bool hour1triggerd = false;
    public bool hour2triggerd = false;
    public bool hour3triggerd = false;
    public bool hour4triggerd = false;
    public bool hour5triggerd = false;

    // Start is called before the first frame update
    void Start()
    {
        Antlogic.AntDifficulty = 3;
        Locust.LocustDifficulty = 0;
        ScarecrowLogic.ScarecrowDifficulty = 0;

        StartCoroutine(TimePassing());
    }

    // Update is called once per frame
    void Update()
    {
        //Hour 1
        if (hour == 1 && hour1triggerd == false)
        {
            Antlogic.AntDifficulty = 6;
            Locust.LocustDifficulty = 3;
            ScarecrowLogic.ScarecrowDifficulty = 0;
            hour1triggerd = true;
        }

        //Hour 2
        if (hour == 2 && hour2triggerd == false)
        {
            Antlogic.AntDifficulty = 7;
            Locust.LocustDifficulty = 5;
            ScarecrowLogic.ScarecrowDifficulty = 1;
            hour2triggerd = true;
        }

        //Hour 3
        if (hour == 3 && hour3triggerd == false)
        {
            Antlogic.AntDifficulty = 9;
            Locust.LocustDifficulty = 6;
            ScarecrowLogic.ScarecrowDifficulty = 5;
            hour3triggerd = true;
        }

        //Hour 4
        if (hour == 4 && hour4triggerd == false)
        {
            Antlogic.AntDifficulty = 6;
            Locust.LocustDifficulty = 9;
            ScarecrowLogic.ScarecrowDifficulty = 7;
            hour4triggerd = true;
        }

        //Hour 5
        if (hour == 5 && hour5triggerd == false)
        {
            Antlogic.AntDifficulty = 13;
            Locust.LocustDifficulty = 12;
            ScarecrowLogic.ScarecrowDifficulty = 10;
            hour5triggerd = true;
        }
    }

    public IEnumerator TimePassing()
    {
        yield return new WaitForSeconds(60);
        hour += 1;
        TimeText.text = hour.ToString() + " AM";
        StartCoroutine(TimePassing());
        if (hour == 6)
        {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene("WinScreen");
        }
    }


}
