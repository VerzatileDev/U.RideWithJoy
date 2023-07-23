using UnityEngine;

public class SpawnWorld : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private float TimeToStartFromSpawnRate = 0f;
    [SerializeField] private float TimeToNextSpawn = 10f;
    Quaternion rotation = Quaternion.Euler(0, 180, 0); // Consider variable that can be set in editor.

    private void OnEnable()
    {
        InvokeRepeating(nameof(SpawnPrefab), TimeToStartFromSpawnRate, TimeToNextSpawn);
    }

    private void SpawnPrefab()
    {
        GameObject WorldElements = Instantiate(prefab, transform.position, rotation); // Clone GameObject Prefab, Its Position, set rotation "
    }
}