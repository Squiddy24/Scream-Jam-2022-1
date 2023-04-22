using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locust : MonoBehaviour
{
    public ParticleSystem Locustparticals;
    public int emissionRate;
    public float timeLeft;
    public static int LocustDifficulty;
    public static int dangerLVL;
    public LogicCode logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicCode>();
        emissionRate = 30;
        dangerLVL = 0;
        LocustDifficulty = 0;
    }

    // Update is called once per frame
    void Update()
    {
        var emission = Locustparticals.emission;
        emission.rateOverTime = emissionRate * dangerLVL;

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
                    dangerLVL += 1;
                }
                
            }
        }
        if (dangerLVL >= 5)
        {
            logic.locustsjump();
        }
    }
}
