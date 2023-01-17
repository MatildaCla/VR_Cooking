using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToDoList : MonoBehaviour
{

    public static ToDoList Instance { get; private set; }

    public static int sceneNumber = 1;
	
    // Arbeitsschritte Scene 1 Cook the noodles
    public static bool waterInPot = false;
    public static bool potOnStove = false;
    public static bool stoveTurnedOn = false;
    public static bool salted = false;
    public static bool noodleInPot = false;
    public static bool lidOnPot = false;

    //Arbeitsschritte Scene 2 Wash Food
    public static bool carrotWashed = false;
    public static bool oreganoWashed = false;
    public static bool petersilWashed = false;

    public static bool carrotInBowl = false;
    public static bool oreganoInBowl = false;
    public static bool petersilInBowl = false;

    public static bool x = false;

    //Arbeitsschritte Scene 3 Cut Food
    public static int cutCounter = 0;
    public static bool x1 = false;
    public static bool x2 = false;
    public static bool x3 = false;

    //Arbeitsschritte Scene 4 Cook Food
    public static bool oilInPot = false;
    public static bool onionInPot = false;
    public static bool garlicInPot = false;
    public static int stirNumber = 0;
    public static bool carrotsInPot = false;
    public static bool meatInPot = false;
    public static bool tomatoSauceInPot = false;
    public static bool redwineInPot = false;
    public static bool oreganoInPot = false;
    public static bool lidOnPot2 = false;

    //Arbeitsschritte Scene 5 Stir of Noodlewater
    public static bool noodlesInColander = false;
    public static bool noodlesInBowl = false;

    //Arbeitsschritte Scene 6 Cook Sauce
    public static bool tomatoPasteInPot = false;
    public static bool salted2 = false;
    public static bool peppered = false;
    public static bool petersilInPot = false;

    //Arbeitsschritte Scene 7 Serve Food
    public static bool noodlesOnPlate = false;
    public static bool sauceOnPlate = false;
    public static bool petersilOnPlate = false;


    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        //Scene1
		if (waterInPot && stoveTurnedOn && salted && noodleInPot && lidOnPot)
        {
            sceneNumber++;
            Application.Quit();

        }

        //Scene2
        if (carrotWashed && oreganoWashed && petersilWashed
            && carrotInBowl && oreganoInBowl && petersilInBowl)
        {
            x = true;
            sceneNumber++;
            Application.Quit();
        }  
		
		//Scene3
		if (cutCounter >= 8)
        {
            x1 = true;
            x2 = true;
            x3 = true;
            sceneNumber++;
            Application.Quit();

        }

        //Scene4
        if (oilInPot && onionInPot && garlicInPot && carrotsInPot && meatInPot && tomatoSauceInPot && redwineInPot 
            && oreganoInPot && lidOnPot2 && stirNumber == 4)
        {
            sceneNumber++;
            Application.Quit();

        }

        //Scene5
        if (noodlesInColander && noodlesInBowl)
        {
            sceneNumber++;
            Application.Quit();

        }

        //Scene6
        if (tomatoPasteInPot && salted2 && peppered && petersilInPot && stirNumber == 5)
        {
            sceneNumber++;
            Application.Quit();

        }
    }
}
