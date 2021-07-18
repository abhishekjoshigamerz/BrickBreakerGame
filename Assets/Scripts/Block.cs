using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;
    [SerializeField] int  blockset;
    int destroyedCounter;
      private void Awake() {
        
        
      }


    private void OnCollisionEnter2D(Collision2D other) {
        AudioSource.PlayClipAtPoint(breakSound,Camera.main.transform.position); 
        FindObjectOfType<GameStatus>().AddToScore();
       
        Destroy(gameObject);
    }

   
}
