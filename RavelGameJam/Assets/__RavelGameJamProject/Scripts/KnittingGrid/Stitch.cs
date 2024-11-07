using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stitch : MonoBehaviour
{
    public StitchScriptableObject stitchSO;//Public variable of a Scriptable object
    public StitchTypes stitchType;
    public Sprite getSprite()//retrieve sprite function
    {
        return stitchSO.stitchUI;
    }
    public StitchScriptableObject getStitchSO()//retrieves the Scriptable object
    {
        return stitchSO;
    }
    public string getStitchName()//retrieves name of the Scriptable object
    {
        return stitchSO.stitchName;
    }
}
