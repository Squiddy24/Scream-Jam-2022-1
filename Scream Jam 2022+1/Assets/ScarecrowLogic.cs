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
    public CameraCode Camera;
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
                    Scarecrowpositon = Scarecrowpositon + 1;
                    timeLeft = 5;
            }
            else
            {
                timeLeft = 5;
            }
        }
        if (Scarecrowpositon >= 4)
        {
            Camera.Scarecrow();
            int randomNumber = Random.Range(-1, 3);
            Scarecrowpositon = randomNumber;

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
}
