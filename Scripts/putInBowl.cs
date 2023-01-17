using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class putInBowl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Carrot"))
            ToDoList.carrotInBowl = true;

        if (other.CompareTag("Onion"))
            ToDoList.oreganoInBowl = true;

        if (other.CompareTag("Petersil"))
            ToDoList.petersilInBowl = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Carrot"))
            ToDoList.carrotInBowl = false;

        if (other.CompareTag("Onion"))
            ToDoList.oreganoInBowl = false;

        if (other.CompareTag("Petersil"))
            ToDoList.petersilInBowl = false;
    }
}
