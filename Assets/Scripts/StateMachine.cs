using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField]
    GameObject calcScreen;
    [SerializeField]
    GameObject compareScreen;
    GameObject currentScreen;
    // Start is called before the first frame update
    void Start()
    {
        currentScreen = calcScreen;
        compareScreen.SetActive(false);
        currentScreen.SetActive(true);
    }

    public void ChangeScreen(GameObject screen)
    {
        
        currentScreen.SetActive (false);
        currentScreen = screen;
        currentScreen.SetActive(true);
    }

    
}
