using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  // Public values to adjust
  public float speed = 1.0f;

  // Private values
  private bool shouldMove = false;
  private Vector3 destination = new Vector3(0, 0, 0);
  private Animator animator;
  
  // Start is called before the first frame update
  void Start()
  {  
    animator = GetComponent<Animator>();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetButtonDown("Fire1")) {
      shouldMove = true;
      Vector3 mousePos = Input.mousePosition;
      destination = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10));
      animator.SetBool("isWalk", true);
      if (destination.x < transform.position.x) {
        transform.localScale = new Vector3(-1, 1, 1);
      } else {
        transform.localScale = new Vector3(1, 1, 1);
      }
    }


    float step = speed * Time.deltaTime;
    if (shouldMove) {
      transform.position = Vector3.MoveTowards(transform.position, destination, step);
      float distance = Vector3.Distance(transform.position, destination);
      if (distance == 0) {
        animator.SetBool("isWalk", false);
        shouldMove = false;
      }
    }
  }
}
