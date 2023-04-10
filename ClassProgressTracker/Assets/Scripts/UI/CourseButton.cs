using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseButton : MonoBehaviour
{
    public TMPro.TextMeshProUGUI courseTitle;
    public UnityEngine.UI.Slider progressBar;
    public UnityEngine.UI.Image progressFill;
    public TMPro.TextMeshProUGUI percentageText;

    // Start is called before the first frame update
    void Start()
    {
        // setup progress display
        percentageText.text = (progressBar.value * 100.0f).ToString() + "%";
        // calculate color of slider based on grade
        progressFill.color = new Color(1.0f - progressBar.value, progressBar.value, 0, 1);

        // Listeners
        // FIXME: how to update percentage when grade is recalculated with new data?
    }
}
