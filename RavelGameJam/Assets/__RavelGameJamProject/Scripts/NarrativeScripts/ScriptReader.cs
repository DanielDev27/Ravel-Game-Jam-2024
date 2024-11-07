using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using Ink.Runtime;
using TMPro;
using Sirenix.OdinInspector;

public class ScriptReader : MonoBehaviour
{
    [Header("Basic Inputs")]
    [SerializeField] private TextAsset _inkJsonAsset;
    private Story _story;
    [SerializeField] private VisualManager visualManager;
    [SerializeField] private AudioManager audioManager;
    [SerializeField] public Canvas dialogueCanvas;
    [SerializeField] public GameObject[] UIMenus;
    [SerializeField] private KnittingGrid knittingGrid;

    [Header("Player Inputs")]
    public InputControls inputControls;
    [SerializeField] private bool _space;

    [Header("Debug Visable")]

    [SerializeField] private int sceneIndex;
    [SerializeField, ShowInInspector] TextAsset[] storyArray;
    private void Awake()
    {
        inputControls = new InputControls();
        RegisterInputs();
        visualManager.dialogBox.text = "";
        visualManager.ChangeCharacter("");
        ChangeScene(1);
        DisplayNextLine();
        audioManager.sneakyFox.Play();
    }

    void RegisterInputs()
    {
        inputControls.PlayerInputs.space.performed += Space => Space.ReadValueAsButton();
        inputControls.PlayerInputs.leftClick.performed += LeftButton => LeftButton.ReadValueAsButton();
        inputControls.PlayerInputs.rightClick.performed += RightButton => RightButton.ReadValueAsButton();
    }

    public void NextLine(InputAction.CallbackContext context)
    {
        _space = context.performed;
        if (_space)
        {
            DisplayNextLine();
            //Debug.Log("Next line");
        }
    }
    void LoadStory()
    {
        _story = new Story(_inkJsonAsset.text);
        ChangeBackground(0);
        _story.BindExternalFunction("MAINCHAR", (string charName) => visualManager.ChangeCharacter(charName));
        _story.BindExternalFunction("MAINIMAGE", (bool active) => visualManager.SetMainCharacterImage(active));
        _story.BindExternalFunction("MAINNAME", (bool active) => visualManager.SetMainCharacterName(active));
        _story.BindExternalFunction("SECONDCHAR", (string charName) => visualManager.ChangeCharacter(charName));
        _story.BindExternalFunction("SECONDIMAGE", (bool active) => visualManager.SetSecondCharacterImage(active));
        _story.BindExternalFunction("SECONDNAME", (bool active) => visualManager.SetSecondCharacterName(active));
        _story.BindExternalFunction("NEXTSCENE", (int sceneIndex) => ChangeScene(sceneIndex));
        _story.BindExternalFunction("BACKGROUND", (int backgroundIndex) => ChangeBackground(backgroundIndex));
        _story.BindExternalFunction("SHOWUI", (int UI_Index) => ShowUI(UI_Index));
        _story.BindExternalFunction("HIDEUI", (int UI_Index) => HideUI(UI_Index));
        _story.BindExternalFunction("REMOVECHARACTERS", (bool active) => RemoveCharacters(active));
    }

    public void DisplayNextLine()
    {
        if (_story.canContinue) //checking that there is more content to display
        {
            string text = _story.Continue();//Gets next line
            text = text?.Trim();//Removes white space
            visualManager.dialogBox.text = text;//Displays text}
        }
        else
        {
            ChangeScene(sceneIndex);
            if ((sceneIndex - 1) < storyArray.Length)
            {
                string text = _story.Continue();//Gets next line
                text = text?.Trim();//Removes white space
                visualManager.dialogBox.text = text;//Displays text
            }
            else
            {
                visualManager.ChangeCharacter("");
                visualManager.dialogBox.text = "Script finished";//Replace later with appropriate ending or transition
            }
        }
    }

    public void ChangeScene(int sceneIndex)
    {
        this.sceneIndex = sceneIndex;
        visualManager.ChangeCharacter("");
        visualManager.dialogBox.text = "";
        visualManager.SetMainCharacterImage(false);
        visualManager.SetMainCharacterName(false);
        visualManager.SetSecondCharacterImage(false);
        visualManager.SetSecondCharacterName(false);
        if ((sceneIndex - 1) < storyArray.Length)
        {
            visualManager.ChangeBackground(sceneIndex);
            _inkJsonAsset = storyArray[sceneIndex - 1];
            LoadStory();
        }
        if (sceneIndex == 6 || sceneIndex == 8)
        {
            knittingGrid.SetStitchSlots(sceneIndex);
            LoadStory();
        }
        if (sceneIndex == 5)
        {
            audioManager.sneakyFox.Pause();
            audioManager.spy.Play();
        }
        if (sceneIndex == 8)
        {
            audioManager.spy.Pause();
            audioManager.trainStation.Play();
        }
        if (sceneIndex == 9)
        {
            audioManager.trainStation.Pause();
            audioManager.spy.Play();
        }
        if (sceneIndex == 10)
        {
            audioManager.spy.Pause();
            audioManager.sneakyFox.Play();
        }
    }

    public void ChangeBackground(int backgroundIndex)
    {
        visualManager.backgroundImage.sprite = visualManager.background.backgroundArt[backgroundIndex];
    }

    public void ShowUI(int UI_Index)
    {
        if (UI_Index == 0)
        {
            UIMenus[UI_Index].SetActive(true);
        }
        else
        {
            UIMenus[UI_Index].GetComponent<Canvas>().enabled = true;
        }
        if (UIMenus[UI_Index].GetComponentsInChildren<Button>() != null)
        {
            Button[] results = UIMenus[UI_Index].GetComponentsInChildren<Button>();
            foreach (Button button in results)
            {
                button.enabled = true;
            }
        }
        visualManager.SetMainCharacterImage(false);
        visualManager.SetMainCharacterName(false);
        visualManager.SetSecondCharacterImage(false);
        visualManager.SetSecondCharacterName(false);
    }
    public void HideUI(int UI_Index)
    {
        UIMenus[UI_Index].GetComponent<Canvas>().enabled = false;
        visualManager.SetMainCharacterImage(true);
        visualManager.SetMainCharacterName(true);
    }

    public void RemoveCharacters(bool active)
    {
        visualManager.SetMainCharacterImage(false);
        visualManager.SetMainCharacterName(false);
        visualManager.SetSecondCharacterImage(false);
        visualManager.SetSecondCharacterName(false);
    }

}
