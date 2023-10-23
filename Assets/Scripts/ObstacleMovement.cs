using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Player playerObject;
    public int awardedScore;
    private float xSpeed = -4f;

    void Start()
    {
        // Initialize playerObject by finding the Player component in the scene.
        playerObject = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        if (playerObject == null)
        {
            playerObject = null;
        }
    }

    void Update()
    {
        transform.Translate(new Vector3(xSpeed * Time.deltaTime, 0, 0f));
        if (transform.position.x < -10)
        {
            if (playerObject != null)
            {
                playerObject.UpdateScore(awardedScore);
            }
            Destroy(this.gameObject);
        }
    }
}