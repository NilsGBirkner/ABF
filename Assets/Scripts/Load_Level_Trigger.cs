using System;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Load_Level_Trigger : MonoBehaviour
{

    private enum Scenes { EG = 0, OG, UG };
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EG_OG_Player")
        {

            switch (SceneManager.GetActiveScene().buildIndex)
            {
                case 1:
                    if (SaveValues.CurrentExit)
                    {
                        SceneManager.LoadScene(Convert.ToInt32(Scenes.OG));
                    }
                    else
                    {
                        SceneManager.LoadScene(Convert.ToInt32(Scenes.UG));
                    }
                    
                    break;
                case 0: //OG
                    SceneManager.LoadScene(Convert.ToInt32(Scenes.EG));
                    break;
                case 2: //UG
                    SceneManager.LoadScene(Convert.ToInt32(Scenes.EG));
                    break;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Loading Trigger deactivated.");
    }
}
