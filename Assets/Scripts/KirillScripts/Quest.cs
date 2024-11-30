using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Quest
{
    private string description;

    public Quest(string description) {  this.description = description; }

    public string GetDescription()
    {
        return description; 
    }
}
