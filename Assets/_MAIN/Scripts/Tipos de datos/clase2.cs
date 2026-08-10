using System.Collections.Generic;
using UnityEngine;

public class clase2 : MonoBehaviour
{
    int a = 5;
    int b = 5;

    private void Start()
    {
        if (a == b)
        {
            Debug.Log("a es igual a b");
        }
        else
        {
            Debug.Log("a no es igual a b");
        }
    }
}
