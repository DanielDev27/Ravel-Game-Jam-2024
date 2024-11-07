using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using TMPro;
using Sirenix.OdinInspector;

public class VisualManager : MonoBehaviour
{
    public TMP_Text dialogBox;
    public TMP_Text mainNameTag;
    public TMP_Text secondaryNameTag;
    public Image mainCharacterImage;
    public Image secondaryCharacterImage;
    public Image backgroundImage;
    [SerializeField, ShowInInspector] CharacterSO[] characters;
    [SerializeField, ShowInInspector] BackgroundSO[] backGrounds;

    [Header("Debug")]
    [SerializeField] private CharacterSO character;
    [SerializeField] public BackgroundSO background;

    public void ChangeCharacter(string name)
    {
        foreach (CharacterSO charSO in characters)
        {
            if (charSO.characterName.Equals(name))
            {
                if (charSO.characterType == CharacterType.Main)
                {
                    character = charSO;
                    mainNameTag.text = charSO.characterName;
                    mainCharacterImage.sprite = charSO.characterArt;
                    mainCharacterImage.SetNativeSize();
                    SetMainCharacterImage(true);
                    break;
                }
                if (charSO.characterType == CharacterType.Secondary)
                {
                    character = charSO;
                    secondaryNameTag.text = charSO.characterName;
                    secondaryCharacterImage.sprite = charSO.characterArt;
                    secondaryCharacterImage.SetNativeSize();
                    SetSecondCharacterImage(true);
                    break;
                }
            }
        }
    }

    public void ChangeBackground(int sceneIndex)
    {
        background = backGrounds[sceneIndex - 1];
    }

    public void SetMainCharacterImage(bool active)
    {
        mainCharacterImage.GetComponent<Image>().enabled = active;
    }
    public void SetMainCharacterName(bool active)
    {
        mainNameTag.GetComponent<TMP_Text>().enabled = active;
    }
    public void SetSecondCharacterImage(bool active)
    {
        secondaryCharacterImage.GetComponent<Image>().enabled = active;
    }
    public void SetSecondCharacterName(bool active)
    {
        secondaryNameTag.GetComponent<TMP_Text>().enabled = active;
    }
}
