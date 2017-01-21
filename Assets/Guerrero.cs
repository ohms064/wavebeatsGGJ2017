using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerrero {
    public Arma arma;

    public void HacerDanio() {
        Debug.Log("Daño! " + arma);
    }
}
