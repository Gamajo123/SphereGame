using UnityEngine;

public class ColorFeedback : MonoBehaviour
{
    [SerializeField] private Material newMaterial;

    public void ChangeMaterial()
    {
        GetComponent<MeshRenderer>().material = newMaterial;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<MeshRenderer>().material = newMaterial;
    }
}
