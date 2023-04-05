using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseButton : MonoBehaviour
{
    public TMPro.TextMeshProUGUI courseTitle;
    public UnityEngine.UI.Slider progressBar;
    public TMPro.TextMeshProUGUI percentageText;

    private CourseData thisCourse;

    // Start is called before the first frame update
    void Start()
    {
        thisCourse = CourseManager.Instance.GetCourse(courseTitle.text);

        // setup progress display
        percentageText.text = (thisCourse.grade * 100.0f).ToString() + "%"; 
        progressBar.value = thisCourse.grade;
        // FIXME: calculate color of slider based on value...

        // Listeners
        // FIXME: how to update percentage when grade is recalculated with new data?
    }
}
