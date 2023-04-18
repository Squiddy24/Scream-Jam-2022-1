using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScarecrowLogic : MonoBehaviour
{
    public int ScarecrowDifficulty = 5;
    public float timeLeft = 5f;
    public int Scarecrowpositon = 1;
    public GameObject Scarecrowposition1;
    public GameObject Scarecrowposition2;
    public GameObject Scarecrowposition3;
    public GameObject Scarecrowpositionnegative1;
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
            if (ScarecrowDifficulty >= randomNumber)
            {
                randomNumber = Random.Range(-1, 1);
                if (randomNumber == 0)
                {
                    Scarecrowpositon = Scarecrowpositon + 1;
                    timeLeft = 5;
                }
                else
                {
                    Scarecrowpositon = Scarecrowpositon + randomNumber;
                    timeLeft = 5;
                }

            }
            else
            {
                timeLeft = 5;
            }
        }
        if (Scarecrowpositon >= 3)
        {
            logic.gameover();
        }
        if (Scarecrowpositon == -1)
        {
            Scarecrowposition2.SetActive(false);
            Scarecrowposition1.SetActive(false);
            Scarecrowposition3.SetActive(false);
            Scarecrowpositionnegative1.SetActive(true);
        }
        if (Scarecrowpositon == 0)
        {
            Scarecrowposition2.SetActive(false);
            Scarecrowposition1.SetActive(true);
            Scarecrowposition3.SetActive(false);
            Scarecrowpositionnegative1.SetActive(false);
        }
        if(Scarecrowpositon == 1)
        {
            Scarecrowposition2.SetActive(true);
            Scarecrowposition1.SetActive(false);
            Scarecrowposition3.SetActive(false);
            Scarecrowpositionnegative1.SetActive(false);
        }
        if(Scarecrowpositon == 2)
        {
            Scarecrowposition2.SetActive(false);
            Scarecrowposition1.SetActive(false);
            Scarecrowposition3.SetActive(true);
            Scarecrowpositionnegative1.SetActive(false);
        }
        if (Scarecrowpositon == 3)
        {
            Scarecrowposition2.SetActive(false);
            Scarecrowposition1.SetActive(false);
            Scarecrowposition3.SetActive(false);
            Scarecrowpositionnegative1.SetActive(false);
        }
    }
    public void pranked()
    {
        if (Scarecrowpositon == 2)
        {
            Scarecrowpositon = 0;
            Scarecrowposition2.SetActive(false);
            Scarecrowposition1.SetActive(true);
            Scarecrowposition3.SetActive(false);
        }
    }
}
