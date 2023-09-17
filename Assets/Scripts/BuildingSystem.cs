using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSystem : MonoBehaviour
{
    public GameObject prefabsToBuild;
    public GameObject currentHero;
    //bool isEmpty = false;
    public void BuyHero(GameObject hero)
    {
        currentHero = hero;
        Debug.Log("Ok");
    }
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 blockSize = hit.collider.bounds.size;
            Vector3 blockPosition = hit.collider.transform.position;
            Vector3 towerPosition = blockPosition + new Vector3(0, blockSize.y, 0);
            if (Input.GetMouseButtonDown(0) && !hit.collider.GetComponent<Node>().hasHero)
            {
                Instantiate(currentHero, towerPosition, Quaternion.identity);
                hit.collider.GetComponent<Node>().hasHero = true;
                currentHero = null;
            }

        }



    }



}