using UnityEngine;
		using UnityEngine.EventSystems;
		using System.Collections;

		public class KeyboardControll : MonoBehaviour {

			public float sensitivity = 2; 
			private Vector2 initialpos;
			public Animator Playeranimator;
			private CapsuleCollider myCollider;
			private Vector3 Center; 	
			void Start () {
				if (gameObject.GetComponent<EventTrigger> () == null)
					gameObject.AddComponent<EventTrigger> ();
				myCollider = gameObject.GetComponent<CapsuleCollider> ();
				if (myCollider == null)
					Debug.Log ("nai");
			}


			void Update()
			{
				if (Input.GetKey(KeyCode.DownArrow)) {
					StartCoroutine (PlayerAnimation ("Slide"));
					//myCollider.enabled = false;
			StartCoroutine(BondhoGoraile("false"));

				} 
				else if (Input.GetKey(KeyCode.UpArrow)) {
					StartCoroutine (PlayerAnimation ("Jump"));
					//myCollider.enabled = false;
				StartCoroutine(BondhoLafaile("false"));	
				}
				
			/*if (myCollider.enabled == false) {
				StartCoroutine (Bondho ("false"));
				}*/
			}
			

			IEnumerator PlayerAnimation(string state){
				Playeranimator.SetBool(state,true);
				yield return new WaitForSeconds(0.25f);
				Playeranimator.SetBool (state, false);
			}
			
		IEnumerator BondhoGoraile(string state)
		{
		myCollider.center = new Vector3(0.0f,-0.5f,0.0f);
			yield return new WaitForSeconds(2.0f);
		myCollider.center = new Vector3(0.0f,0.67f,0.0f);
		}


		IEnumerator BondhoLafaile(string state)
		{
			myCollider.center = new Vector3(0.0f,1.68f,0.0f);
			yield return new WaitForSeconds(.40f);
		myCollider.center = new Vector3(0.0f,0.67f,0.0f);
		}


		}
