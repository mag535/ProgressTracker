using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseManager : Singleton<CourseManager>
{
    public CourseDatabase database;

    public Dictionary<string, CourseData> courseDatabase = new Dictionary<string, CourseData>();


    public void Start()
    {
        LoadDatabase();

        EvtSystem.EventDispatcher.AddListener<AddCourseTrigger>(AddCourse);
        EvtSystem.EventDispatcher.AddListener<RemoveCourseTrigger>(RemoveCourse);
    }


    public void LoadDatabase()
    {
        foreach(CourseData course in database.list){
            courseDatabase.Add(course.title, course);
        }
    }

    public void AddCourse(AddCourseTrigger evtData)
    {
        // FIXME: create a CourseData scriptable object and add the given info
        return;
    }

    public void RemoveCourse(RemoveCourseTrigger evtData)
    {
        // FIXME: check if course exists, then delete scriptable object and all assignments associated with it
        
        // create a list of the keys
        List<string> courseDatabaseTitles = new List<string>(courseDatabase.Keys);
        // Check if course already exists
        if (courseDatabaseTitles.Contains(evtData.title)){
            Debug.Log("Course already exists");
            return;
        }
        
        return;
    }
}
