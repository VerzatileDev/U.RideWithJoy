using System.Threading;
using UnityEngine;

public class PlayerWithJetpack : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float jetPower = 40f;
    [SerializeField] public static bool iskilled = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        bool jetEnabled = Input.GetButton("Jump");
        if (jetEnabled)
        {
            float finalpower = jetPower * Time.deltaTime;
            
            rb.AddForce(new Vector2(0, finalpower));
            //Debug.Log(finalpower);
            // If you are looking this in the future don't do this do something better just no time. 
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

}