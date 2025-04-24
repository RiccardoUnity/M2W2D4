using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    public int index = 0;
    public int num = 0;

    private void Ciclo()
    {
        if (index > 0)
        {
            while (index != 0)
            {
                Debug.Log(++num);
                index--;
            }
            Debug.Log("Ciclo Finito");
        }
        else
        {
            Debug.LogWarning("Index minore o uguale a zero, ciclo non eseguito");
        }
    }

    void Start()
    {
        Ciclo();
    }

    void Update()
    {
        
    }
}
