using UnityEngine;

public class EsercizioBonus : MonoBehaviour
{
    //Iterare tutte le tabelline fino al 10

    void Start()
    {
        // Devo partire da 1 e arrivare a 10, non posso usare come al solito i = 0; i < 10;
        for (int i = 1; i < 11; i++)
        {
            for (int j = 1; j < 11; j++)
            {
                Debug.Log("Tabellina del " + i + " - " + j * i);
            }
        }
    }
}
