using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;
    //displays how many seeds are left to be planted and how many already have been
    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        _plantedText.text = ("" + seedsPlanted);
        _remainingText.text = ("" + seedsLeft);
    }
}