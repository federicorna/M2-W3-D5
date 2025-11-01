using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Fai uno script che abbia:
o una funzione GeneraArray()
prende in input tre parametri interi: dimensione, minimo, massimo
restituisce un array di dimensione elementi con valori casuali tra minimo e massimo
o una funzione StampaArray()
che prende in input un array e ne stampa tutti gli elementi
· Aggiungere una funzione
o TrovaMinimo()
prende in input un array di interi
restituisce un numero intero, esso deve essere uguale al numero più basso presente nell'array
· Aggiungere una funzione
o TrovaMassimo() simile alla precedente, ma che restituisce il numero
· Nello Start() queste funzioni devono essere utilizzate e testate.*/

public class Esercizio3 : MonoBehaviour
{

    [SerializeField] int dimensione = 5, minimo = 5, massimo = 11;

    //----------------------------- QUA LE FUNZIONI -----------------------------

    int[] GeneraArray(int dimensione, int minimo, int massimo)
    {
        int[] array = new int[dimensione];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(minimo, massimo);
        }
        return array;
    }


    void StampaArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
    }


    int TrovaMinimo(int[] array)
    {   
        int minimo = array[0];
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minimo)
            {
                minimo = array[i];
            }
        }
        return minimo;
    }

    int TrovaMassimo(int[] array)
    {
        int max = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }

    //----------------------------- QUA LO START -----------------------------

    void Start()
    {
        int[] array = GeneraArray(dimensione, minimo, massimo);

        StampaArray(array);

        int min = TrovaMinimo(array);
        Debug.Log("Il valore minimo: " + min);

        int max = TrovaMassimo(array);
        Debug.Log("Il valore massimo: " + max);
    }

}
