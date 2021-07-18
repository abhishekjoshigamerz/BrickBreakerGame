using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockset : MonoBehaviour
{
    private Transform[] children;
    public int numberofblocks;
    private void Awake() {
        children = gameObject.GetComponentsInChildren<Transform>();
        numberofblocks=children.Length;
    }

}
