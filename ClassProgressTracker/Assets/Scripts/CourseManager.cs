using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EvtSystem;

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
        // create a list of the keys
        List<string> courseDatabaseTitles = new List<string>(courseDatabase.Keys);
        // Check if course already exists
        if (courseDatabaseTitles.Contains(evtData.title)){
            // FIXME: display message on create error window
            Debug.Log("Course already exists");
            return;
        }else{
            // create new course scriptable object
            CourseData newCourse = ScriptableObject.CreateInstance<CourseData>();
            newCourse.title = evtData.title;
            newCourse.description = evtData.description;

            // FIXME: display message on create notification window
            Debug.Log("Course " + evtData.title + " has been added.");
        }

        return;
    }

    public void RemoveCourse(RemoveCourseTrigger evtData)
    {
        // FIXME: check if course exists, then delete scriptable object and all assignments associated with it
        return;
    }
}
