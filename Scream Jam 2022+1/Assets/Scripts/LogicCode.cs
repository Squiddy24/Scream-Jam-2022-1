using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicCode : MonoBehaviour
{
    public GameObject Camera_UI;
    public GameObject Entercams_UI;
    public GameObject bugspray_UI;
    public GameObject scarecrowscare;
    public Image shake;
    public Text shaketext;
    public bool cameraon = false;
    public bool yadead = false;
    public bool Gameover = false;
    public CameraCode Camera;
    public GameObject Antscare;
    public GameObject locustscare;
    public GameObject office;
    public GameObject UI;
    public GameObject static1;
    public AudioSource ScarecrowLeaving;
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
            StartCoroutine(Death());
        }
        if (yadead == true)
        {
            
        }
    }
    public void CamsOn()
    {
        Camera_UI.SetActive(true);
        Entercams_UI.SetActive(false);
        bugspray_UI.SetActive(false);
        cameraon = true;
        shake.enabled = false;
        shaketext.enabled = false;
        StartCoroutine(Static());
    }
    public void LeaveCams()
    {
        Camera_UI.SetActive(false);
        Entercams_UI.SetActive(true);
        bugspray_UI.SetActive(true);
        cameraon = false;
        shake.enabled = true;
        shaketext.enabled = true;
        StartCoroutine(Static());
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
            Entercams_UI.SetActive(false);
            bugspray_UI.SetActive(false);
            office.SetActive(false);
            cameraon = false;
            Camera.LeaveCams();
            UI.SetActive(false);
            StartCoroutine(Static());
            StartCoroutine(Death());
        }
        else
        {
            ScarecrowLeaving.Play();
        }
    }
    public void antjump()
    {
        Antscare.SetActive(true);
        UI.SetActive(false);
        office.SetActive(false);
        yadead = true;
        Camera.LeaveCams();
    }
    public void locustsjump()
    {
        locustscare.SetActive(true);
        yadead = true;
        UI.SetActive(false);
        cameraon = false;
        office.SetActive(false);
        Camera.LeaveCams();
    }
    public IEnumerator Death()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Dead");
    }
    public IEnumerator Static()
    {
        static1.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        static1.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        if (yadead == true)
        {
            StartCoroutine(Static());
        }
    }
    


}