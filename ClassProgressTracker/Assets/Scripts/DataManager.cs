using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : Singleton<DataManager>
{
    private string path = "Assets/_CourseData";
    // Start is called before the first frame update
    void Start()
    {
        // FIXME: add listeners for saving and loading course and assignment data
        EvtSystem.EventDispatcher.AddListener<SaveCourse>(SaveCourseData);
    }


    #region CourseDataFunctions

    // FIXME: Takes new info for course and saves to JSON file.
    public void SaveCourseData(SaveCourse evtData)
    {
        // convert CourseData to JSON string
        string json = JsonUtility.ToJson(evtData.newCourse);
        // FIXME: write contents of JSON to text file
        return;
    }

    // FIXME: Finds JSON file of given name and creates new instance of CourseData to add to CourseManager
    public void LoadCourseData()
    {
        return;
    }

    // FIXME: Takes changed info of course and overwrites respective JSON file
    public void updateCourseData()
    {
        return;
    }

    #endregion

    #region Assignment Functions

    // FIXME: takes new info for assignment and saves to JSON file
    public void SaveAssignmentData()
    {
        return;
    }

    // FIXME: Finds JSON file of given name and creates new instance of Assignment to add to Course
    public void LoadAssignment()
    {
        return;
    }

    // FIXME: Takes changed info of assignment and overwrites respective JSON file
    public void updateAssignment()
    {
        return;
    }

    #endregion
}
