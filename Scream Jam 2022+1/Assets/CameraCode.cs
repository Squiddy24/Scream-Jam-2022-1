using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraCode : MonoBehaviour
{
    public Transform Office;
    public Transform Room1;
    public Transform Room2;
    public LogicCode logic;
    public bool CamOn;
    public int LastCam;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicCode>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (CamOn == true)
            {
                LeaveCams();
            }
            else
            {
                entercams();
            }
        }
    }

    public void entercams()
    {   
            transform.position = Office.position;
            logic.CamsOn();
        CamOn = true;
    }
    public void GoToRoom1()
    {
        transform.position = Room1.position;
        LastCam = 1
    }
    public void GoToRoom2()
    {
        transform.position = Room2.position;
        LastCam = 2

    }
    public void LeaveCams()
    {
        transform.position = Office.position;
        logic.LeaveCams();
        CamOn = false;


    }

}
