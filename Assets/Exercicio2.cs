using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Coroutine sh = StartCoroutine(SayHello());
        Coroutine count = StartCoroutine(CountToThirty());
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private IEnumerator SayHello()
    {
        WaitForSeconds wfs = new WaitForSeconds(4);
        while (true)
        {
            Debug.Log("Hello");
            yield return wfs;
        }
    }

    private IEnumerator CountToThirty()
    {
        WaitForSeconds wfs = new WaitForSeconds(1);
        for (int i = 0; i < 30; i++)
        {
            Debug.Log(i);
            yield return wfs;
        }
    }
}
