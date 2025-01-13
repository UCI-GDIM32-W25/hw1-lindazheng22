using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditor;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;
    //public Text planted;
    //public Text remaining;
    
    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        Debug.Log(1);
        _plantedText.SetText(seedsPlanted.ToString());
        _remainingText.SetText(seedsLeft.ToString());
        

        //if (Input.GetKeyDown(KeyCode.Space)) 
        {
            //_planted += 1;
            //planted.text = seedsPlanted.ToString();
            //remaining.text = seedsLeft.ToString();
            //Debug.Log("Seeds Updated");
        }
    }
}