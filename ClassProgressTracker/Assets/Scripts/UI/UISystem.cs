using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISystem : Singleton<UISystem>
{
    public GameObject UIRoot;

    public GameObject courseButtonContainer;
    public GameObject courseButtonPrefab;

    public TMPro.TextMeshProUGUI screenTitle;

    public GameObject actionButtonContainer;
    public GameObject actionButtonPrefab;

    private List<GameObject> activeCourseButtons;
    private List<GameObject> activeActionButtons;

    // Start is called before the first frame update
    void Start()
    {
        activeCourseButtons = new List<GameObject>();
        activeActionButtons = new List<GameObject>();

        EvtSystem.EventDispatcher.AddListener<AddCourseTrigger>(CreateCourseButton);
        EvtSystem.EventDispatcher.AddListener<RefreshCourseListTrigger>(RefreshCourseList);
    }

    // FIXME: creates action button and adds functionality to it
    public void CreateActionButton()
    {
        return;
    }

    // FIXME: deletes action button
    public void DeleteActionButton()
    {
        return;
    }

    // FIXME: creates course button and adds functionality to it
    public void CreateCourseButton(AddCourseTrigger evtData)
    {
        var button = GameObject.Instantiate(courseButtonPrefab, courseButtonContainer.transform);
        button.SetActive(false);
        // set title and initial grade value
        button.GetComponent<CourseButton>().courseTitle.text = evtData.title;
        button.GetComponent<CourseButton>().progressBar.value = 0;
        button.SetActive(true);
        //ADDME: functionality
        return;
    }

     // FIXME: deletes course button and adds functionality to it
    public void DeleteCourseButton()
    {
        return;
    }

    // FIXME: Updates button list for exisitng courses on-screen
    public void RefreshCourseList(RefreshCourseListTrigger evtData)
    {
        Debug.Log("signal received");
        return;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
