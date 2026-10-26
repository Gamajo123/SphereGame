using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreTest;

    private void Start()
    {
        UpdateScoreText(0);
    }
    public void UpdateScoreText(int scoreValue)
    {
        scoreTest.text = scoreValue.ToString();
    }
}
