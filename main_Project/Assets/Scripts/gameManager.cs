using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static int gems = 0;
    public static bool hasBow = false;
    public static bool hasStaff = false;

    public static int getGems()
    {
        return gems;
    }
    public static bool getBow()
    {
        return hasBow;
    }
    public static bool getStaff()
    {
        return hasStaff;
    }

    public static void addGems(int value)
    {
        gems  += value;
    }
    public static void gotBow()
    {
        hasBow = true;
    }
    public static void addStaff()
    {
        hasStaff = true;
    }
}
