using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Branch", menuName="CustomObject/Branch")]
public class DialogueBranch : ScripatbleObject
{
    public string dialogueId ="";
    public List<striing>DialogueLines;
    public List<ResponseBranch> ResponseOption;
}

[System.Serializabble]
pulic class ResponseBranch
{
    public string text;
    publlic DialogueBranch nextbranch;
}
