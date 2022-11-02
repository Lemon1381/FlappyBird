using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public int points;
    public int power;
    public Text playerPoints;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.AddForce(Vector2.up * power, ForceMode2D.Impulse);
        }
        playerPoints.text = points.ToString();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (PlayerPrefs.GetInt("Score") < points)
        {
            PlayerPrefs.SetInt("Score", points);
        }
        //PlayerPrefs.DeleteKey("Score");
        Destroy(gameObject);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        points++;
    }
}
