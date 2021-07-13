using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
   [SerializeField]  float screenWidthInUnits = 16f;
   [SerializeField] float minX= 1f;
   [SerializeField] float maxX = 15f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnits = Input.mousePosition.x/Screen.width * screenWidthInUnits;
        Vector2 paddlePost = new Vector2(transform.position.x,transform.position.y);
        paddlePost.x = Mathf.Clamp(mousePosInUnits,minX,maxX);
        transform.position = paddlePost;
    }
}
