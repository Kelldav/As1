
using UnityEngine;
using System;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerPlatformController : MonoBehaviour {
  public float movementSpeed = 5.0f;
  public float jumpForce = 750.0f;
  public int gemCount=0;
  private Rigidbody2D rigidBody;
  private bool isGrounded;
  private bool still=true;
  private bool facingRight=true;
  private Animator animator;
  private void Start() {
      animator = GetComponent<Animator>();
      rigidBody = GetComponent<Rigidbody2D>();
      rigidBody.freezeRotation = true;

  }

  private void Update() {
      float movementX = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
      if (Input.GetButtonDown("Jump")) {
        if(isGrounded==true){
          //animator.SetBool("IsJumping", true);
          rigidBody.AddForce(transform.up * jumpForce);
        }
      }
      animator.SetBool("IsJumping",!isGrounded);
      animator.SetFloat("movementSpeed", Mathf.Abs(movementX));
      if(movementX == 0.0f){
        still=true;
      }
      else{
        still = false;
      }
      animator.SetBool("standingStill",still);
      //For testing
      //print("Grounded="+isGrounded);
      if(movementX<0 && facingRight){
        flip();
      }
      if(movementX>0 && !facingRight){
        flip();
      }
      transform.Translate(new Vector3(movementX, 0.0f, 0.0f));
  }
void flip(){
  facingRight= !facingRight;
  //TODO find a way to flip the rigidbody without flipping the world
}
void OnCollisionStay2D(Collision2D collider)
{
    CheckIfGrounded ();
}

void OnCollisionExit2D(Collision2D collider)
{
    //animator.SetBool("IsJumping", true);
    isGrounded = false;

}
void OnTriggerEnter2D(Collider2D other){
  if(other.gameObject.CompareTag("Gem")){
    Destroy(other.gameObject);
    gemCount++;
  }
}
private void CheckIfGrounded()
{
    RaycastHit2D[] hits;

    //We raycast down 1 pixel from this position to check for a collider
    Vector2 positionToCheck = transform.position;
    hits = Physics2D.RaycastAll (positionToCheck, new Vector2 (0, -1), 0.01f);

    //if a collider was hit, we are grounded
    if (hits.Length > 0) {
        //animator.SetBool("IsJumping", false);
        isGrounded = true;

    }
}

}
