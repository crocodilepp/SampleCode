using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController3 : MonoBehaviour {

    [SerializeField] private TestButton button;

	void OnEnable ()
    {
        button.OnButtonClicked = UpdateUi;
	}

    void OnDisable ()
    {
        button.OnButtonClicked = null;
    }
	
    private void UpdateUi ()
    {
        Debug.Log ("Button clicked, update UI " + this.GetType ());
    }
}
