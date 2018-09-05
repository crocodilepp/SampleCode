using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButton : MonoBehaviour {

    public System.Action OnButtonClicked;

    #region delegate/event
    public delegate void OnButtonClickDelegate ();
    public event OnButtonClickDelegate OnButtonClickEvent;
    #endregion

    public void OnClicked ()
    {
        if (OnButtonClicked != null)
        {
            OnButtonClicked ();
        }

        #region delegate/event
        if (OnButtonClickEvent != null)
        {
            OnButtonClickEvent ();
        }
        #endregion
    }
}
