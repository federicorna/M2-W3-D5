using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prova : MonoBehaviour
{
    int somma(int a, int b)
    {
        int somma = a + b;
        return somma;
    }


    void Start()
    {
        int risultato = somma(3, 5);
        Debug.Log(risultato);
    }

}
