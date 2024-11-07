using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class KnittingGrid : MonoBehaviour
{
    [SerializeField] private VisualManager visualManager;
    [SerializeField] private ScriptReader scriptReader;
    [SerializeField] private UIManager uIManager;
    [SerializeField] private KnittingReader knittingReader;
    [SerializeField] List<StitchSlot> stitchSlots = new List<StitchSlot>();
    [SerializeField] List<StitchSlot> tutStitchSlots = new List<StitchSlot>();
    [SerializeField] List<StitchSlot> missionStitchSlots = new List<StitchSlot>();
    [SerializeField] private GameObject slotRow;
    [SerializeField] GameObject redStitch;
    [SerializeField] GameObject whiteStitch;
    [SerializeField] private Answers answers;
    [SerializeField] private string answerTutorial;
    [SerializeField] private string answerMission;
    Dictionary<int, string[]> currentKnittingSock;

    public void SetStitchSlots(int sceneIndex)
    {
        if (sceneIndex == 6)
        {
            knittingReader.stitchedCode = "";
            knittingReader.translatedCode = "";
            SetAnswersTutorial();
            stitchSlots = tutStitchSlots;
        }
        if (sceneIndex == 8)
        {
            knittingReader.stitchedCode = "";
            knittingReader.translatedCode = "";
            SetAnswersMission();
            stitchSlots = missionStitchSlots;
        }
    }
    public void CompleteButton()
    {
        currentKnittingSock = new Dictionary<int, string[]>();//create a new list of knitted stitches
        int i = 0;
        int dicKey = 0;
        int stitchCount = 0;
        string[] stitchRow = new string[10];
        do
        {
            if (stitchSlots[i].assignedStitch != null)
            {
                stitchRow[stitchCount] = stitchSlots[i].assignedStitch.stitchType.ToString();
                stitchCount++;
                if (stitchCount % 10 == 0 && i != 0)
                {
                    currentKnittingSock.Add(dicKey, stitchRow);
                    stitchCount = 0;
                    stitchRow = new string[10];
                    dicKey++;
                }
            }//if the slot has an item in it, add it to the craft items list
            i++;
        }
        while (dicKey <= 12);
        knittingReader.ReadStitches(currentKnittingSock);
        //-- Write the final knitted sock code here to verify
    }
    public void SetAnswersTutorial()
    {
        answers = Answers.Tutorial;
    }
    public void SetAnswersMission()
    {
        answers = Answers.Mission;
    }

    public void VerifyAnswer(string playerAnswer)
    {
        if (answers == Answers.Tutorial)
        {
            Debug.Log("Tutorial Answer");
            if (playerAnswer.Equals(answerTutorial))
            {
                Debug.Log("Answers match");
                visualManager.SetMainCharacterImage(true);
                visualManager.SetMainCharacterName(true);
                visualManager.SetSecondCharacterImage(true);
                visualManager.SetSecondCharacterName(true);
                scriptReader.dialogueCanvas.enabled = true;
                uIManager.RightAnswer(3);
            }
            else
            {
                visualManager.SetMainCharacterImage(true);
                visualManager.SetMainCharacterName(true);
                visualManager.SetSecondCharacterImage(true);
                visualManager.SetSecondCharacterName(true);
                scriptReader.dialogueCanvas.enabled = true;
                uIManager.WrongAnswer(3);
                Debug.Log("Answers do not match");
            }
        }
        if (answers == Answers.Mission)
        {
            Debug.Log("Mission Answer");
            if (playerAnswer.Equals(answerMission))
            {
                Debug.Log("Answers match");
                visualManager.SetMainCharacterImage(true);
                visualManager.SetMainCharacterName(true);
                visualManager.SetSecondCharacterImage(true);
                visualManager.SetSecondCharacterName(true);
                scriptReader.dialogueCanvas.enabled = true;
                scriptReader.ChangeScene(9);
            }
            else
            {
                visualManager.SetMainCharacterImage(true);
                visualManager.SetMainCharacterName(true);
                visualManager.SetSecondCharacterImage(true);
                visualManager.SetSecondCharacterName(true);
                scriptReader.dialogueCanvas.enabled = true;
                uIManager.WrongAnswer(4);
                Debug.Log("Answers do not match");
            }
        }
    }
}


public enum Answers
{
    Tutorial,
    Mission,
}
