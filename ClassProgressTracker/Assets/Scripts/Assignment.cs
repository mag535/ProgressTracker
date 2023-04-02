using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum AssignmentType{
    HOMEWORK,
    PROJECT,
    QUIZ,
    MIDTERM,
    FINAL
}


[CreateAssetMenu(menuName = "Progress System/Assignment")]
public class Assignment : ScriptableObject
{
    public AssignmentType whatKind;
    
    /* 
    Ideally named like this: TYPE_COURSE_DELIMINATOR
    Example: HW_ECE303_1
    */
    public string title;

    public bool pastDue;
    public bool completed;

    public float grade;
}
