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
    public Antlogic antlogic;
    public bool CamOn;
<<<<<<< HEAD
    public int spraysLeft = 3;
=======
    public int LastCam;
>>>>>>> 4279dc36c8e27ab64f9b0e38f96464f6e6ad271d
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicCode>();
        antlogic = GameObject.FindGameObjectWithTag("Ant").GetComponent<Antlogic>();
    }

    // Update is called once per frame
    void Update()
    {
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
    public void Bugspray()
    {
        if (spraysLeft == 0)
        {
            antlogic.sprayed();
            spraysLeft = spraysLeft - 1;
        }

    }


}
