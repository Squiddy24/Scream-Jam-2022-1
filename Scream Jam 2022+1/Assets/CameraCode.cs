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
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft >= 0)
        {
            Camera.position = Camera.position + (Vector3.left * 1 * Time.deltaTime);
        }
        if (timeLeft <= 0)
        {
            Camera.position = Camera.position + (Vector3.right * 1 * Time.deltaTime);
        }
        if (timeLeft <= -10)
        {
            timeLeft = 10;

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

    public void entercams()
    {
        transform.position = Room1.position;
        logic.CamsOn();
        CamOn = true;
    }
    public void GoToRoom1()
    {
        transform.position = Room1.position;
        LastCam = 1;
    }
    public void GoToRoom2()
    {
        transform.position = Room2.position;
        LastCam = 2;

    }
    public void GoToRoom3()
    {
        transform.position = Room3.position;
        LastCam = 3;
    }
    public void GoToRoom4()
    {
        transform.position = Room4.position;
        LastCam = 4;

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
        }

    }


}
