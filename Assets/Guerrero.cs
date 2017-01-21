using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerrero {
    public Arma arma;

    public Guerrero(Arma nuevaArma) {
        arma = nuevaArma;
    }

    public void HacerDanio() {
        Debug.Log("Daño! " + arma);
    }
}
