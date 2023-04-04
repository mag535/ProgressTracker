using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SerializeField]
public class CourseData
{
    public string title;
    public string description;

    // NOTE: this will save as a list of assignment names in the JSON file
    public List<string> assignmentList;
}
