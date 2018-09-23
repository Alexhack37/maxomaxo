using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour {

    //public static int Damage = 10; //de momento 10 para probar
    public static int InternalLifePoints = 100;  //puntos de vida interna de momento para probar, hay que traer vida de un script de vida y aplicarla aqui
    public static int CurrentLifePoints;   //en el script de vida poner; PlayerCollision.Currentlifepoints

	void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);     //Dejar esta linea para saber a que toca el collider

        if (collisionInfo.collider.tag == "CarPart")       //if para que solo haga daño cuando
        {
            Debug.Log("Has dado a parte " + collisionInfo.collider.name);
            InternalLifePoints -= CurrentLifePoints;
            Debug.Log(InternalLifePoints + " InternalLifePoints");
            Debug.Log(CurrentLifePoints + " CurrentLifePoints");
            //PlayerLifePoints.GetComponent<Text>().text = "" + InternalLifePoints;
        }
    }
     void Update()
    {
        
    }
}
