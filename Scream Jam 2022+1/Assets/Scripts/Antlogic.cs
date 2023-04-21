using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antlogic : MonoBehaviour
{
    public int AntDifficulty = 5;
    public float timeLeft = 5f;
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
                randomNumber = Random.Range(-1, 1);
                if (randomNumber == 0)
                {
                    Antpositon = Antpositon + 1;
                    timeLeft = 5;
                    if (Antpositon == 1)
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
                        randomNumber = Random.Range(1, 3);
                        if (randomNumber == 3)
                        {
                            Antfield1.SetActive(true);
                        }

                        if (randomNumber == 2)
                        {
                            Antfield2.SetActive(true);
                        }

                        if (randomNumber == 1)
                        {
                            Antfield3.SetActive(true);
                        }
                    }
                    if (Antpositon == -2)
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
                        randomNumber = Random.Range(1, 3);
                        if (randomNumber == 3)
                        {
                            Antsilo1.SetActive(true);
                        }

                        if (randomNumber == 2)
                        {
                            Antsilo2.SetActive(true);
                        }

                        if (randomNumber == 1)
                        {
                            Antsilo3.SetActive(true);
                        }

                    }
                    if (Antpositon == -1)
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
                        randomNumber = Random.Range(1, 3);
                        if (randomNumber == 3)
                        {
                            Antcorn1.SetActive(true);
                        }

                        if (randomNumber == 2)
                        {
                            Antcorn2.SetActive(true);
                        }

                        if (randomNumber == 1)
                        {
                            Antcorn3.SetActive(true);
                        }
                    }
                    if (Antpositon == 2)
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
                    if (Antpositon <= -2)
                    {
                        Antpositon = -2;
                    }
                    if (Antpositon >= 2)
                    {
                        logic.gameover();
                    }
                }

            }
            else
            {
                int randomNumber2 = Random.Range(-1, 1);
                Antpositon = Antpositon + randomNumber2;
                timeLeft = 5;
                Antpositon = Antpositon + 1;
                timeLeft = 5;
                if (Antpositon == 1)
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
                    randomNumber2 = Random.Range(1, 3);
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
                    randomNumber2 = Random.Range(1, 3);
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
                    randomNumber2 = Random.Range(1, 3);
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
                    randomNumber2 = Random.Range(1, 3);
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
                if (Antpositon <= -2)
                {
                    Antpositon = -2;
                }
                if (Antpositon > 2)
                {
                    logic.antjump();
                    
                }
            }
        }

    }
    public void sprayed()
    {
        if (Antpositon == 2)
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
            Antpositon = 0;

        }
    }
}