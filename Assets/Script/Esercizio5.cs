using UnityEngine;

public class Esercizio5 : MonoBehaviour
{
    public int find;
    private int[] _arrayX = new int[50];

    private void Ciclo()
    {
        for (int i = 0; i < _arrayX.Length; i++)
        {
            //Uso (_arrayX.Length / 2) per avere "un bacino di random" proporzionale alla grandezza dell'array
            _arrayX[i] = Random.Range(find - _arrayX.Length / 2, find + _arrayX.Length / 2);
            if (_arrayX[i] == find)
            {
                Debug.Log("Found");
            }
            else
            {
                Debug.Log("Not found");
            }
        }
        Debug.Log("Iterations finished");
    }

    void Start()
    {
        Ciclo();
    }
}
