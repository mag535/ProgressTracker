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


[SerializeField]
public class Assignment
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
