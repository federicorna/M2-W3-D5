using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    [SerializeField] int dimensione, minimo, massimo;


    int[] Genera(int dimensione, int minimo, int massimo) //ARRAY DI INTERI, INT + [] !!!
    {
        int[] pieroArray = new int[dimensione];
        for (int i = 0; i < pieroArray.Length; i++)
        {
            pieroArray[i] = Random.Range(minimo, massimo);

            //Debug.Log(pieroArray[i]); posso metterlo ma questo va in un altra funzione 
        }
        return pieroArray;
    }

    void Stampa(int[] pieroArray)
    {
        // int[] piero = new int[dimensione];
        for (int i = 0; i < pieroArray.Length; i++)
        {
            Debug.Log(pieroArray[i]); //Cosa stampo? l'array "pieroArray[i]" o l'indice "i"
        }
    }

    int Minimo(int[] arr)
    {
        int min = arr[0];
        for (int i = 0;  i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }

    int Massimo(int[] arr)
    {
        int max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }

    void TrovaMinimi2(int[] giacomini)
    {
        int min = giacomini[0];
        int min2 = giacomini[0];

        for (int i = 0; i < giacomini.Length; i++)
        {
            if (giacomini[i] < min)
            {
                min = giacomini[i];
            }

            if (giacomini[i] < min2 && giacomini[i] > min)
            {
                min2 = giacomini[i];
            }
        }

        Debug.Log("i due minimi sono: " + min + " " + min2);
    }

    void TrovaMassimi2(int[] giacomini)
    {
        int max = giacomini[0];
        int max2 = giacomini[0];

        for (int i = 0; i < giacomini.Length; i++)
        {
            if (giacomini[i] > max)
            {
                max = giacomini[i];
            }

            if (giacomini[i] > max2 && giacomini[i] < max)
            {
                max2 = giacomini[i];
            }
        }

        Debug.Log("i due minimi sono: " + max2 + " " + max);
    }


    //----------------------------- QUA LO START -----------------------------

    void Start()
    {
        int[] array = Genera (dimensione, minimo, massimo);

        Stampa(array);

        int min = Minimo(array);
        Debug.Log("Il minimo: " + min);

        int max = Massimo(array);
        Debug.Log("Il massimo: " + max);

        TrovaMinimi2(array);

        TrovaMassimi2(array);
    }

}
