using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ExampleTrigger : EvtSystem.Event
{
    public string data1;
    public float data2;
}

public class AddCourseTrigger : EvtSystem.Event
{
    public string title;
    public string description;
}

public class RemoveCourseTrigger : EvtSystem.Event
{
    public string title;
    public string description;
}