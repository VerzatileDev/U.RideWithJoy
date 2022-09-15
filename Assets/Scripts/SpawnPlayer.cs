using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject myPrefab = null; // Prefab
    public static GameObject obj; // Set in the Editor !
    Vector2 playerPosition = new Vector2(0, 0); // Spawn Object at the middle of the GameObject placement..

    void Start()
    {
        spawnPlayer();
    }

    public void spawnPlayer()
    {
        obj = Instantiate(myPrefab, transform.position, Quaternion.identity); // Get prefab give it position and etc.
    }
}