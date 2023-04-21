using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locust : MonoBehaviour
{
    public int density;
    public float timeLeft = 4;
    public int LocustDifficulty;
    public ParticleSystem Locustparticalsystem;
    public int emissionRate = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= 0.02f;
        if (timeLeft <= 0)
        {
            int randomNumber = Random.Range(1, 22);
            timeLeft = 4;

            if (LocustDifficulty >= randomNumber)
            {
                if (CameraCode.CamOn == true && CameraCode.LastCam == 1)
                {
                    emissionRate += 10;
                    var emission = Locustparticalsystem.emission;
                    emission.rateOverTime = emissionRate;
                }
            }
        }
    }
}
