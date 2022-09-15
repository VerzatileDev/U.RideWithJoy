using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float JumpHeight = 3f;
    public static bool iskilled = false;
    //[SerializeField] AudioSource JumpSound;
    //[SerializeField] AudioSource ExplosionSound;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        jump();
    }

    private void jump()
    {
        if (Input.GetButtonDown("Jump") && iskilled == false)
        {
            rb.velocity = (Vector2.up * JumpHeight);  // Change later and add deltatime..
            //if (!JumpSound.isPlaying && iskilled == false && PauseMenu.GameIsPaused == false)
            //{
                //JumpSound.Play(); // <-- Add Sound later
            //}
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(" Colliding ");
        if (other.gameObject.tag == "Obstacle")
        {
            // Play sound .. Queue Here
            iskilled = true;
            rb.bodyType = RigidbodyType2D.Static; // can be removed later..

            Debug.Log(" Player Disabled ");
            Time.timeScale = 0;
        }
    }

    //Crouching ??  If In air Don't let them crouch if in power up mode don't let them maybe

    // if player collided with Obstacle Freeze Time and Kill them, force Back into the Pause Menu...



}