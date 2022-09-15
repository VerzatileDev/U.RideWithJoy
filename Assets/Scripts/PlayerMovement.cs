using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float JumpHeight = 3f;
    public static bool iskilled = false;
    //[SerializeField] AudioSource JumpSound;
    //[SerializeField] AudioSource ExplosionSound;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
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
            //if (!hopSound.isPlaying && iskilled == false && PauseMenu.GameIsPaused == false)
            //{
                //hopSound.Play(); // <-- Add Sound later
            //}
        }
    }

    //Crouching ??  If In air Don't let them crouch if in power up mode don't let them maybe

    // if player collided with Obstacle Freeze Time and Kill them, force Back into the Pause Menu...



}