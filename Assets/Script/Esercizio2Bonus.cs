using System;
using UnityEngine;

public class Esercizio2Bonus : MonoBehaviour
{
    public int[] index = new int[4];
    private int _somma;
    private int _prodotto = 1;

    private void OnValidate()
    {
        //Blocco la grandezza dell'array su 4 valori
        Array.Resize(ref index, 4);
    }

    private void Ciclo()
    {
        foreach (int i in index)
        {
            _somma += i;
            _prodotto *= i;
        }
        Debug.Log("Somma: " + _somma);
        Debug.Log("Prodotto: " + _prodotto);
    }

    void Start()
    {
        Ciclo();
    }
}
