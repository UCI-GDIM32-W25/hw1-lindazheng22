using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditor;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;
    //public TextMeshProUGUI _plantedText;
    //public TextMeshProUGUI _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        _plantedText.SetText(seedsPlanted.ToString());
        _remainingText.SetText(seedsLeft.ToString());
        //_plantedText.text = seedsPlanted.ToString();
        //_remainingText.text = seedsLeft.ToString();
        Debug.Log("Seeds Updated");
    }
}