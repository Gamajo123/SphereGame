using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    [SerializeField ] private ScoreData ScoreData;
    [SerializeField ] private UIController uiController;
    [SerializeField ] private SpawnController spawnController;

    private void OnTriggerEnter(Collider other)
    {
        Target target = other.gameObject.GetComponent<Target>();
        Debug.Log("Touch Something");

        if (target)
        {
            ScoreData.Score = ScoreData.Score + target.ScoreValue;
            uiController.UpdateScoreText(ScoreData.Score);
            //spawnController.OnTargetDestroyed(target);
            target.GetComponent<ColorFeedback>().ChangeMaterial();
            GetComponent<ReturnNormal>().ReturnStart();
            GetComponent<AudioSource>().Play();
            Debug.Log("Touch Cube");
            Destroy(other.gameObject);
            
        }
    }
}
