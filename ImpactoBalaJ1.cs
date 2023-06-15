using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactoBalaJ1 : MonoBehaviour
{

    private MovimientoJugador movJugador1;

    private Animator animator;

    
    // Start is called before the first frame update
    void Start()
    {
        movJugador1 = GetComponent<MovimientoJugador>();
        animator = GetComponent<Animator>();
    }

    public void RecibirImpacto(Vector2 posicion)
    {
        movJugador1.Empuje(posicion);
    }

   
    
}
