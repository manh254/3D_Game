using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    private Renderer nodeRenderer;
    private Color originColor;
    public bool hasHero = false;

    private BuildingSystem buildingSystem;

    private void Start()
    {
        buildingSystem = GameObject.Find("BuildingSystem").GetComponent<BuildingSystem>();
        nodeRenderer = GetComponent<Renderer>();
        originColor = nodeRenderer.material.color;
    }

    public void ResetNode()
    {
        if (hasHero)
        {
            //Debug.Log("hi");
            hasHero = false;
        }
    }

    private void OnMouseEnter()
    {
        if (buildingSystem.GetCurrentHero() != null && !hasHero)
        {
            nodeRenderer.material.color = Color.black;
        }
    }

    private void OnMouseExit()
    {
        nodeRenderer.material.color = originColor;
    }
}
