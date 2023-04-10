using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EvtSystem;

public class CourseManager : Singleton<CourseManager>
{
    public Dictionary<string, CourseData> courseDatabase = new Dictionary<string, CourseData>();

    private List<string> courseTitleDatabase = new List<string>();


    public void Start()
    {
        EvtSystem.EventDispatcher.AddListener<LoadDataTrigger>(LoadDatabase);
        EvtSystem.EventDispatcher.AddListener<AddCourseTrigger>(AddCourse);
        EvtSystem.EventDispatcher.AddListener<RemoveCourseTrigger>(RemoveCourse);
    }


    // FIXME: won't call, can't figure out why
    public void LoadDatabase(LoadDataTrigger evtData)
    {
        Debug.Log("this function was used");
        List<CourseData> loadedDatabase = evtData.data;

        // save to internal dictionary
        foreach (CourseData data in loadedDatabase){
            courseDatabase.Add(data.title, data);
            courseTitleDatabase.Add(data.title);
        }

        // UI implementation to refresh onscreen course list
        EvtSystem.EventDispatcher.Raise<RefreshCourseListTrigger>(new RefreshCourseListTrigger {
            database = courseDatabase
        });
    }

    // Keep track of all courses by adding new one to internal dictionary
    public void AddCourse(AddCourseTrigger evtData)
    {
        // Check if course already exists
        if (courseTitleDatabase.Contains(evtData.title)){
            // ADDME: UI implementation for message window
            Debug.Log("Course already exists");
            return;
        }

        // ADDME: UI implementation for message window
        Debug.Log(evtData.title + " has been added.");

        // create new CourseData
        CourseData c = new CourseData();
        c.title = evtData.title;
        c.description = evtData.description;
        c.grade = 0.0f;
        c.assignmentList = new List<string>();

        // Track course by adding it to internal dictionary & titles list
        courseDatabase.Add(c.title, c);
        courseTitleDatabase.Add(c.title);

        // ADDME: UI implementation to update onscreen course list
        return;
    }

    // FIXME: Keep track of all courses by updating internal dictionary to reflect current courses
    public void RemoveCourse(RemoveCourseTrigger evtData)
    {
        // check if course exists
        if (!courseTitleDatabase.Contains(evtData.title)){
            // ADDME: UI implementation for message window
            Debug.Log("ERROR -- course is not in database.");
            return;
        }

        // remove course from titles and object database
        courseDatabase.Remove(evtData.title);
        courseTitleDatabase.Remove(evtData.title);

        Debug.Log("course removed");
        return;
    }

    // Used by other scripts to find CourseData object in dictionary
    public CourseData GetCourse(string title)
    {
        if (!courseTitleDatabase.Contains(title)){
            return null;
        }
        return courseDatabase[title];
    }
}
