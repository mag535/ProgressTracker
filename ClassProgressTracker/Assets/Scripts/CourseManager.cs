using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EvtSystem;

public class CourseManager : Singleton<CourseManager>
{
    public Dictionary<string, CourseData> courseDatabase = new Dictionary<string, CourseData>();


    public void Start()
    {
        LoadDatabase();

        EvtSystem.EventDispatcher.AddListener<AddCourseTrigger>(AddCourse);
        EvtSystem.EventDispatcher.AddListener<RemoveCourseTrigger>(RemoveCourse);
    }


    public void LoadDatabase()
    {
        Debug.Log("FIXME: LoadDatabase()");
    }

    // Keep track of all courses by adding new one to internal dictionary
    public void AddCourse(AddCourseTrigger evtData)
    {
        // create a list of the keys
        List<string> courseDatabaseTitles = new List<string>(courseDatabase.Keys);
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

            // add new course to internal dictionary
            courseDatabase.Add(c.title, c);
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
