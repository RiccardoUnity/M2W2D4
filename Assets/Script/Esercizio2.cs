using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    public int[] index = new int[4];
    private int _somma;
    private int _prodotto = 1;

    private void Ciclo()
    {
        for (int i = 0; i < index.Length; i++)
        {
            _somma += index[i];
            _prodotto *= index[i];
            if (i == 1)
                break;
        }
        Debug.Log("Somma: " + _somma);
        Debug.Log("Prodotto: " + _prodotto);
    }

    void Start()
    {
        Ciclo();
    }
}
