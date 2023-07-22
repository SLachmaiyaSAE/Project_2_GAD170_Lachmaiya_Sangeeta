using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RejectTextUpdater : MonoBehaviour
{
    // TextMexhProUGUI used as that what it uses in the system - this populates as simple text
    [SerializeField] private TextMeshProUGUI messageLabel;
    // this variable updates the text that underneather the mssage label - this is connected to the button
    [SerializeField] private UITextUpdater rejectButton;
    public float displayDuration = 2f;

    private void Start ()
    {
        StartCoroutine(RemoveTextAfterDelay());
    }


    public void UpdateRejectText(string message)
    {
        messageLabel.text = "<b>Application denied. Parasite detected</b> \n" + message;
    }


    private IEnumerator RemoveTextAfterDelay()
    {
        yield return new WaitForSeconds(displayDuration);
    }
  
    
    
    
    
    
    //public void rejectButtonText(string message)
    //{
    //    messageLabel.text = messageLabel.text += "lalalalalala" + message;
    //    //populates a message and adds to line of text
    //}
}















//////////////workings - that didn't work
//public class ClickToShowText : MonoBehaviour
//{
//    public Text displayText;
//    public string textToShow = "Be Gone Bug!";

//    private bool text = false;

//    private void Start()
//    {
//        displayText.text = ""; 
//    }

//    private void Update()
//    {
//        if (Input.GetMouseButtonDown(0) && IsMouseOverObject())
//        {
//            text = !text;

//            if(text)
//            {
//                displayText.text = textToShow;
//            }
//            else
//            {
//                displayText.text = " ";
//            }
//        }
//    }

//    private bool IsMouseOverObject()
//    {
//        return false;
//    }
//}

///
//{
//    public Image original;
//public Sprite newSprite;
//// Start is called before the first frame update
//void Start()
//{
//}
//// Update is called once per frame
//void Update()
//{
//}
//public void NewImage()
//{
//    original.sprite = newSprite;
//}
//youtubed this but did not het it to work
//    public void whenButtonClicked()
//{
//    if (applicantOne.activeInHierarchy == true)
//        applicantOne.SetActive(false);
//    else
//        applicantOne.SetActive(true);
//}
//}
