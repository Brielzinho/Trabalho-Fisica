using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumScript : MonoBehaviour
{
    public float speed = 0f;
    public float limit = 75f;
    public bool randomStart = false;
    public float random = 0;

    void Awake()
    {
        if (randomStart)
            random = Random.Range(0f, 1f);
    }

    void Update()
    {
        float angle = limit * Mathf.Sin(Time.time + random * speed);
        transform.localRotation = Quaternion.Euler(0, 0, angle * -1);
    }
}
