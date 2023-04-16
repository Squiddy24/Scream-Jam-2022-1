using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antlogic : MonoBehaviour
{
    public int AntDifficulty = 5;
    public float timeLeft = 30.0f;
    public int Antpositon = 1;
    public int randomNumber;
    public GameObject Antposition1;
    public GameObject Antposition2;
    public GameObject Antposition3;
    void Start()
    {
        
    }
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            int randomnumber = Random.Range(0, 20);
            if (randomNumber <= AntDifficulty)
            {
                Antpositon = Antpositon + 1;
                timeLeft = 30;
            }
        }
        if (Antpositon == 1)
        {
            Antposition2.SetActive(true);
            Antposition1.SetActive(false);
        }
        if (Antpositon == 0)
        {
            Antposition2.SetActive(false);
            Antposition1.SetActive(true);
        }
        if (Antpositon >= 2)
        {
            Antposition2.SetActive(false);
            Antposition1.SetActive(false);
            Antposition3.SetActive(true);
        }

    }
}
