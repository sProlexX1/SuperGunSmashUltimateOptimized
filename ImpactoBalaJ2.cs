using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactoBalaJ2 : MonoBehaviour
{
    private MovimientoJugador2 movJugador2;

    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        movJugador2 = GetComponent<MovimientoJugador2>();
        animator = GetComponent<Animator>();
    }

    public void RecibirImpacto(Vector2 posicion)
    {
        movJugador2.Empuje(posicion);
    }
}
