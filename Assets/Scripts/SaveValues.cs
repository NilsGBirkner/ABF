using System.Collections;
using UnityEngine.UI;
using UnityEngine;
public static class SaveValues
{
    private static bool[] tookKeys = { false, false, false, false, false };

    /*
     * CurrentExit -> True => Ausgang von OG
     * CurrentExit -> False => Ausgang von UG
     */
    public static bool CurrentExit { get; set; } = true;

    public static int currentKeys = 0;
    public static float timeLeft { get; set; } = 30000;
    /*
     * Functions
     */
    public static bool getTakenKeys(int index)
    {
        try
        {
            return tookKeys[index];
        }
        catch
        {
            return false;
        }
    }

    public static void setTakenKeys(int index, bool value)
    {
        try
        {
            tookKeys[index] = value;
        }
        catch
        {
            Debug.LogError("Error while editing Key!\n" + "Trace: Index -> " + index + "\nValue: " + value);
        }
    }
}