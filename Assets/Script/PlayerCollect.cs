using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    [SerializeField ] private ScoreData ScoreData;
    [SerializeField ] private UIController uiController;
    [SerializeField ] private SpawnController spawnController;

    private void OnTriggerEnter(Collider other)
    {
        Target target = other.gameObject.GetComponent<Target>();
        TargetMalus Malus = other.gameObject.GetComponent<TargetMalus>();
        Debug.Log("Touch Something");

        if (target)
        {
            ScoreData.Score = ScoreData.Score + target.ScoreValue;
            uiController.UpdateScoreText(ScoreData.Score);
            
            GetComponent<AudioSource>().Play();
            Debug.Log("Target");
            Destroy(other.gameObject);
            
        }

        if (Malus)
        {
            ScoreData.Score = ScoreData.Score + Malus.ScoreValue;
            uiController.UpdateScoreText(ScoreData.Score);

            Malus.GetComponent<ColorFeedback>().ChangeMaterial();
            GetComponent<ReturnNormal>().ReturnStart();

            Debug.Log("Malus");
            

        }


    }
}
