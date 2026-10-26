using UnityEngine;
using UnityEngine.SceneManagement;

public class Grappling : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(prefab);
        }
    }
}
