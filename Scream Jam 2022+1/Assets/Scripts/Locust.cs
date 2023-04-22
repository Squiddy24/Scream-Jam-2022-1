using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locust : MonoBehaviour
{
    public ParticleSystem Locustparticals;
    public int emissionRate;
    public float timeLeft = 10f;
    public static int LocustDifficulty = 0;
    public static int dangerLVL;
    public LogicCode logic;
    public AudioSource locustsound;
    public bool IsSoundPlaying;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicCode>();
        emissionRate = 30;
        dangerLVL = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (CameraCode.CamOn == true && CameraCode.LastCam == 1)
        {
            if (IsSoundPlaying == false)
            {
                locustsound.volume = 0.2f * dangerLVL;
                locustsound.Play();
                IsSoundPlaying = true;
            }
        }
        else
        {
            locustsound.Stop();
            IsSoundPlaying = false;
        }
        var emission = Locustparticals.emission;
        emission.rateOverTime = emissionRate * dangerLVL;

        Debug.Log(dangerLVL);
        timeLeft -= 0.02f;
        if (timeLeft <= 0)
        {
            int randomNumber = Random.Range(1, 22);
            timeLeft = 10;
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
