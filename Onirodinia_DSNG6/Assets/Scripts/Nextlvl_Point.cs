using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextlvl_Point : MonoBehaviour
{
   public string lvlName;

   void OnCollisionEnter2D(Collision2D collision) {

       if(collision.gameObject.tag == "Helena")
       {
            SceneManager.LoadScene(lvlName);
       }
      
  }
}
