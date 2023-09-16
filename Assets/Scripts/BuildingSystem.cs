using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSystem : MonoBehaviour
{
    public GameObject prefabsToBuild;
    bool isEmpty = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (!isEmpty)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Vector3 blockSize = hit.collider.bounds.size;
                Vector3 blockPosition = hit.collider.transform.position;

                
                Vector3 towerPosition = blockPosition + new Vector3(0, blockSize.y, 0);

                Instantiate(prefabsToBuild, towerPosition, Quaternion.identity);
                //Instantiate(prefabsToBuild, transform.position, Quaternion.identity);
                isEmpty = true;
            }
        }


        
    }



}
