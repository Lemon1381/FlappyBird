using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public Rigidbody2D pipes;
    public float speed;
    private float startTimeForDistroy;
    private float timeForDistroy;

    void Start()
    {
        timeForDistroy = 10 / speed;
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (timeForDistroy <= 0)
        {
            DestroyObjectDelayed();
            Debug.Log("Destroy");
        }
        else
        {
            timeForDistroy -= Time.deltaTime;
        }
    }
    void DestroyObjectDelayed()
    {
        Destroy(gameObject);
    }
}
