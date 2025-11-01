using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{

    [SerializeField] int number = 2;
    [SerializeField] int baseNumber = 10;
    [SerializeField] int multiple = 25;

    bool IsEaven (int a)
    {
        if (a % 2 == 0)
        {
            return true;
        }
        return false;
    }

    bool IsMultipleOf (int a, int b)
    {
        if (a % b == 0)
        {
            return true;
        }
        return false;
    }

    void Start()
    {
        IsEaven (number);
        IsMultipleOf(baseNumber, multiple);

        if (IsEaven(number) == true)
        {
            Debug.Log("Il numero " +  number + " e' pari");
        } else
        {
            Debug.Log("Il numero " + number + " e' dispari");
        }

        if (IsMultipleOf(baseNumber, multiple) == true) 
        {
            Debug.Log("Il numero " + baseNumber + " e' multiplo del numero " + multiple);
        }
        else
        {
            Debug.Log("Il numero " + baseNumber + " NON e' multiplo del numero " + multiple);
        }
    
    
       
    }


}
