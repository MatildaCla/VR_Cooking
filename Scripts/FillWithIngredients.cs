using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillWithIngredients : MonoBehaviour
{
	public GameObject salt;
	public GameObject pepper;
	
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tomatopaste")) {
			ToDoList.tomatoPasteInPot = true;
		}
		
		if (other.CompareTag("Pepper")) {
			
            if (Vector3.Dot(pepper.transform.up, Vector3.down) > 0)
            {
                ToDoList.peppered = true;
            }
		}
		
		if (other.CompareTag("Salt")) {
			
            if (Vector3.Dot(salt.transform.up, Vector3.down) > 0)
            {
                ToDoList.salted2 = true;
            }
		}
		
		if (other.CompareTag("Petersil")) {
			ToDoList.petersilInPot = true;
		}
		
		if (other.CompareTag("Cookingspoon")) {
			ToDoList.stirNumber++;
			Debug.Log("Soup is stirred.");
			StartCoroutine(WaitUntilNextStir());
		}
        
    }
	
	public IEnumerator WaitUntilNextStir()
	{
		yield return new WaitForSeconds(2);
	}
}
