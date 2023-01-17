using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class washScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Carrot"))
            ToDoList.carrotWashed = true;

        if (other.CompareTag("Onion"))
            ToDoList.oreganoWashed = true;

        if (other.CompareTag("Petersil"))
            ToDoList.petersilWashed = true;
    }
}
