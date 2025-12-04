using UnityEngine;
using System.Collections.Generic;

// public class LoadData : MonoBehaviour
// {
[System.Serializable]
public class ChecklistRoot
{
    public List<ChecklistData> checklist;
}

[System.Serializable]
public class ChecklistData
{
    public string id;
    public string label;
    public bool required;
    public bool alreadychecked;
    public bool currentstatus;
}

