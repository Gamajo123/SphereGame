using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private List<Target> targets;
    [SerializeField] private List<WallSpawner> wallSpawner;
    [SerializeField] private LevelManager levelManager;

    private int actualIndex;

    public void OnTargetDestroyed(Target targetDestroyed)
    {
        if (targets.Contains(targetDestroyed))
        {
            targets.Remove(targetDestroyed);
            if (targets.Count <= 0)
            {
                //Victoire
                levelManager.LoadNewScene();

            }
            else if (actualIndex < wallSpawner.Count)
            {
                //Spawn New Wall
                wallSpawner[actualIndex].SpawnNewWall();
            }
        }
    }
}
