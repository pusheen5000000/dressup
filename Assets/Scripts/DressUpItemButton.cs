using UnityEngine;
using UnityEngine.UI;

public class DressUpItemButton : MonoBehaviour
{
    // A dropdown list visible in the Unity Inspector
    public enum ItemType { Hair, Eyes, Skin, Eyebrows, Mouth, Clothing }

    [Header("Item Configuration")]
    public ItemType category;       // Choose Hair, Eyes, or Clothes in Inspector
    public Sprite itemSprite;       // The asset graphic for this specific button

    private CharacterWardrobe wardrobe;

    void Start()
    {
        wardrobe = FindAnyObjectByType<CharacterWardrobe>();

        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnItemClicked);
    }

    void OnItemClicked()
    {
        if (wardrobe == null) return;

        // Route the item to the correct slot based on the dropdown choice
        switch (category)
        {
            case ItemType.Hair:
                wardrobe.EquipHair(itemSprite);
                break;
            case ItemType.Eyes:
                wardrobe.EquipEyes(itemSprite);
                break;
            case ItemType.Skin:
                wardrobe.EquipSkin(itemSprite);
                break;
            case ItemType.Eyebrows:
                wardrobe.EquipBrow(itemSprite);
                break;
            case ItemType.Mouth:
                wardrobe.EquipMouth(itemSprite);
                break;
            case ItemType.Clothing:
                wardrobe.EquipClothes(itemSprite);
                break;
        }
    }
}