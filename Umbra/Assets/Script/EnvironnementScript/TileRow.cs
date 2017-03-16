using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileRow : MonoBehaviour {
	public GameObject Tile;
	SpriteRenderer sprite;

	// Use this for initialization
	void Start () {
		
		sprite = GetComponent<SpriteRenderer>();
		Vector2 spriteSize = new Vector2(sprite.bounds.size.x / transform.localScale.x, sprite.bounds.size.y / transform.localScale.y);

		GameObject child;
		for (int i = 1, l = (int)Mathf.Round(sprite.bounds.size.x); i < l; i++) {
			child = Instantiate(Tile) as GameObject;
			child.transform.position = transform.position - (new Vector3(spriteSize.x, 0, 0) * i);
			child.transform.parent = transform;
		}

		Tile.transform.parent = transform;

		// Disable the currently existing sprite component since its now a repeated image
		sprite.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
