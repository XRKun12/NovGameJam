using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    // Start is called before the first frame update
    InventoryManager playerInventory;
    void Start()
    {
        playerInventory = GameObject.Find("Player").GetComponent<InventoryManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(playerInventory.hasPlate)
        {
            playerInventory.objectiveOneComplete = true;
        }
        playerInventory.UpdateUI();
    }
}
