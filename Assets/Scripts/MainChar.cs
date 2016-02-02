using UnityEngine;
using System.Collections;

public class MainChar : MonoBehaviour {
    public float speed = 0.8f;

    private Animator animator;
	void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        //left right move
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 pointToTranslate = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x + 1f, transform.position.y), speed);
            GetComponent<Rigidbody2D>().MovePosition(pointToTranslate);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 pointToTranslate = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x - 1f, transform.position.y), speed);
            GetComponent<Rigidbody2D>().MovePosition(pointToTranslate);
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            animator.SetBool("isAttacking", true);
        }
        
        
    }
   
    void Update()
    {
        //turn based on alphabet
        if (Input.GetKeyDown(KeyCode.X))
        {
            transform.Rotate(new Vector3(0, 180, 0));
        }
    }
    
}
