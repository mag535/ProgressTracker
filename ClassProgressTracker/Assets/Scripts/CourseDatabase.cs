using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Progress System/Course Database")]
public class CourseDatabase : ScriptableObject
{
    public List<CourseData> list;
}
