using UnityEngine;
using System.Collections;

public class Boss {        
	private int mp = 53;

	// Magic関数
	public  void Magic(int damage) { 
		// 残りmpを減らす
		this.mp -= damage;
		if (mp >= damage) {
			Debug.Log ("魔法改革をした。残りMPは" + this.mp);		
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 要素数5の配列を初期化する
		int[] points = new int[5];

		// 配列の各要素に値を代入する
		points [0] = 30;
		points [1] = 20;
		points [2] = 50;
		points [3] = 10;
		points [4] = 80;

		// 配列の各要素の値を逆順に表示する
		for (int i = 0; i < 5; i=4-i) {
			Debug.Log (points [i]);
		}

		// Bossクラスの変数を宣言してインスタンスを代入
		Boss boss = new Boss ();

		// Magic関数を呼び出す
		boss.Magic(5);		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
