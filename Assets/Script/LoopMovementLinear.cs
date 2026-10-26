using System.Net.NetworkInformation;
using UnityEngine;

public class LoopMovementLinear : MonoBehaviour
{

    [SerializeField] private Transform[] SpawnPointArray;
    [SerializeField] private float distancePercentage;
    [SerializeField] private float speed;
    [SerializeField] private float timer;
    [SerializeField] private float actualDistance;
    [SerializeField] private float maxDistance;
    [SerializeField] private int originIndex = 0;
    [SerializeField] private int endIndex = 1;

    private void Start()
    {
        maxDistance = Vector3.Distance(SpawnPointArray[originIndex].position, SpawnPointArray[endIndex].position);
    }

    private void FixedUpdate()
    {
        timer = timer + Time.fixedDeltaTime;
        actualDistance = actualDistance + timer * speed;
        distancePercentage =actualDistance/maxDistance;
        transform.position = Vector3.Lerp(SpawnPointArray[originIndex].position, SpawnPointArray[endIndex].position, distancePercentage);

        if (actualDistance >= maxDistance)
        {
            timer = 0;
            actualDistance = 0;
            originIndex = (originIndex + 1) % SpawnPointArray.Length;
            endIndex = (endIndex + 1) % SpawnPointArray.Length;
            maxDistance = Vector3.Distance(SpawnPointArray[originIndex].position, SpawnPointArray[endIndex].position);
        }
    }
}
