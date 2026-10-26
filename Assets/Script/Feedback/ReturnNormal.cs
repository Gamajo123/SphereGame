using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem.Controls;

public class ReturnNormal : MonoBehaviour
{
    [SerializeField] private Material newMaterial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ReturnStart()
    {
        StartCoroutine(Return());
    }

    // Update is called once per frame
    IEnumerator Return()
    {
        yield return new WaitForSecondsRealtime(2);
        GetComponent<MeshRenderer>().material = newMaterial;
    }
}
