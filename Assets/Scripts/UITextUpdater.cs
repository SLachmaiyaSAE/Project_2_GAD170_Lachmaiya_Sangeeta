using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UITextUpdater : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI messageLabel;


    public void UpdateText(string message)
    {
        //messageLabel.text = messageLabel.text += "lalalalalala" + message;
        // populates a message and adds to line of text
        messageLabel.text = "<b>Applicant Response</b> \n" + message;
    }

}
