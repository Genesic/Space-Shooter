using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject hazard;
	public Vector3 spawnValue;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	public GUIText scoreText;
	private int score;

	void Start (){
		score = 0;
		updateScore ();
		StartCoroutine(SpawnWaves ());
	}

	IEnumerator SpawnWaves (){
		yield return new WaitForSeconds(startWait);
		while (true) {
			for (int i=0; i<= hazardCount; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValue.x, spawnValue.x), spawnValue.y, spawnValue.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds(waveWait);
		}
	}

	public void AddScore (int add){
		score += add;
		updateScore ();
	}

	void updateScore () {
		scoreText.text = "Score: " + score;
	}
}
