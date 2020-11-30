using TMPro;
using UnityEngine;

public class CodeEditor : MonoBehaviour
{
    // receive new code
    // send code to parser
    // add to display if parsed

    [SerializeField] private CodeEntity currentlySelectedEntity = null;
    [SerializeField] private TMP_Text codeDisplayText = null;
    [SerializeField] private TMP_InputField codeInputField = null;
    [SerializeField] private Parser parser = null;

    public void Awake()
    {
        codeInputField.onSubmit.AddListener(OnCodeSubmitted);
    }

    private void OnCodeSubmitted(string textInput)
    {
        //if (parser.ParseCode(currentlySelectedEntity.transform, textInput) == 0) return;

        codeInputField.ActivateInputField();
        codeInputField.text = string.Empty;
        codeInputField.Select();

        codeDisplayText.text += $"\n> {textInput}";
        currentlySelectedEntity.rawCode.Add(textInput);
    }
}