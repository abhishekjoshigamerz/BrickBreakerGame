using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] PaddleMovement paddle1;
    bool hasStarted = false;
    Vector2 paddleToBallVector;
    [SerializeField] float xPush,yPush;
    [SerializeField] AudioClip[] ballClip;
    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
    }

    void Update()
    {
        if(!hasStarted){
               LockBallToPaddle();
                Launchball();
        }
     
       
    }

    void LockBallToPaddle(){
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x,paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
        
    }
    void Launchball(){
        if(Input.GetMouseButtonDown(0)){
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush,yPush);
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        
        if(hasStarted){
            AudioClip clip = ballClip[UnityEngine.Random.Range(0,ballClip.Length)];
            GetComponent<AudioSource>().PlayOneShot(clip);
        }
    }
}
