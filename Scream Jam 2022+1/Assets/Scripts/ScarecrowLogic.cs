using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScarecrowLogic : MonoBehaviour
{
    public int ScarecrowDifficulty = 5;
    public float timeLeft = 5f;
    public int Scarecrowpositon = 0;
    public GameObject Scarecrowsilo1;
    public GameObject Scarecrowsilo2;
    public GameObject Scarecrowsilo3;
    public GameObject Scarecrowfield1;
    public GameObject Scarecrowfield2;
    public GameObject Scarecrowfield3;
    public GameObject Scarecrowfield21;
    public GameObject Scarecrowfield22;
    public GameObject Scarecrowfield23;
    public GameObject Scarecrowcorn1;
    public GameObject Scarecrowcorn2;
    public GameObject Scarecrowcorn3;
    public GameObject Scarecrowsleep;
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
            timeLeft = 5;
            if (ScarecrowDifficulty >= randomNumber)
            {
                Scarecrowsleep.SetActive(false);
                Scarecrowpositon = Scarecrowpositon + 1;
                timeLeft = 5;
                if (Scarecrowpositon == 0)
                {
                    Scarecrowsilo1.SetActive(false);
                    Scarecrowsilo2.SetActive(false);
                    Scarecrowsilo3.SetActive(false);
                    Scarecrowsilo1.SetActive(false);
                    Scarecrowsilo2.SetActive(false);
                    Scarecrowsilo3.SetActive(false);
                    Scarecrowcorn1.SetActive(false);
                    Scarecrowcorn2.SetActive(false);
                    Scarecrowcorn3.SetActive(false);
                    Scarecrowfield1.SetActive(false);
                    Scarecrowfield2.SetActive(false);
                    Scarecrowfield3.SetActive(false);
                    Scarecrowfield21.SetActive(false);
                    Scarecrowfield22.SetActive(false);
                    Scarecrowfield23.SetActive(false);

                    randomNumber = Random.Range(1, 3);
                    if (randomNumber == 3)
                    {
                        Scarecrowcorn3.SetActive(true);
                    }

                    if (randomNumber == 2)
                    {
                        Scarecrowcorn2.SetActive(true);
                    }

                    if (randomNumber == 1)
                    {
                        Scarecrowcorn1.SetActive(true);
                    }
                }
                else if (Scarecrowpositon == 1)
                {
                    Scarecrowsilo1.SetActive(false);
                    Scarecrowsilo2.SetActive(false);
                    Scarecrowsilo3.SetActive(false);
                    Scarecrowsilo1.SetActive(false);
                    Scarecrowsilo2.SetActive(false);
                    Scarecrowsilo3.SetActive(false);
                    Scarecrowcorn1.SetActive(false);
                    Scarecrowcorn2.SetActive(false);
                    Scarecrowcorn3.SetActive(false);
                    Scarecrowfield1.SetActive(false);
                    Scarecrowfield2.SetActive(false);
                    Scarecrowfield3.SetActive(false);
                    Scarecrowfield21.SetActive(false);
                    Scarecrowfield22.SetActive(false);
                    Scarecrowfield23.SetActive(false);

                    randomNumber = Random.Range(1, 3);
                    if (randomNumber == 3)
                    {
                        Scarecrowfield1.SetActive(true);
                    }

                    if (randomNumber == 2)
                    {
                        Scarecrowfield2.SetActive(true);
                    }

                    if (randomNumber == 1)
                    {
                        Scarecrowfield3.SetActive(true);
                    }

                }
                else if (Scarecrowpositon == 2)
                {
                    Scarecrowsilo1.SetActive(false);
                    Scarecrowsilo2.SetActive(false);
                    Scarecrowsilo3.SetActive(false);
                    Scarecrowsilo1.SetActive(false);
                    Scarecrowsilo2.SetActive(false);
                    Scarecrowsilo3.SetActive(false);
                    Scarecrowcorn1.SetActive(false);
                    Scarecrowcorn2.SetActive(false);
                    Scarecrowcorn3.SetActive(false);
                    Scarecrowfield1.SetActive(false);
                    Scarecrowfield2.SetActive(false);
                    Scarecrowfield3.SetActive(false);
                    Scarecrowfield21.SetActive(false);
                    Scarecrowfield22.SetActive(false);
                    Scarecrowfield23.SetActive(false);

                    randomNumber = Random.Range(1, 3);
                    if (randomNumber == 3)
                    {
                        Scarecrowfield21.SetActive(true);
                    }

                    if (randomNumber == 2)
                    {
                        Scarecrowfield22.SetActive(true);
                    }

                    if (randomNumber == 1)
                    {
                        Scarecrowfield23.SetActive(true);
                    }
                }
                else if (Scarecrowpositon == -1)
                {
                    Scarecrowsilo1.SetActive(false);
                    Scarecrowsilo2.SetActive(false);
                    Scarecrowsilo3.SetActive(false);
                    Scarecrowsilo1.SetActive(false);
                    Scarecrowsilo2.SetActive(false);
                    Scarecrowsilo3.SetActive(false);
                    Scarecrowcorn1.SetActive(false);
                    Scarecrowcorn2.SetActive(false);
                    Scarecrowcorn3.SetActive(false);
                    Scarecrowfield1.SetActive(false);
                    Scarecrowfield2.SetActive(false);
                    Scarecrowfield3.SetActive(false);
                    Scarecrowfield21.SetActive(false);
                    Scarecrowfield22.SetActive(false);
                    Scarecrowfield23.SetActive(false);

                    randomNumber = Random.Range(1, 3);
                    if (randomNumber == 3)
                    {
                        Scarecrowsilo1.SetActive(true);
                    }

                    if (randomNumber == 2)
                    {
                        Scarecrowsilo2.SetActive(true);
                    }

                    if (randomNumber == 1)
                    {
                        Scarecrowsilo3.SetActive(true);
                    }

                }
                else if (Scarecrowpositon == 3)
                {
                    Scarecrowsilo1.SetActive(false);
                    Scarecrowsilo2.SetActive(false);
                    Scarecrowsilo3.SetActive(false);
                    Scarecrowsilo1.SetActive(false);
                    Scarecrowsilo2.SetActive(false);
                    Scarecrowsilo3.SetActive(false);
                    Scarecrowcorn1.SetActive(false);
                    Scarecrowcorn2.SetActive(false);
                    Scarecrowcorn3.SetActive(false);
                    Scarecrowfield1.SetActive(false);
                    Scarecrowfield2.SetActive(false);
                    Scarecrowfield3.SetActive(false);
                    Scarecrowfield21.SetActive(false);
                    Scarecrowfield22.SetActive(false);
                    Scarecrowfield23.SetActive(false);
                }
                else if (Scarecrowpositon >= 4)
                {
                    logic.scarecrowjump();
                    Scarecrowpositon = Scarecrowpositon - 4;
                }
            }

        }
    }

}