using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{

    public int hour = 12;
    public Text TimeText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimePassing());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator TimePassing()
    {
        yield return new WaitForSeconds(120);
        hour += 1;
        TimeText.text = hour.ToString() + " AM";
        StartCoroutine(TimePassing());
    }


}
