using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillWithSauce : MonoBehaviour
{
    public GameObject potSauce;

    private Vector3 scaleChange1 = new Vector3(0.28647f, 0.05047928f, 0.28647f);
    private Vector3 positionChange1 = new Vector3(0.002f, -0.079f, 0.0001f);
    private Vector3 scaleChange2 = new Vector3(0.28647f, 0.07478412f, 0.28647f);
    private Vector3 positionChange2 = new Vector3(0.002f, -0.059f, 0.0001f);
	
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Oil")) {
			ToDoList.oilInPot = true;
		}
		
		if (other.CompareTag("Garlic")) {
			ToDoList.garlicInPot = true;
		}
		
		if (other.CompareTag("Onion")) {
			ToDoList.onionInPot = true;
		}
		
		if (other.CompareTag("Cookingspoon")) {
			ToDoList.stirNumber++;
			StartCoroutine(WaitUntilNextStir());
		}
		
		//Sauce soll erscheinen, wenn Karotten reingegeben werden
        if (other.CompareTag("Carrot") && potSauce.gameObject.activeSelf == false)
        {
            potSauce.gameObject.SetActive(true);
			ToDoList.carrotsInPot = true;
        }
        
        //Sauce soll höher werden, wenn Fleisch reingegeben wird
        if (other.CompareTag("Meat") && potSauce.gameObject.activeSelf == true)
        {
            potSauce.transform.localScale = scaleChange1;
            potSauce.transform.localPosition = positionChange1;
            ToDoList.meatInPot = true;
        }
		
		if (other.CompareTag("Tomatosauce")) {
			ToDoList.tomatoSauceInPot = true;
		}

        //Sauce soll noch höher werden, wenn Rotwein reingegeben wird
        if (other.CompareTag("RedWine") && ToDoList.meatInPot == true)
        {
            potSauce.transform.localScale = scaleChange2;
            potSauce.transform.localPosition = positionChange2;
			ToDoList.redwineInPot = true;
        }
		
		if (other.CompareTag("Oregano")) {
			ToDoList.oreganoInPot = true;
		}
		
		if (other.CompareTag("Lid"))
        {
            ToDoList.lidOnPot2 = true;
			Debug.Log("Lid is on Pot.");
        }
    }
	
	public IEnumerator WaitUntilNextStir()
	{
		yield return new WaitForSeconds(5);
	}
}
