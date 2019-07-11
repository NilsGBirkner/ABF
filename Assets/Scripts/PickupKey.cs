using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupKey : MonoBehaviour
{
    public GameObject player;
    private Ray ray;
    private RaycastHit hit;
    private int index;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         ray = new Ray(player.transform.position, player.transform.forward);
        if (Physics.Raycast(ray, out hit))
        {
            switch(hit.collider.tag)
            {
                case "Key_1":
                    index = 0;
                    break;
                case "Key_2":
                    index = 1;
                    break;
                case "Key_3":
                    index = 2;
                    break;
                case "Key_4":
                    index = 3;
                    break;
                case "Key_5":
                    index = 4;
                    break;
                default:
                    // Ignore
                    return;
            }
            SaveValues.setTakenKeys(index, true);
            SaveValues.currentKeys += 1;
            DestroyImmediate(hit.collider);
        }
    }
}
