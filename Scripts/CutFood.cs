using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutFood : MonoBehaviour
{
    public GameObject cutVersion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("knife"))
        {
			Destroy(gameObject);
            Instantiate(cutVersion, transform.position, transform.rotation);
            ToDoList.cutCounter++;
        }
      
    }
}
