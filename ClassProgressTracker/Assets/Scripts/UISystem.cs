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

    // Start is called before the first frame update
    void Start()
    {
        EvtSystem.EventDispatcher.AddListener<RefreshCourseListTrigger>(RefreshCourseList);
    }

    // FIXME: Updates button list for exisitng courses on-screen
    public void RefreshCourseList(RefreshCourseListTrigger evtData)
    {
        return;
    }

    // FIXME: creates action button and adds functionality to it
    public void CreateActionButton()
    {
        return;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
