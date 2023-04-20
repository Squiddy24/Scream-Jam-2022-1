using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicCode : MonoBehaviour
{
    public GameObject Camera_UI;
    public GameObject Entercams_UI;
    public GameObject bugspray_UI;
    public bool Gameover = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CamsOn()
    {
        Camera_UI.SetActive(true);
        Entercams_UI.SetActive(false);
        bugspray_UI.SetActive(false);
    }
    public void LeaveCams()
    {
        Camera_UI.SetActive(false);
        Entercams_UI.SetActive(true);
        bugspray_UI.SetActive(true);
    }
    public void gameover()
    {
        Gameover = true;
    }
}
