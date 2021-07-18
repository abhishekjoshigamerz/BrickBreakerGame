using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
   [SerializeField] int currentScore=0;
   [SerializeField] int blockDestroyScore=46;

    
    public void AddToScore(){
        currentScore += blockDestroyScore;
        Debug.Log(currentScore);
    }
}
