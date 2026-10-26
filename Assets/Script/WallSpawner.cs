using Unity.VisualScripting;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab ;
    [SerializeField] private Transform SpawnPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void SpawnNewWall()
    {
        Instantiate(prefab, SpawnPosition);
    }
}
