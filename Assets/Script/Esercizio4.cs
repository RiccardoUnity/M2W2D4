using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    public int start;
    public int amount;

    private void Ciclo()
    {
        amount = Mathf.Abs(amount) + 1;
        for (int i = start; i < start + amount; i++)
        {
            Debug.Log(i);
        }
    }

    void Start()
    {
        Ciclo();
    }
}
