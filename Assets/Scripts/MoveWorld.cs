using UnityEngine;

public class MoveWorld : MonoBehaviour
{
    public float WorldElementSpeed = 5f;
    private float WorldleftEdge; // Screen Space Defined to Destroy GameObject

    private void Start()
    {
        WorldleftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 70; // -1 pushing to make sure it goes off screen fully.
    }

    // Update Movement of the World !
    void Update()
    {
        transform.position += Vector3.left * WorldElementSpeed * Time.deltaTime;

        if (transform.position.x < WorldleftEdge)
        {
            Destroy(gameObject);
        }
    }
}