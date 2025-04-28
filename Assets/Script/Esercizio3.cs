using UnityEngine;

public class Esercizio3 : MonoBehaviour
{
    public int numero;

    private void Ciclo()
    {
        
        for (int i = 1; i <= 30; i++)   //Sembra strano, ma la consegna chiede di partire da 1
        {
            if (numero % 3 == 0 && numero % 5 == 0)
                Debug.Log("FizzBuzz");
            else if (numero % 5 == 0)
                Debug.Log("Buzz");
            else if (numero % 3 == 0)
                Debug.Log("Fizz");
            else
                Debug.Log(i);
        }
}

    void Start()
    {
        Ciclo();
    }
}
