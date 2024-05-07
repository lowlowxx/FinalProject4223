using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public GameObject targetPrefab;
    public int score = 0;
    private int totalTargets = 5;

    void Start()
    {
        SpawnTargets();
    }

    void Update()
    {
        if (score >= totalTargets)
        {
            SceneManager.LoadScene("Exit");
        }
    }

    void SpawnTargets()
    {
        for (int i = 0; i < totalTargets; i++)
        {
            float x = Random.Range(-4.0f, 4.0f);
            float y = Random.Range(-4.0f, 4.0f);
            Instantiate(targetPrefab, new Vector2(x, y), Quaternion.identity);
        }
    }

    public void OnTargetHit()
    {
        score++;
    }

    public void OnStopButtonPressed()
    {
        SceneManager.LoadScene("Exit");
    }
}

public class Target : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            FindObjectOfType<GameScript>().OnTargetHit();
        }
    }
}