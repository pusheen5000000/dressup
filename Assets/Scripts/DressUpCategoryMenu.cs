using UnityEngine;
using UnityEngine.UI;

public class DressUpCategoryMenu : MonoBehaviour
{
    // A custom data structure to keep a button and its panel paired together
    [System.Serializable]
    public struct CategoryData
    {
        public string categoryName;
        public Button tabButton;
        public GameObject contentPanel;
    }

    [Header("Categories Settings")]
    [Tooltip("Add all your categories here in the Unity Inspector")]
    public CategoryData[] categories;

    void Start()
    {
        // Check to prevent errors if the inspector is empty
        if (categories == null || categories.Length == 0) return;

        // Loop through every category in our array to set up button listeners
        for (int i = 0; i < categories.Length; i++)
        {
            // Cache the index for the click listener to avoid closure bugs in loops
            int index = i;
            categories[index].tabButton.onClick.AddListener(() => OpenCategory(index));
        }

        // Open the first category automatically on game launch
        OpenCategory(0);
    }

    public void OpenCategory(int activeIndex)
    {
        // Loop through the entire list of categories
        for (int i = 0; i < categories.Length; i++)
        {
            // If it matches our clicked index, turn it ON. Otherwise, turn it OFF.
            categories[i].contentPanel.SetActive(i == activeIndex);
        }
    }
}