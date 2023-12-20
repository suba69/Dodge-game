using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject block;
    public float maxX;
    public Transform spawnPoint;
    public float spawnRate;
    public GameObject tapText;
    public TextMeshProUGUI scoreText;
    private int score;
    private bool gameStarted = false;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            StartSpawning();
            gameStarted = true;
            tapText.SetActive(false);
        } 
    }

    private void StartSpawning()
    {
        InvokeRepeating("SpawnBlock", 3f, spawnRate);
    }

    private void SpawnBlock()
    {
        Vector3 spawnPos = spawnPoint.position;
        spawnPos.x = Random.Range(-maxX, maxX);
        Instantiate(block, spawnPos, Quaternion.identity);

        score++;
        scoreText.text = score.ToString();
    }
}
