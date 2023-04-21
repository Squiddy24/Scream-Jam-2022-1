using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locust : MonoBehaviour
{
    public ParticleSystem Locustparticals;
    public int emissionRate;
    public float timeLeft;
    public int LocustDifficulty;
    public static int dangerLVL;
    public LogicCode logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicCode>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(dangerLVL);
        timeLeft -= 0.02f;
        if (timeLeft <= 0)
        {
            int randomNumber = Random.Range(1, 22);
            timeLeft = 5;
            if (LocustDifficulty >= randomNumber)
            {
                if (CameraCode.CamOn == true && CameraCode.LastCam == 1)
                {

                    Debug.Log("BLOCKED :)))");
                }
                else
                {
                    emissionRate += 50;
                    dangerLVL += 1;
                    var emission = Locustparticals.emission;
                    emission.rateOverTime = emissionRate;
                }
                
            }
        }
        if (dangerLVL >= 5)
        {
            logic.locustsjump();
        }
    }
}
