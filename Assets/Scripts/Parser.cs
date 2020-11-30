using System;
using System.Text;
using UnityEngine;

[CreateAssetMenu]
public class Parser : ScriptableObject
{
    [NonSerialized] private Transform source = null;
    [NonSerialized] private string[] splitCode = null;
    [NonSerialized] private Command toExecute = null;

    
}