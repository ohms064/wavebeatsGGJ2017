using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIManager : MonoBehaviour {
    public Canvas credits, mainMenu;

	public void ActivateCredits() {
        credits.enabled = true;
        mainMenu.enabled = false;
    }

    public void ActivateMenu() {
        credits.enabled = false;
        mainMenu.enabled = true;
    }
}
