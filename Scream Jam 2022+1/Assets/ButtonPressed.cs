using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonPressed : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public bool buttonPressed;
    public static int Percentage = 100;
    public Text PercentageTest;
    public RectTransform BugSprayImg;
    // Start is called before the first frame update
    void Start()
    {
       
        StartCoroutine(PercentageAdder());
    }

    // Update is called once per frame
    void Update()
    {
        PercentageTest.text = Percentage.ToString() + "%";
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }

    public IEnumerator PercentageAdder()
    {
        while (true)
        {
            while (buttonPressed)
            {
                if (Percentage < 100)
                {
                    Percentage += 1;
                    BugSprayImg.localPosition = new Vector3(254.5462f, -50.04219f, 0f);
                }
                yield return new WaitForSeconds(0.1f);
                BugSprayImg.localPosition = new Vector3(254.5462f, -58.04219f, 0f);
                yield return new WaitForSeconds(0.1f);
                BugSprayImg.localPosition = new Vector3(254.5462f, -50.04219f, 0f);
                yield return new WaitForSeconds(0.1f);
                BugSprayImg.localPosition = new Vector3(254.5462f, -58.04219f, 0f);
                yield return new WaitForSeconds(0.1f);
                BugSprayImg.localPosition = new Vector3(254.5462f, -50.04219f, 0f);
                yield return new WaitForSeconds(0.1f);
                BugSprayImg.localPosition = new Vector3(254.5462f, -58.04219f, 0f);
                yield return new WaitForSeconds(0.1f);



            }
            yield return new WaitForEndOfFrame();
        }
        
    }

}