using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitHouse : MonoBehaviour
{

    public string changescene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(changescene);
    }
}
