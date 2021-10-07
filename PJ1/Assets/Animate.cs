using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    void Update()
    {
        var models = GameObject.FindGameObjectsWithTag("animal");
        if (models.Length >= 2)
        {
            var dir = models[0].transform.position - models[1].transform.position;
            if (dir.magnitude < 6)
            {
                models[0].GetComponent<Animator>().SetTrigger("jump");
                models[1].GetComponent<Animator>().SetTrigger("jump");
            }
        }

    }
}