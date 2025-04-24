using UnityEngine;

public class Esercizio7 : MonoBehaviour
{
    public int minimo = 0;
    public int massimo = 100;
    private int[] array = new int[21];

    private void GeneraArray(int[] array, int min, int max)
    {
        for (int i = 0; i < 21; i++)
        {
            array[i] = Random.Range(min, max);
        }
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
        GeneraArray(array, minimo, massimo);
        SommaArray(array);
        StampaArray(array);
    }
}
