using UnityEngine;

public class TakeKey : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        KeyManager Key = other.gameObject.GetComponent<KeyManager>();

        Key.Keyhole = true;

        Destroy(gameObject);

    }
}
