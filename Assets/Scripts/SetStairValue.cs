using UnityEngine;

public class SetStairValue : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EG_OG_Player")
        {
            SaveValues.CurrentExit = true;
        }
    }
}
