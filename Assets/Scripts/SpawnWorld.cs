using UnityEngine;

public class SpawnWorld : MonoBehaviour
{
    public GameObject prefab; // Change this to private and serialie later on !!
    Quaternion rotation = Quaternion.Euler(0, 180, 0); // Rotates the Object Before spawning.
    public float TimeToStartFromSpawnRate = 0f;
    public float TimeToNextSpawn = 10f;


    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), TimeToStartFromSpawnRate, TimeToNextSpawn); // Needs a provided Method.
    }

    private void Spawn() // Spawns Prefab
    {
        GameObject WorldElements = Instantiate(prefab, transform.position, rotation); // Clone GameObject Fid GameObjects Position, set rotation "
        
    }
}