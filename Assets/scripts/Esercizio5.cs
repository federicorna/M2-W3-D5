using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Esercizio5 : MonoBehaviour
{
    [SerializeField] int dimBase;
    [SerializeField] int dimNuova;

    int[] CambiaDimensioneArray(int[] array, int dimNuova)
    {
        //non mi serve crare array base perhce lo riceve gia dalla fn
        int[] arrayNuovo = new int[dimNuova];
        
        if (dimNuova == array.Length)
        {
            arrayNuovo = array;
            Debug.Log(arrayNuovo);
            
        }
        else if (dimNuova < array.Length)
        {
            for (int i = 0; i < dimNuova; i++)
            {
                arrayNuovo[i] = array[i];
                Debug.Log(array[i]);
            }
        }
        else
        {
            for (int i = 0; i < dimNuova; i++)
            {
                arrayNuovo[i] = array[i];
                Debug.Log(array[i]);
            }
        }
 
        return arrayNuovo;
    }

    void Stampa(int[] pieroArray)
    {
        for (int i = 0; i < pieroArray.Length; i++)
        {
            Debug.Log(pieroArray[i]);
        }
    }


    //----------------------------- QUA LO START -----------------------------
    void Start()
    {
        Debug.Log("Array di base:");

        int[] array = new int[dimBase];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(1, 11);
            Debug.Log(array[i]);
        }

        Debug.Log("Array nuovo:");
        int[] arr = CambiaDimensioneArray(array, dimNuova);

    }
}


//if (dimNuova < dimBase)
//{
//    for (int i = 0; i < dimNuova; i++)
//    {
//        arrayNuovo[i] = array[i];
//        Debug.Log(array[dimNuova]);
//    }
//}

//return arrayNuovo;