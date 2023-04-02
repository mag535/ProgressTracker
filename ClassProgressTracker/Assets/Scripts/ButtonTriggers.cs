using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EvtSystem;


public class ButtonTriggers : MonoBehaviour
{
    private Button trigger;

    // Start is called before the first frame update
    void Start()
    {
        trigger = gameObject.GetComponent<Button>();

        trigger.onClick.AddListener(AddCourse);
    }

    // "Add Course" button
    public void AddCourse()
    {
        Debug.Log("button pressed");
        
        AddCourseTrigger courseInfo = new AddCourseTrigger();
        courseInfo.title = "Test102";
        courseInfo.description = "testing add course function";

        EvtSystem.EventDispatcher.Raise<AddCourseTrigger>(courseInfo);
        return;
    }
}
