using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio1_1 : MonoBehaviour
{

    void Tabellina(int a)
    {
        for (int i = 0; i <= 10; i++)
        {
            Debug.Log(a * i);
        }

    }
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        { 
            Tabellina (i);
        }
    }

}
