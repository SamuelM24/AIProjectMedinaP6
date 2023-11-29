using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToGoal : MonoBehaviour
{
    public Transform goal;
    public float speed = 2.0f;
    public float accuracy = 0.01f;

    void Start()
    {
        this.transform.LookAt(goal.position);
    }

    void Update()
    {
        Vector3 direction = goal.position - this.transform.position;
        Debug.DrawRay(this.transform.position, direction, Color.red);
        if (direction.magnitude > accuracy)
            this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }
}