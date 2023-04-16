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
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicCode>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void entercams()
    {   
            transform.position = Office.position;
            logic.CamsOn();      
    }
    public void GoToRoom1()
    {
        transform.position = Room1.position;
    }
    public void GoToRoom2()
    {
        transform.position = Room2.position;
    }
    public void LeaveCams()
    {
        transform.position = Office.position;
        logic.LeaveCams();
    }

}
