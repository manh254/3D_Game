using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSystem : MonoBehaviour
{
    private HeroBlueprint currentHero;
    private Shop shop;
    private void Start()
    {
        shop = GameObject.Find("Shop").GetComponent<Shop>();
    }
    public void BuyHero(HeroBlueprint hero)
    {
        currentHero = hero;
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
            if (Input.GetMouseButtonDown(0) && !hit.collider.GetComponent<Node>().hasHero && currentHero.GetCost() <= shop.GetMoney())
            {
                Instantiate(currentHero.GetHeroPrefabs(), towerPosition, Quaternion.Euler(0, 90, 0));
                BuyHeroSuccess();
                hit.collider.GetComponent<Node>().hasHero = true;
                currentHero = null;
            }

        }
    }
    
    private void BuyHeroSuccess()
    {
        shop.BuyHeroSuccess(currentHero);
    }

}
