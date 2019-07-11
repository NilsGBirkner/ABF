using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGhost : MonoBehaviour
{
    public Transform[] targets;
    public float speed;

    private int current;

    // Update is called once per frame
    void Update()
    {
        if (transform.position != targets[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, targets[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        {
            current = (current + 1) % targets.Length;
            targets[0] = targets[1];
            transform.Rotate(new Vector3(0f, 90f, 0f));
        }
    }
}
