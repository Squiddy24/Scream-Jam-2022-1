using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antlogic : MonoBehaviour
{
    public int AntDifficulty = 2;
    public float timeLeft = 6f;
    public int Antpositon = 1;
    public GameObject Antsilo1;
    public GameObject Antsilo2;
    public GameObject Antsilo3;
    public GameObject Antfield21;
    public GameObject Antfield22;
    public GameObject Antfield23;
    public GameObject Antfield1;
    public GameObject Antfield2;
    public GameObject Antfield3;
    public GameObject Antcorn1;
    public GameObject Antcorn2;
    public GameObject Antcorn3;
    public LogicCode logic;
    public int Antmove; 
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicCode>();
    }
    void ClearPos()
    {
        Antfield1.SetActive(false);
        Antfield2.SetActive(false);
        Antfield3.SetActive(false);
        Antfield21.SetActive(false);
        Antfield22.SetActive(false);
        Antfield23.SetActive(false);
        Antcorn1.SetActive(false);
        Antcorn2.SetActive(false);
        Antcorn3.SetActive(false);
        Antsilo1.SetActive(false);
        Antsilo2.SetActive(false);
        Antsilo3.SetActive(false);
    }

    void Update()
    {
        timeLeft -= 0.02f;
        if (timeLeft <= 0)
            {
                
                int RandomNumber3 = Random.Range(0, 1);
                if (RandomNumber3 == 1)
                {
                    Antmove = 1;
                }
                else if (RandomNumber3 == 0)
                {
                    Antmove = -1;
                }
            int RandomNumber = Random.Range(0, 20);
            if (AntDifficulty <= RandomNumber)
            {
                Antpositon = Antpositon + Antmove;
                if (Antpositon == 1)
                {
                    ClearPos();
                    int randomNumber2 = Random.Range(1, 3);
                    if (randomNumber2 == 3)
                    {
                        Antfield21.SetActive(true);
                    }

                    if (randomNumber2 == 2)
                    {
                        Antfield22.SetActive(true);
                    }

                    if (randomNumber2 == 1)
                    {
                        Antfield23.SetActive(true);
                    }
                }
                if (Antpositon == 0)
                {
                    ClearPos();
                    int randomNumber2 = Random.Range(1, 3);
                    if (randomNumber2 == 3)
                    {
                        Antfield1.SetActive(true);
                    }

                    if (randomNumber2 == 2)
                    {
                        Antfield2.SetActive(true);
                    }

                    if (randomNumber2 == 1)
                    {
                        Antfield3.SetActive(true);
                    }
                }
                if (Antpositon == -2)
                {
                    ClearPos();
                    int randomNumber2 = Random.Range(1, 3);
                    if (randomNumber2 == 3)
                    {
                        Antsilo1.SetActive(true);
                    }

                    if (randomNumber2 == 2)
                    {
                        Antsilo2.SetActive(true);
                    }

                    if (randomNumber2 == 1)
                    {
                        Antsilo3.SetActive(true);
                    }

                }
                if (Antpositon == -1)
                {
                    ClearPos();
                    int randomNumber2 = Random.Range(1, 3);
                    if (randomNumber2 == 3)
                    {
                        Antcorn1.SetActive(true);
                    }

                    if (randomNumber2 == 2)
                    {
                        Antcorn2.SetActive(true);
                    }

                    if (randomNumber2 == 1)
                    {
                        Antcorn3.SetActive(true);
                    }
                }
                if (Antpositon == 2)
                {
                    ClearPos();
                }
                if (Antpositon <= -2)
                {
                    Antpositon = 2;
                }
                timeLeft = 6;

            }
            if (Antpositon > 2)
            {
                logic.antjump();

            }
        }
            

        }
    public void sprayed()
    {
        if (Antpositon == 2)
        {
            ClearPos();
            Antpositon = 0;
            timeLeft = 0;
        }
    }

}



