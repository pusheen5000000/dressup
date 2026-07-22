using UnityEngine;

public class CharacterWardrobe : MonoBehaviour
{
    // The placeholder slot on your character's head
    [Header("Character Sprite Slots")]
    public SpriteRenderer hairSlot;
    public SpriteRenderer eyesSlot;
    public SpriteRenderer skinSlot;
    public SpriteRenderer browSlot;
    public SpriteRenderer mouthSlot;
    public SpriteRenderer clothesSlot;

    [Header("Default Assets")]
    public Sprite defaultHair;
    public Sprite defaultEyes;
    public Sprite defaultSkin;
    public Sprite defaultBrow;
    public Sprite defaultMouth;
    public Sprite defaultClothes;

    void Start()
    {
        ResetAllToDefault();
    }
    // Changes the hair sprite to whatever is passed into the function
    public void EquipHair(Sprite newHairSprite)
    {
        // If the player clicks the SAME hair they are wearing, reset it to the default
        if (hairSlot.sprite == newHairSprite)
        {
            hairSlot.sprite = defaultHair;
        }
        else
        {
            // Otherwise, paint the new hair texture onto the slot
            hairSlot.sprite = newHairSprite;
        }
    }
    public void EquipEyes(Sprite newEyesSprite)
    {
        if (eyesSlot.sprite == newEyesSprite)
        {
            eyesSlot.sprite = defaultEyes;
        }
        else
        {
            eyesSlot.sprite = newEyesSprite;
        }
    }

    public void EquipSkin(Sprite newSkinSprite)
    {
        if (skinSlot.sprite == newSkinSprite)
        {
            skinSlot.sprite = defaultSkin;
        }
        else
        {
            skinSlot.sprite = newSkinSprite;
        }
    }
    public void EquipBrow(Sprite newBrowSprite)
    {
        if (browSlot.sprite == newBrowSprite)
        {
            browSlot.sprite = defaultBrow;
        }
        else
        {
            browSlot.sprite = newBrowSprite;
        }
    }
    public void EquipMouth(Sprite newMouthSprite)
    {
        if (mouthSlot.sprite == newMouthSprite)
        {
            mouthSlot.sprite = defaultMouth;
        }
        else
        {
            mouthSlot.sprite = newMouthSprite;
        }
    }
    public void EquipClothes(Sprite newClothesSprite)
    {
        if (clothesSlot.sprite == newClothesSprite)
        {
            clothesSlot.sprite = defaultClothes;
        }
        else
        {
            clothesSlot.sprite = newClothesSprite;
        }
    }

    public void ResetAllToDefault()
    {
        if (defaultHair != null) hairSlot.sprite = defaultHair;
        if (defaultEyes != null) eyesSlot.sprite = defaultEyes;
        if (defaultSkin != null) skinSlot.sprite = defaultSkin;
        if (defaultBrow != null) browSlot.sprite = defaultBrow;
        if (defaultMouth != null) mouthSlot.sprite = defaultMouth;
        if (defaultClothes != null) clothesSlot.sprite = defaultClothes;
    }

}