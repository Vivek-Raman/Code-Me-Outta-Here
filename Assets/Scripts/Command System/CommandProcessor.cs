using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandProcessor : MonoBehaviour
{
    public List<Command> commands = null;
    [SerializeField] private CommonData data = null;

    private List<CodeEntity> entities = null;
    private WaitForSeconds stall;

    private void Awake()
    {
        stall = new WaitForSeconds(data.timeQuantum);
        entities = new List<CodeEntity>(FindObjectsOfType<CodeEntity>());
    }

    public void UI_OnSimulationBegin()
    {
        StartCoroutine(ExecuteCommand());
    }

    private IEnumerator ExecuteCommand()
    {
        foreach (Command command in commands)
        {
            command.Execute();
            yield return stall;
        }
    }
}