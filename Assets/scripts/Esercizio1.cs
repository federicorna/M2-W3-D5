using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    int Tabellina(int a)
    {
        int tabellina = 0;
        for (int i = 1; i <= 10; i++)
        {
            tabellina = a * i;
            Debug.Log(tabellina);
        }
        return tabellina;
    }

    void Start()
    {
        for (int i = 1; i < 10; i++)
        {
            int risultato = Tabellina(i);
            Debug.Log(risultato);
        }
            
    }

}






