using UnityEngine;

public class KeyCondition : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        KeyManager Key = other.gameObject.GetComponent<KeyManager>();

        if (Key.Keyhole == true)
        {
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("trouve la clé");
        }
        

    }
}
