using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public GameObject prefab;
    [SerializeField] private float SpawnDistance = 2f;
    [SerializeField] private float minHeight = 1f;
    [SerializeField] private float maxHeight = 9f;
    Quaternion rotation = Quaternion.Euler(90, 0, 0); // Rotates the Object Before spawning.

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), SpawnDistance, SpawnDistance);
    }

    private void Spawn() // Spawns The Set Prefab Of Pipes And Box Collector
    {
        GameObject coin = Instantiate(prefab, transform.position, rotation); // Cloning and setting Rotation
        coin.transform.position += Vector3.up * Random.Range(minHeight, maxHeight); // Positions they spawn from
    }
}
