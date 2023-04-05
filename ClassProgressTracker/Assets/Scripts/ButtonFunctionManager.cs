using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EvtSystem;


public class ButtonFunctionManager : Singleton<ButtonFunctionManager>
{
    // Signal for course info to be used
    public void ConfirmCourseInfo()
    {
        ConfirmInformation confirmed = new ConfirmInformation();

        EvtSystem.EventDispatcher.Raise<ConfirmInformation>(confirmed);
        return;
    }
}
