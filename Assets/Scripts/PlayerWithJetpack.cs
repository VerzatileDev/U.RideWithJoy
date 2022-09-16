using System.Threading;
using UnityEngine;

public class PlayerWithJetpack : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float jetPower = 70f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        bool jetEnabled = Input.GetButton("Jump");
        if (jetEnabled)
        {
            rb.AddForce(new Vector2(0, jetPower));
        }
    }
}