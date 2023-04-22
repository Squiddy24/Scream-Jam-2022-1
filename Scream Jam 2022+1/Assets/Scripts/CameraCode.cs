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
    //public GameObject Static;
    public static bool CamOn;
    public float timeLeft = 5f;
    public GameObject static1;

    public int SprayPercentage = ButtonPressed.Percentage;

    public static int LastCam;

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
        SprayPercentage = ButtonPressed.Percentage;

        if (CamOn == true)
        {

            timeLeft -= 0.02f;

            if (timeLeft >= 0)
            {
                Camera.position = Camera.position + (Vector3.left * 0.5f * 0.02f);
            }
            if (timeLeft <= 0)
            {
                Camera.position = Camera.position + (Vector3.right * 0.5f * 0.02f);
            }
            if (timeLeft <= -7)
            {
                timeLeft = 7;

            }
           
        }
    }

    public void entercams()
    {
        //Static.SetActive(true);
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
            StartCoroutine(Static());
        }     
    }
    public void GoToRoom2()
    {
        if (LastCam != 2)
        {
            transform.position = Room2.position;
            LastCam = 2;
            timeLeft = 5;
            StartCoroutine(Static());
        }
    }
    public void GoToRoom3()
    {
        if (LastCam != 3)
        {
            transform.position = Room3.position;
            LastCam = 3;
            timeLeft = 5;
            StartCoroutine(Static());
        }
    }
    public void GoToRoom4()
    {
        if (LastCam != 4)
        {
            transform.position = Room4.position;
            LastCam = 4;
            timeLeft = 5;
            StartCoroutine(Static());
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
        if (SprayPercentage > 24)
        {
            antlogic.sprayed();
            if (Locust.dangerLVL > 0)
            {
                Locust.dangerLVL = 0;

            }
            ButtonPressed.Percentage = SprayPercentage - 25;
        }
        else
        {
            //lmao nothing
            // probably sould make a sound or smth
        }

    }
    public IEnumerator Static()
    {
        static1.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        static1.SetActive(false);
    }


}