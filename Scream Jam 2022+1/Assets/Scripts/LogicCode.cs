using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicCode : MonoBehaviour
{
    public GameObject Camera_UI;
    public GameObject Entercams_UI;
    public GameObject bugspray_UI;
    public GameObject scarecrowscare;
    public bool cameraon = false;
    public bool yadead = false;
    public bool Gameover = false;
    public CameraCode Camera;
    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraCode>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraon == false && yadead == true)
        {
            Gameover = true;
        }
    }
    public void CamsOn()
    {
        Camera_UI.SetActive(true);
        Entercams_UI.SetActive(false);
        bugspray_UI.SetActive(false);
        cameraon = true;
    }
    public void LeaveCams()
    {
        Camera_UI.SetActive(false);
        Entercams_UI.SetActive(true);
        bugspray_UI.SetActive(true);
        cameraon = false;
    }
    public void gameover()
    {
        
    }
    public void scarecrowjump()
    {
        if (cameraon == true)
        {
            scarecrowscare.SetActive(true);
            yadead = true;
            Camera_UI.SetActive(false);
            Entercams_UI.SetActive(true);
            bugspray_UI.SetActive(true);
            cameraon = false;
            Camera.LeaveCams();

        }
    }

}
