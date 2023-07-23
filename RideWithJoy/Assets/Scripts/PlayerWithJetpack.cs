using UnityEngine;

public class PlayerWithJetpack : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float jetPower = 40f;
    protected internal static bool iskilled = false;
    private float timer = 0;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    /*PLAYER JEYPACK MOVEMENT*/
    private void Update()
    {
        if(iskilled == false)
        {
            timer += Time.deltaTime;
            if(timer >1f)
            {
                FindObjectOfType<GameManager>().IncreaseDistance();
                timer = 0;
            }
        }

        bool jetEnabled = Input.GetButton("Jump");
        if (jetEnabled)
        {
            float finalpower = jetPower * Time.deltaTime;
            
            rb.AddForce(new Vector2(0, finalpower));
        }
    }

    /*OBSTACLE COLLISION*/
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            // Play sound .. Queue Here
            iskilled = true;
            Time.timeScale = 0;
        }
    }

    /* COIN COLLECTION COLLISION */
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "CoinCollected")
        {
            FindObjectOfType<GameManager>().IncreaseScore();
            Destroy(other.gameObject);
        }
    }
}