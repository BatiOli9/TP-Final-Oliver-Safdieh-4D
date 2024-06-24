using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptArray : MonoBehaviour
{
    public GameObject[] Objetos;
    public int CurrentIndex = 0;
    public int valorInicial;
    public int valorFinal;
    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
        valorFinal = Objetos.Length - 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            DeactivateAll();
            if (CurrentIndex == valorInicial)
            {
                ActivateByIndex(CurrentIndex);
            }
            else
            {
                CurrentIndex--;
                ActivateByIndex(CurrentIndex);
            }

            Debug.Log(CurrentIndex);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            DeactivateAll();
            if (CurrentIndex == valorFinal)
            {
                ActivateByIndex(CurrentIndex);
            }
            else
            {
                CurrentIndex++;
                ActivateByIndex(CurrentIndex);
            }

            Debug.Log(CurrentIndex);
        }
    }

    void DeactivateAll()
    {
        for (int i = 0; i < Objetos.Length; i++)
        {
            Objetos[i].SetActive(false);
        }
    }

    void ActivateByIndex(int index)
    {
        Objetos[index].SetActive(true);
    }

    void ActivateAll()
    {
        for (int i = 0; i < Objetos.Length; i++)
        {
            Objetos[i].SetActive(true);
        }
    }
}
