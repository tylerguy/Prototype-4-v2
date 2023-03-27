using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player " + other.gameObject.name + " has died!");
        // get last checkpoint
        GameObject lastCheckPoint = GameObject.Find("CheckPointManager").GetComponent<CheckPointManager>().lastCheckPoint;
        // move player to last checkpoint
        other.gameObject.transform.position = lastCheckPoint.transform.position;
    }
}
