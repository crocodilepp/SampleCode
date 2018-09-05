using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController2 : MonoBehaviour {

    [SerializeField] private TestButton button;

	void OnEnable ()
    {
        button.OnButtonClicked += UpdateUi;
	}

    void OnDisable ()
    {
        button.OnButtonClicked -= UpdateUi;
    }
	
    private void UpdateUi ()
    {
        Debug.Log ("Button clicked, update UI " + this.GetType ());
    }
}
