using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class KnittingReader : MonoBehaviour
{
    [SerializeField] private KnittingGrid knittingGrid;
    [SerializeField, ShowInInspector] public Dictionary<int, string[]> knittingReaderSlots = new Dictionary<int, string[]>();
    [SerializeField, ShowInInspector] public string stitchedCode;
    [SerializeField, ShowInInspector] public string translatedCode;


    public void ReadStitches(Dictionary<int, string[]> knittingStitches)
    {
        knittingReaderSlots = knittingStitches;
        for (int i = 0; i < knittingReaderSlots.Count; i += 2)
        {
            if (i < 12)
            {
                TranslateCode(knittingStitches[i]);
                TranslateCode(knittingStitches[i + 1]);
            }
            else
            {
                TranslateCode(knittingStitches[i]);
            }
        }
        TranslateIndexes();
    }
    public void TranslateCode(string[] stitchLine)
    {
        int posWhite = System.Array.IndexOf(stitchLine, "WhiteStitch");
        int posRed = System.Array.IndexOf(stitchLine, "RedStitch");
        if (posWhite > -1 && posRed > -1)
        {
            stitchedCode += posWhite.ToString();
        }
        else
        {
            stitchedCode += '.';
        }
    }
    public void TranslateIndexes()
    {
        char[] codeArray = stitchedCode.ToCharArray();
        for (int i = 0; i < stitchedCode.Length;)
        {
            if (codeArray[i] == '.')
            {
                translatedCode += codeArray[i];
                translatedCode += (char)codeArray[i + 1];
                translatedCode += (char)codeArray[i + 2];
                translatedCode += (char)codeArray[i + 3];
                translatedCode += (char)codeArray[i + 4];
                break;
            }
            else
            {
                string temp = codeArray[i].ToString() + codeArray[i + 1].ToString();
                switch (temp)
                {
                    case "  ":
                        translatedCode += ' ';
                        break;
                    case "01":
                        translatedCode += 'a';
                        break;
                    case "02":
                        translatedCode += 'b';
                        break;
                    case "03":
                        translatedCode += 'c';
                        break;
                    case "04":
                        translatedCode += 'd';
                        break;
                    case "05":
                        translatedCode += 'e';
                        break;
                    case "06":
                        translatedCode += 'f';
                        break;
                    case "07":
                        translatedCode += 'g';
                        break;
                    case "08":
                        translatedCode += 'h';
                        break;
                    case "09":
                        translatedCode += 'i';
                        break;
                    case "10":
                        translatedCode += 'j';
                        break;
                    case "11":
                        translatedCode += 'k';
                        break;
                    case "12":
                        translatedCode += 'l';
                        break;
                    case "13":
                        translatedCode += 'm';
                        break;
                    case "14":
                        translatedCode += 'n';
                        break;
                    case "15":
                        translatedCode += 'o';
                        break;
                    case "16":
                        translatedCode += 'p';
                        break;
                    case "17":
                        translatedCode += 'q';
                        break;
                    case "18":
                        translatedCode += 'r';
                        break;
                    case "19":
                        translatedCode += 's';
                        break;
                    case "20":
                        translatedCode += 't';
                        break;
                    case "21":
                        translatedCode += 'u';
                        break;
                    case "22":
                        translatedCode += 'v';
                        break;
                    case "23":
                        translatedCode += 'w';
                        break;
                    case "24":
                        translatedCode += 'x';
                        break;
                    case "25":
                        translatedCode += 'y';
                        break;
                    case "26":
                        translatedCode += 'z';
                        break;
                }
                i += 2;
            }
        }
        knittingGrid.VerifyAnswer(translatedCode);
    }
}
