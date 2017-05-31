//using UnityEngine;
//using System.Collections;
//
//public class newPlayer : MonoBehaviour {
//	// 速度
//	public Vector2 SPEED = new Vector2(0.05f, 0.05f);
//	// Use this for initialization
//	void Start () {
//		GetComponent<Rigidbody2D> ().freezeRotation = true;
//	}
//
//	// Update is called once per frame
//	void Update () {
//		// 移動処理
//		Move();
//	}
//
//	// 移動関数
//	void Move(){
//		// 現在位置をPositionに代入
//		Vector2 Position = transform.position;
//		if(Input.GetKey("left")){
//			// 代入したPositionに対して加算減算を行う
//			Position.x -= SPEED.x;
//		} else if(Input.GetKey("right")){ 
//			// 代入したPositionに対して加算減算を行う
//			Position.x += SPEED.x;
//		} else if(Input.GetKey("up")){ // 上キーを押し続けていたら
//			// 代入したPositionに対して加算減算を行う
//			Position.y += SPEED.y;
//		} 
//		// 現在の位置に加算減算を行ったPositionを代入する
//		transform.position = Position;
//	}
//}
using UnityEngine;
using System.Collections;

public class newPlayer : MonoBehaviour {

	// 変数の定義と初期化
	public float flap = 1000f;
	public float scroll = 35f;
	Rigidbody2D rb2d;
	bool jump = false;

	//当たり判定検出
	void Start() {
		rb2d = GetComponent<Rigidbody2D>();
	//playerの回転を制御
		GetComponent<Rigidbody2D> ().freezeRotation = true;
	}

	void Update() {
		// xの正方向にscrollスピードで移動
		rb2d.velocity = new Vector2 (scroll, rb2d.velocity.y);

		// スペースキーが押されたら
		if (Input.GetKeyDown (KeyCode.Space) && !jump) {
			// 落下速度をリセット（いるか分からない？）
			//rb2d.velocity = Vector2.zero;
			// (0,1)方向に瞬間的に力を加えて跳ねさせる
			rb2d.AddForce (Vector2.up * flap);
			jump = true;
		}
	}

	//タグのGroundにあたっているときだけジャンプ出来る
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.CompareTag("Ground")){
				jump = false;
		}
	}
}
