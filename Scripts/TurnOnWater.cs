using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class TurnOnWater : MonoBehaviour
{
    public GameObject water;
    private bool turnedOn = false;

    private XRBaseInteractable interactable = null;
    private XRBaseInteractor interactor = null;

    private void Awake()
    {
        interactable = GetComponent<XRBaseInteractable>();
        interactor = GetComponent<XRBaseInteractor>();
    }

    void Update()
    {
        if(!PauseControl.gameIsPaused)
		{
			if (interactable.isSelected)
			{
				if (turnedOn)
					water.gameObject.SetActive(false);
				else
					water.gameObject.SetActive(true);
				turnedOn = !turnedOn;
            }
		}
    }
}
