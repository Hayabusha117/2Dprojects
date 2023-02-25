using UnityEngine;

public class DKController : MonoBehaviour
{
    public SpriteRenderer dkSprite;
    public float dkSpeed;
    public float dkJumpForce;
    private bool onGround;
    private Touch fingerTouch;
    private Rigidbody2D dkRigidBody;
    private Vector2 dkMovement;
    private Animator dkAnimator;
    private AnimatorStateInfo dkAnimatorInfo;
    private Vector2 touchStarPos;
    private Vector2 swipeDir;
    private float angle;
    // Start is called before the first frame update
    void Start()
    {
        dkRigidBody = GetComponent<Rigidbody2D>();
        dkAnimator = GetComponent<Animator>();
        onGround = true;
    }

    // Update is called once per frame
    void Update()
    {
        dkAnimatorInfo = dkAnimator.GetCurrentAnimatorStateInfo(0);

        Debug.Log("Accel: " + Input.acceleration);
#if UNITY_ANDROID 
        dkMovement = Vector2.zero;

        if (Input.touchCount > 0)
        {
            fingerTouch = Input.GetTouch(0);
            switch (fingerTouch.phase)
            {
                case TouchPhase.Began:
                    touchStarPos = fingerTouch.position;
                    break;
                case TouchPhase.Ended:
                    swipeDir = fingerTouch.position - touchStarPos;
                    swipeDir.Normalize();
                   
                    
                    break;
            }
            angle = Vector2.Angle(Vector2.right, swipeDir);
            if(angle > 60f && angle < 120f && onGround == true)
            {
                dkAnimator.SetTrigger("jump");
                dkRigidBody.AddForce(Vector2.up * dkJumpForce, ForceMode2D.Impulse);
            }

            Debug.Log("Touch count: " + Input.touchCount);
            Debug.Log("Touch position" + fingerTouch.position);
            if(fingerTouch.position.x < (Screen.width) * 0.5f)
            {
                dkSprite.flipX = true;
                dkMovement.x = -dkSpeed;
            }
            else
            {
                dkSprite.flipX = false;
                dkMovement.x = dkSpeed;
            }
            dkAnimator.SetFloat("speed", dkSpeed);
        }
        else
        {
            dkAnimator.SetFloat("speed", 0f);
            dkMovement.x = 0f;
        }
        dkMovement.y = dkRigidBody.velocity.y;
        dkRigidBody.velocity = dkMovement;
       /* if(Mathf.Abs(Input.acceleration.z) > 1.0f && !dkAnimatorInfo.IsName("Jump")&& onGround == true)
        {
            dkAnimator.SetTrigger("jump");
            dkRigidBody.AddForce(Vector2.up * dkJumpForce,ForceMode2D.Impulse);
        }*/
#endif
/*#if UNITY_EDITOR
        if (Input.GetAxis("Horizontal") >= 0)
        {
            dkSprite.flipX = false;
        }
        else
        {
            dkSprite.flipX = true;
        }
#endif*/

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        onGround = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        onGround = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Item"))
            Destroy(collision.gameObject);
    }
}
