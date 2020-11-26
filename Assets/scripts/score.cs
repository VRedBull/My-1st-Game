using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour {

    public Transform player;
    public Text scorecard;
	// Update is called once per frame
	void Update () {
        scorecard.text = player.position.z.ToString("0");
		
	}
}
