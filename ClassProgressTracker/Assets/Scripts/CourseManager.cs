using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EvtSystem;

public class CourseManager : Singleton<CourseManager>
{
    public Dictionary<string, CourseData> courseDatabase = new Dictionary<string, CourseData>();

    private List<string> courseDatabaseTitles = new List<string>();


    public void Start()
    {
        LoadDatabase();

        EvtSystem.EventDispatcher.AddListener<AddCourseTrigger>(AddCourse);
        EvtSystem.EventDispatcher.AddListener<RemoveCourseTrigger>(RemoveCourse);
    }


    public void LoadDatabase()
    {
        List<CourseData> loadedDatabase = DataManager.Instance.LoadCourseData();
        // save to internal dictionary
        foreach (CourseData data in loadedDatabase){
            courseDatabase.Add(data.title, data);
        }

        // Tell UIManager to refresh course list on screen
        EvtSystem.EventDispatcher.Raise<RefreshCourseListTrigger>(new RefreshCourseListTrigger {
            database = courseDatabase
        });
    }

    // Keep track of all courses by adding new one to internal dictionary
    public void AddCourse(AddCourseTrigger evtData)
    {
        // Check if course already exists
        if (courseDatabaseTitles.Contains(evtData.title)){
            // FIXME: display message on create error window
            Debug.Log("Course already exists");
            return;
        }else{
            // FIXME: display message on create notification window
            Debug.Log(evtData.title + " has been added.");
            // create new CourseData
            CourseData c = new CourseData();
            c.title = evtData.title;
            c.description = evtData.description;

            // Track course by adding it to internal dictionary & titles list
            courseDatabase.Add(c.title, c);
            courseDatabaseTitles.Add(c.title);

            // FIXME: update course list display on home screen
        }

        return;
    }

    // FIXME: Keep track of all courses by updating internal dictionary to reflect current courses
    public void RemoveCourse(RemoveCourseTrigger evtData)
    {
        // FIXME: check if course exists, then delete scriptable object and all assignments associated with it
        Debug.Log("FIXME: RemoveCourse");
        return;
    }
}
