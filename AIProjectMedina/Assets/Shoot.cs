using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject shellPrefab;
    public GameObject shellSpawnPos;
    public GameObject target;
    public GameObject parent;
    float speed = 15;

    float turnSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Fire()
    {
        GameObject shell = Instantiate(shellPrefab, shellSpawnPos.transform.position, shellSpawnPos.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Fire();

        Vector3 direction = (target.transform.position - parent.transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        parent.transform.rotation = Quaternion.Slerp(parent.transform.rotation, lookRotation, Time.deltaTime * turnSpeed);
    }
}
