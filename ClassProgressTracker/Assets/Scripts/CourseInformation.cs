using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseInformation : MonoBehaviour
{
    public TMPro.TextMeshProUGUI courseTitleInput;
    public TMPro.TextMeshProUGUI courseDescriptionInput;

    // Start is called before the first frame update
    void Start()
    {
        EvtSystem.EventDispatcher.AddListener<ConfirmInformation>(SendCourseInfo);
    }

    public void SendCourseInfo(ConfirmInformation evtData)
    {
        // Only send confirmation flag if title was specified
        if (courseTitleInput.Equals("")){
            Debug.Log("ERROR -- add a title.");
            return;
        }

        AddCourseTrigger courseInfo = new AddCourseTrigger();
        courseInfo.title = courseTitleInput.text;
        courseInfo.description = courseDescriptionInput.text;
        
        EvtSystem.EventDispatcher.Raise<AddCourseTrigger>(courseInfo);

        // go back to home screen
        SceneChanger.Instance.ChangeScene("HomeScreen");
    }
}
