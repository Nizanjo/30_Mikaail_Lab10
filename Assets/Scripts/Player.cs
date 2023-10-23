using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int playerScore;

    private float yMin = -2.5f, yMax = 4.5f;
    public float speed;

    public Text scoreText;

    void Start()
    {
        playerScore = 0;
    }

    void Update()
    {
        // Vertical movement.
        float verticalInput = Input.GetAxis("Vertical");
        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

        // Clamp the vertical position of the player.
        transform.position = new Vector3(-8, Mathf.Clamp(transform.position.y, yMin, yMax), 0);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("LoseScene");
        }
    }

    public void UpdateScore(int p_scoreNum)
    {
        playerScore += p_scoreNum;
        scoreText.text = "Score : " + playerScore;
    }
}
