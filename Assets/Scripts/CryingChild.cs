using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CryingChild : MonoBehaviour
{
    public GameObject player;

    public AudioSource sfx;
    private AudioHighPassFilter highpass;
    private AudioReverbZone rev;
    private Ray ray;
    private RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        ray = new Ray(transform.position, Vector3.right);
        highpass = sfx.GetComponent<AudioHighPassFilter>();
        rev = sfx.GetComponent<AudioReverbZone>();
        highpass.highpassResonanceQ = 1;
        if (Physics.Raycast(ray, out hit) && hit.collider.tag != "EG_OG_Player")
        {
            highpass.cutoffFrequency = 3000;
            rev.maxDistance = 0;
        }
        else
        {
            highpass.cutoffFrequency = 0;
            rev.maxDistance = 30;
            StartCoroutine(waitForStop());
        }
    }

    IEnumerator waitForStop()
    {
        yield return new WaitForSeconds(3);
        sfx.Stop();
    }
}
