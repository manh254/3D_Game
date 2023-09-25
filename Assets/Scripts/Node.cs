using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public bool hasHero = false;

    public void ResetNode()
    {
        if (hasHero)
        {
            Debug.Log("hi");
            hasHero = false;
        }
    }
}
