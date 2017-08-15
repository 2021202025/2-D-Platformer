using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class PlayAd : MonoBehaviour {

	public void ShowAd()
	{
		if (Advertisement.IsReady ()) {
			Advertisement.Show ("video", new ShowOptions(){resultCallback = HandleAdResult});
		}
	}

	private void HandleAdResult(ShowResult result){
		switch (result) {
		case ShowResult.Finished:
			Debug.Log ("Nice, Thanks for supporting");
			break;
		case ShowResult.Skipped:
			Debug.Log ("Well thanks for 5 seconds I guess");
			break;
		case ShowResult.Failed:
			Debug.Log ("Internet Much??");
			break;
		}
	}

}
