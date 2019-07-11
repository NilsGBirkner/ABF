using UnityEngine;

public class SetStairUG : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EG_OG_Player")
        {
            SaveValues.CurrentExit = false;
        }
    }
}