using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
   public float score = 10f;

   public Logic logic;

   void Start()
   {
      logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
   }

   private void OnTriggerEnter2D(Collider2D other) 
   {
      logic.AddScore(score); 
   }
}
