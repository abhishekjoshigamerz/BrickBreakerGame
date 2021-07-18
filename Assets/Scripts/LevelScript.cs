using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript : MonoBehaviour
{   
    [SerializeField] int breakableBlock;
    [SerializeField] Blockset blockset;
    public void Start(){
        breakableBlock = blockset.numberofblocks; 
    }
   
    
}
