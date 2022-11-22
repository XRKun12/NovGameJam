using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableManager : MonoBehaviour
{
    // Start is called before the first frame update

    enum PickUpType {Meal,Cloak}

    [SerializeField] private PickUpType pickUpType;
    InventoryManager playerInventory;
    void Start()
    {
        playerInventory = GameObject.Find("Player").GetComponent<InventoryManager>();
        //playerInventory.UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.name == "Player")
        {
            Destroy(gameObject);
            playerInventory.hasPlate = true;
            playerInventory.UpdateUI();
        }
    }
}
