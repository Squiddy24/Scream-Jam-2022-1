using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(HomeScreem());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator HomeScreem()
    {
        yield return new WaitForSeconds(11);
        SceneManager.LoadScene("Title Screen");
    }

}
