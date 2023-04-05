using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : Singleton<DataManager>
{
    private string saveFileExtension;
    private string courseDataDirectory;
    private string assignmentDataDirectory;

    // Start is called before the first frame update
    void Start()
    {
        saveFileExtension = ".json";
        courseDataDirectory = Application.persistentDataPath + "/Courses/";
        assignmentDataDirectory = Application.persistentDataPath + "/Assignments/";

        // create directory for CourseData saves
        if (!Directory.Exists(courseDataDirectory)){
            Directory.CreateDirectory(courseDataDirectory);
        }
        if (!Directory.Exists(assignmentDataDirectory)){
            Directory.CreateDirectory(assignmentDataDirectory);
        }

        // FIXME: add listeners for saving and loading course and assignment data
        EvtSystem.EventDispatcher.AddListener<AddCourseTrigger>(SaveNewCourse);
    }


    #region CourseData Functions

    // FIXME: Takes new info for course and saves to JSON file.
    public void SaveNewCourse(AddCourseTrigger evtData)
    {
        Debug.Log("saving file...");
        // convert CourseData object to JSON string
        string json = JsonUtility.ToJson(new CourseData {
            title = evtData.title,
            description = evtData.description
        });

        // Write contents of JSON string to plaintext file
        string path = courseDataDirectory + evtData.title + saveFileExtension;
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(json);
        writer.Close();
        return;
    }

    // FIXME: Finds JSON file of given name and deletes it
    public void DeleteCourseData()
    {
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

    // FIXME: finds JSON file of given name and deletes it
    public void DeleteAssignmentData()
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
