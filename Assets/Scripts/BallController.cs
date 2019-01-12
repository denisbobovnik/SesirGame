using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

    public GameObject bowlingBall;

    private float maxWidth;

	// Use this for initialization
	void Start () {
        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0);
        Vector3 targetWidth = Camera.main.ScreenToWorldPoint(upperCorner);
        float ballWIdth = bowlingBall.GetComponent<Renderer>()
            .bounds.extents.x / 2;
        maxWidth = targetWidth.x - ballWIdth;

        StartCoroutine(Spawn());
	}

    IEnumerator Spawn() {
        yield return new WaitForSeconds(2.5f);

        while(true) {
            Vector3 spawnPosition = new Vector3(Random.Range(-maxWidth, maxWidth),
                transform.position.y, 0);
            Quaternion spawnRotation = Quaternion.identity;

            Instantiate(bowlingBall, spawnPosition, spawnRotation);

            yield return new WaitForSeconds(2.0f);
        }
    }
	
	// Update is called once per frame
	void Update () {

    }
}
