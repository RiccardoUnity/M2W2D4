using UnityEngine;

public class Esercizio6 : MonoBehaviour
{
    private int[] array = new int[21];

    private int[] GeneraArray()
    {
        int[] _array = new int[21];

        for (int i = 0; i < 21; i++)
        {
            _array[i] = Random.Range(0, 100) + 1;
        }
        return _array;
    }

    private int SommaArray(int[] array)
    {
        int somma = 0;
        foreach (int i in array)
        {
            somma += i;
        }
        return somma;
    }

    private void StampaArray(int[] array)
    {
        foreach (int i in array)
        {
            Debug.Log(i);
        }
    }

    void Start()
    {
        array = GeneraArray();
        SommaArray(array);
        StampaArray(array);
    }
}
