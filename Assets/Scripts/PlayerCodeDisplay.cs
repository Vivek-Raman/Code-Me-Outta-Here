using TMPro;
using UnityEngine;

public class PlayerCodeDisplay : MonoBehaviour
{
    // receive new code
    // send code to parser
    // add to display if parsed

    [SerializeField] private TMP_Text codeDisplayText = null;
    [SerializeField] private TMP_InputField codeInputField = null;
    [SerializeField] private Parser parser = null;

    public void Awake()
    {
        codeInputField.onSubmit.AddListener(OnCodeSubmitted);
    }

    private void OnCodeSubmitted(string textInput)
    {
        //EventSystem.current.SetSelectedGameObject(codeInputField.gameObject);
        //if (!parser.ParseCode(textInput)) return;

        codeInputField.ActivateInputField();
        codeInputField.text = string.Empty;
        codeInputField.Select();

        codeDisplayText.text += $"\n> {textInput}";
    }
}