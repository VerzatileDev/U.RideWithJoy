using UnityEngine;

public class SpawnWorld : MonoBehaviour
{
    public GameObject prefab; // Change this to private and serialie later on !!
    //public GameObject prefab2;
    Quaternion rotation = Quaternion.Euler(-90, 0, 0); // Rotates the Object Before spawning.
    public float TimeToStartFromSpawnRate = 0f;
    public float TimeToNextSpawn = 10f;


    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), TimeToStartFromSpawnRate, TimeToNextSpawn);// Needs a provided Method.
    }

    private void Spawn() // Spawns The Set Prefab Of Pipes And Box Collector
    {
        GameObject WorldElements = Instantiate(prefab, transform.position, rotation); // Cloning the gameobject Written and setting it with position identity "
        
    }
}