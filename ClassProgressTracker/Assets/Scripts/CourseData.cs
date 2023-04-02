using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Progress System/Course")]
public class CourseData : ScriptableObject
{
    public string title;
    public string description;

    public List<Assignment> assignmentList;
}
