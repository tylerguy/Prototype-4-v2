using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
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
        Debug.Log("Player " + other.gameObject.name + " has reached a checkpoint!");
        // set last checkpoint
        GameObject.Find("CheckPointManager").GetComponent<CheckPointManager>().lastCheckPoint = gameObject;
    }
}
