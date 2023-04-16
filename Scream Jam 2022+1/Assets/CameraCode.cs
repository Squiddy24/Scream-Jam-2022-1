using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCode : MonoBehaviour
{
    public Transform Office;
    public Transform Room1;
    public Transform Room2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void GoToRoom1()
    {
        transform.position = Room1.position;
    }
    public void GoToRoom2()
    {
        transform.position = Room2.position;
    }
    public void GoToOffice()
    {
        transform.position = Office.position;
    }

}
