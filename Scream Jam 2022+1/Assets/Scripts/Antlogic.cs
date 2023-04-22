using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antlogic : MonoBehaviour
{
    public static int AntDifficulty = 5;
    public float timeLeft = 6f;
    public int Antpositon = 0;
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
    public bool Antattack;
    public GameObject static1;
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
        if (Antpositon < -2)
        {
            Antpositon = -2;
        }
        if (Antpositon > 2)
        {
            logic.antjump();

        }
        if (Antpositon == 2)
        {
            ClearPos();
            Antattack = true;
        }
        if (Antpositon != 2)
        { 
            Antattack = false;
        }
        timeLeft -= 0.02f;
        if (timeLeft <= 0)
            {
                
            int RandomNumber = Random.Range(0, 20);
            if (AntDifficulty >= RandomNumber)
            {
                StartCoroutine(Static());
                int RandomNumber3 = Random.Range(0, 2);
                if (RandomNumber3 == 0 && Antattack == false)
                {
                    Antmove = -1;
                }
                else
                {
                    Antmove = 1;
                }
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
                
                timeLeft = 6;

            }
            else 
            {
                timeLeft = 6;
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
    public IEnumerator Static()
    {
        static1.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        static1.SetActive(false);
    }

}



