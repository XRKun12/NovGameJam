using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public bool hasPlate = false;
    public bool objectiveOneComplete = false;
    public Text collectable;
    public Text satchelText;
    public Text objectiveStatus;

    // Start is called before the first frame update
    void Start()
    {
        satchelText = GameObject.Find("SatchelContents").GetComponent<Text>();
        //ObjectiveText
        objectiveStatus = GameObject.Find("ObjectiveText").GetComponent<Text>();
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateUI()
    {
        if(hasPlate&&satchelText!=null)
        {
            satchelText.text = "5 Star Meal";
        }
        else
        {
            satchelText.text = "Empty";
        }

        if(objectiveOneComplete)
        {
            objectiveStatus.text = "Solved";
        }
        else
        {
            objectiveStatus.text = "Unsolved";
        }
    }
}
