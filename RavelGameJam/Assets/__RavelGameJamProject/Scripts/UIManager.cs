using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [Header("Main Menu")]
    [SerializeField] int sceneToLoad;
    [SerializeField] private Canvas credits;
    bool creditsActive = false;
    [Header("In Game")]
    [SerializeField] private ScriptReader scriptReader;
    [SerializeField] private VisualManager visualManager;
    [SerializeField] private GameObject tryAgainRead;
    [SerializeField] private GameObject readComplete;
    [SerializeField] private GameObject tryAgainStitch;
    [SerializeField] private GameObject stitchComplete;
    [SerializeField] private GameObject tryAgainMission;

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
    public void SetCredits()
    {
        creditsActive = !creditsActive;
        credits.GetComponent<Canvas>().enabled = creditsActive;
    }
    public void ChangeGameScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
    public void StartScene5()
    {
        scriptReader.ChangeScene(5);
    }
    public void StartScene6()
    {
        scriptReader.ChangeScene(6);
    }
    public void StartScene7()
    {
        scriptReader.ChangeScene(7);
    }

    public void WrongAnswer(int uiIndex)
    {
        visualManager.dialogBox.text = "Not quite, try again";
        scriptReader.dialogueCanvas.enabled = true;
        visualManager.SetMainCharacterImage(true);
        visualManager.SetMainCharacterName(true);
        visualManager.SetSecondCharacterImage(true);
        visualManager.SetSecondCharacterName(true);
        if (uiIndex == 0)
        {
            scriptReader.UIMenus[uiIndex].SetActive(false);
            tryAgainRead.SetActive(true);
        }
        if (uiIndex == 3)
        {
            scriptReader.UIMenus[uiIndex].GetComponent<Canvas>().enabled = false;
            tryAgainStitch.SetActive(true);
        }
        if (uiIndex == 4)
        {
            scriptReader.UIMenus[uiIndex].GetComponent<Canvas>().enabled = false;
            tryAgainMission.SetActive(true);
        }
    }

    public void RightAnswer(int uiIndex)
    {
        scriptReader.ShowUI(uiIndex);
        if (uiIndex == 1)
        {
            visualManager.dialogBox.text = "Correct. Are you ready to move on?";
            readComplete.GetComponent<Canvas>().enabled = true;
            visualManager.mainCharacterImage.enabled = true;
            visualManager.secondaryCharacterImage.enabled = true;
            visualManager.secondaryNameTag.enabled = true;
        }
        if (uiIndex == 3)
        {
            visualManager.dialogBox.text = "Correct. Are you ready to move on?";
            stitchComplete.GetComponent<Canvas>().enabled = true;
            visualManager.mainCharacterImage.enabled = true;
            visualManager.secondaryCharacterImage.enabled = true;
            visualManager.secondaryNameTag.enabled = true;
        }
        if (uiIndex == 5)
        {
            scriptReader.ChangeScene(9);
            visualManager.mainCharacterImage.enabled = true;
        }

    }
}
