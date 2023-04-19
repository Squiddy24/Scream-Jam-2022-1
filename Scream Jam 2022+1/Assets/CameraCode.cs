using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraCode : MonoBehaviour
{
    public Transform Office;
    public Transform Room1;
    public Transform Room2;
    public Transform Room3;
    public Transform Room4;
    public LogicCode logic;
    public Antlogic antlogic;
    public Transform Camera;
    public bool CamOn;
    public float timeLeft = 5f;

    public int spraysLeft = 3;

    public int LastCam;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicCode>();
        antlogic = GameObject.FindGameObjectWithTag("Ant").GetComponent<Antlogic>();
        LastCam = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(CamOn == true)
        {

            timeLeft -= Time.deltaTime;

            if (timeLeft >= 0)
            {
                Camera.position = Camera.position + (Vector3.left * 0.5f * Time.deltaTime);
            }
            if (timeLeft <= 0)
            {
                Camera.position = Camera.position + (Vector3.right * 0.5f * Time.deltaTime);
            }
            if (timeLeft <= -7)
            {
                timeLeft = 7;

            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (CamOn == true)
                {
                    LeaveCams();
                    transform.position = Room1.position;
                }
                else
                {
                    entercams();
                }
            }
        }
    }

    public void entercams()
    {
        transform.position = Room1.position;
        logic.CamsOn();
        CamOn = true;
        timeLeft = 5;
        if(LastCam == 1)
        {
            transform.position = Room1.position;
            LastCam = 1;
            timeLeft = 5;
        }
        if (LastCam == 2)
        {
            transform.position = Room2.position;
            LastCam = 2;
            timeLeft = 5;
        }
        if (LastCam == 3)
        {
            transform.position = Room3.position;
            LastCam = 3;
            timeLeft = 5;
        }
        if (LastCam == 4)
        {
            transform.position = Room4.position;
            LastCam = 4;
            timeLeft = 5; 
        }
    }
    public void GoToRoom1()
    {
        if (LastCam != 1)
        {
            transform.position = Room1.position;
            LastCam = 1;
            timeLeft = 5;
        }     
    }
    public void GoToRoom2()
    {
        if (LastCam != 2)
        {
            transform.position = Room2.position;
            LastCam = 2;
            timeLeft = 5;
        }
    }
    public void GoToRoom3()
    {
        if (LastCam != 3)
        {
            transform.position = Room3.position;
            LastCam = 3;
            timeLeft = 5;
        }
    }
    public void GoToRoom4()
    {
        if (LastCam != 4)
        {
            transform.position = Room4.position;
            LastCam = 4;
            timeLeft = 5;
        }
    }
    public void LeaveCams()
    {
        transform.position = Office.position;
        logic.LeaveCams();
        CamOn = false;
    }
    public void Bugspray()
    {
        if (spraysLeft > 0)
        {
            antlogic.sprayed();
            spraysLeft = spraysLeft - 1;
        }
        else
        {
            //lmao nothing
            // probably sould make a sound or smth
        }

    }


}
