using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillWithWater : MonoBehaviour
{
    public GameObject potWater;
    public GameObject salt;

    private void Update()
    {

        if (Vector3.Dot(transform.up, Vector3.down) > 0)
        {
            SpillWater();
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tapwater") && potWater.gameObject.activeSelf == false)
        {
            potWater.gameObject.SetActive(true);
            ToDoList.waterInPot = true;
        }

        if (other.CompareTag("Salt"))
        {
            if (Vector3.Dot(salt.transform.up, Vector3.down) > 0 && potWater.gameObject.activeSelf == true)
            {
                ToDoList.salted = true;
            }
        }

        if (other.CompareTag("Spaghetti"))
        {
            ToDoList.noodleInPot = true;
        }

        if (other.CompareTag("Lid"))
        {
            ToDoList.lidOnPot = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Spaghetti"))
        {
            ToDoList.noodleInPot = false;
        }

        if (other.CompareTag("Lid"))
        {
            ToDoList.lidOnPot = false;
        }
    }

    private void SpillWater()
    {
        potWater.gameObject.SetActive(false);
        ToDoList.waterInPot = false;
        ToDoList.salted = false;
    }
}
