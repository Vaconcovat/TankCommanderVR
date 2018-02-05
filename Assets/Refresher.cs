using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZenFulcrum.EmbeddedBrowser;

public class Refresher : MonoBehaviour {

	Browser browser;

	// Use this for initialization
	void Start () {
		browser = GetComponent<Browser>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		browser.Reload(true);
	}
}
