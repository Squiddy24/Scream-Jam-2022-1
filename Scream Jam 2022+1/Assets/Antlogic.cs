using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antlogic : MonoBehaviour
{
    public int AntDifficulty = 5;
    public float timeLeft = 5f;
    public int Antpositon = 1;
    public GameObject Antposition1;
    public GameObject Antposition2;
    public GameObject Antposition3;
    public LogicCode logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicCode>();
    }
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            int randomNumber = Random.Range(1, 22);
            if (AntDifficulty >= randomNumber)
            {
                Antpositon = Antpositon + 1;
                timeLeft = 5;
            }
            else
            {
                timeLeft = 5;
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
        if (Antpositon == 2)
        {
            Antposition2.SetActive(false);
            Antposition1.SetActive(false);
        }
        if (Antpositon >= 2)
        {
            logic.gameover();
        }
    }
    public void sprayed()
    {
        if (Antpositon == 2)
        {
            Antpositon = 0;
            Antposition2.SetActive(false);
            Antposition1.SetActive(true);
            Antposition3.SetActive(false);
        }
    }
}
