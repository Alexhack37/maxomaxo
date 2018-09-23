using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSide : MonoBehaviour {

    bool CR_running;

    void OnCollisionEnter(Collision collisionInfo)
    {
        Damage();
       // StartCoroutine("Cooldown");



    }
   
    

    
    //Esto para intentar usar tiempo para que no le pueda volver a dar, pero ademas hay que poner velocidad de choque y transformarla en daño, eso es facil

  //  IEnumerator Cooldown()     //De momento vamos a usar un cooldown paracuando le de un golpe no pueda alejarse 1cm y darle otra vez, tenga que ir con velocidad, eso mas tarde
  //  {
  //      CR_running = true;
  //      yield return new WaitForSeconds(10);
  //      CR_running = false;
  //
  //  }
    void Damage()
    {
      //  if (CR_running)
      //  {
      //      PlayerCollision.CurrentLifePoints = 0;
      //  }
        PlayerCollision.CurrentLifePoints = 10;
    }
    
}
