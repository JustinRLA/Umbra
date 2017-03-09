using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

    public class PlatformerCharacter2D : MonoBehaviour
    {
		//Voici un commentaire test
	[SerializeField] public float m_MaxSpeed = 10f;                    // The fastest the player can travel in the x axis.
        [SerializeField] private float m_JumpForce = 400f;                  // Amount of force added when the player jumps.
        [Range(0, 1)] [SerializeField] private float m_CrouchSpeed = .36f;  // Amount of maxSpeed applied to crouching movement. 1 = 100%
        [SerializeField] private bool m_AirControl = false;                 // Whether or not a player can steer while jumping;
        [SerializeField] private LayerMask m_WhatIsGround;                  // A mask determining what is ground to the character
	public bool inShadow;
	public bool ClimbTrue;
		public GameObject RunTrigger;
		CircleCollider2D RunCircleCollider;
	public bool canRune;
	public GameObject DeathManager;
	public bool canChangeRune;
		//public GameObject ViewTrigger;
//		CircleCollider2D ViewTriggerCollider;
	public bool TruePlayer;
        private Transform m_GroundCheck;    // A position marking where to check if the player is grounded.
        const float k_GroundedRadius = .2f; // Radius of the overlap circle to determine if grounded
	public bool m_Grounded;            // Whether or not the player is grounded.
        private Transform m_CeilingCheck;   // A position marking where to check for ceilings
        const float k_CeilingRadius = .01f; // Radius of the overlap circle to determine if the player can stand up
        private Animator m_Anim;            // Reference to the player's animator component.
        private Rigidbody2D m_Rigidbody2D;
	public bool m_FacingRight = true;  // For determining which way the player is currently facing.
	public GameObject ActualLadder;
	public GameObject OeillereFeedback;
	public GameObject ActualOeillere;
	SpriteRenderer actualOeillereSPriteRenderer;

	bool canBeSilenced;
	public GameObject MyRuneMan;
	RuneManagerScript myRuneManScript;

	void Start()
	{
		actualOeillereSPriteRenderer = OeillereFeedback.GetComponent<SpriteRenderer> ();
		DeathManager = GameObject.Find ("deathManager");
	}


        private void Awake()
        {
		MyRuneMan = GameObject.Find ("RuneManager");

		if(TruePlayer==true)
		myRuneManScript = MyRuneMan.GetComponent<RuneManagerScript> ();
			RunCircleCollider = RunTrigger.GetComponent<CircleCollider2D> ();
		//	ViewTriggerCollider = ViewTrigger.GetComponent<CircleCollider2D> ();
            // Setting up references.
			m_GroundCheck = transform.Find("GroundCheck");
			m_CeilingCheck = transform.Find("CeilingCheck");
			m_Anim = GetComponent<Animator>();
			m_Rigidbody2D = GetComponent<Rigidbody2D>();
	

        }
	public void Death()
	{
		inShadow = false;
		ClimbTrue = false;
//		print ("Bouhhhhhhhhhhhhhhhjhbhyb");
		actualOeillereSPriteRenderer.enabled = false;
		ActualOeillere = null;
		DeathManager.GetComponent<DeathManagerScript> ().PlayerDeath ();

	}

	public void StartCorou()
	{
		StartCoroutine (FastPlayer ());

	}

	public void StartShadowCorou()
	{
		StartCoroutine (ShadowPlayer ());

	}

	IEnumerator ShadowPlayer()
	{
		gameObject.layer = 7;
		GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, 0.5f);
		yield return new WaitForSeconds (10f);
		gameObject.layer = 8;
		GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, 1f);


	}


	IEnumerator FastPlayer()
	{

		m_MaxSpeed = 12f;
		m_JumpForce = 600f;   
		GetComponent<SpriteRenderer> ().color = new Color (1, 0, 1, 1f);
		canBeSilenced = true;
		yield return new WaitForSeconds (10f);
		canBeSilenced = false;
		m_MaxSpeed = 10f;
		m_JumpForce = 400f;   
		GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, 1f);


	}
	void JumpFromLader()
	{
		//canClimb = false;
		StartCoroutine(ChangeLadderCol());

		GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeRotation;
		//ThePlayer.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 10));
		GetComponent<Rigidbody2D>().velocity=new Vector2(0f, 15);
		GetComponent<Animator>().SetBool ("Climb", false);
		ClimbTrue = false;

	ReturnToNormal ();

	}


	void ReturnToNormal()
	{

		//canClimb = false;
		GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeRotation;

		//		ThePlayer.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeRotation;
		GetComponent<Animator>().SetBool ("Climb", false);
		ClimbTrue = false;
		//GetComponent<Collider2D> ().enabled = false;
		StartCoroutine(ReturnJumpForce());

		//GetComponent<Collider2D> ().enabled = true;

	}
	IEnumerator ReturnJumpForce()
	{

		yield return new WaitForSeconds (1f);
		m_JumpForce = 650;


		//GetComponent<Collider2D> ().enabled = true;

	}

	void Update()
	{
		if (ClimbTrue == true) 
		{
			m_JumpForce = 0;
			GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeAll;
			if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.Space)==false && transform.position.y < ActualLadder.GetComponent<maxHauteurLadder>().MaxHauteur.position.y)
				transform.Translate (Vector2.up * 2*Time.deltaTime);
			if (Input.GetKey (KeyCode.S) && transform.position.y > ActualLadder.GetComponent<maxHauteurLadder>().MinHauteur.position.y)
				transform.Translate (Vector2.down * 2*Time.deltaTime);
			if (Input.GetKey (KeyCode.Space))
				JumpFromLader ();		

			GetComponent<Animator>().SetBool ("Climb", true);

			if (Input.GetKey (KeyCode.E))
				ReturnToNormal ();
		}
		else
		{
			GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeRotation;
			GetComponent<Animator>().SetBool ("Climb", false);

		}


	if(ActualOeillere !=null)
	{
		if (ActualOeillere.GetComponent<oeillereChecjBoth> ().IsInside == true)
		{
			actualOeillereSPriteRenderer.enabled = true;
//			print ("showFuckfgFeedback");
		}
		else
			actualOeillereSPriteRenderer.enabled = false;
	}
	}
        private void FixedUpdate()
        {
			m_Grounded = false;

			// The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
			// This can be done using layers instead but Sample Assets will not overwrite your project settings.
			Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
			for (int i = 0; i < colliders.Length; i++)
			{
			if (colliders[i].gameObject != gameObject && ClimbTrue==false)
					m_Grounded = true;
			}
			m_Anim.SetBool("Ground", m_Grounded);

			// Set the vertical animation
			m_Anim.SetFloat("vSpeed", m_Rigidbody2D.velocity.y);

        }


        public void Move(float move, bool crouch, bool jump)
        {
		if (move == 0)
		{
			canRune = true;
			canChangeRune = true;
		}
		else
		{
			canRune = false;
			canChangeRune = false;
		}		

		if(MyRuneMan != null)
		{
		if(myRuneManScript.RuneModeEnabled==false && TruePlayer==true)
		{
			// If crouching, check to see if the character can stand up
			if (!crouch && m_Anim.GetBool("Crouch"))
			{
				// If the character has a ceiling preventing them from standing up, keep them crouching
				if (Physics2D.OverlapCircle(m_CeilingCheck.position, k_CeilingRadius, m_WhatIsGround))
				{
					crouch = true;
				}
			}

			// Set whether or not the character is crouching in the animator
			m_Anim.SetBool("Crouch", crouch);

			//only control the player if grounded or airControl is turned on
			if (m_Grounded || m_AirControl)
			{
				// Reduce the speed if crouching by the crouchSpeed multiplier
				move = (crouch ? move*m_CrouchSpeed : move);

				// The Speed animator parameter is set to the absolute value of the horizontal input.
				m_Anim.SetFloat("Speed", Mathf.Abs(move));

				// Move the character
			m_Rigidbody2D.velocity = new Vector2(move*m_MaxSpeed
				, m_Rigidbody2D.velocity.y);
					if(ClimbTrue==false)
				{
				// If the input is moving the player right and the player is facing left...
				if (move > 0 && !m_FacingRight)
				{
					// ... flip the player.
					Flip();
				}
				// Otherwise if the input is moving the player left and the player is facing right...
				else if (move < 0 && m_FacingRight)
				{
					// ... flip the player.
					Flip();
					}
				}
			}
			// If the player should jump...
			if (m_Grounded && jump && m_Anim.GetBool("Ground"))
			{
				// Add a vertical force to the player.
				m_Grounded = false;
				m_Anim.SetBool("Ground", false);
				m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
			}

		if(move==0||crouch==true||m_Grounded==false||canBeSilenced==true)
			{
				RunCircleCollider.transform.localScale=new Vector3(0.01f,0.01f,0.01f);	

			}
			else
			{
				RunCircleCollider.transform.localScale=new Vector3(1,1,1);		
			}
		//	if(move==0)
				//ViewTriggerCollider.transform.localScale=new Vector3(0.05f,0.05f,0.05f);	
			//if(crouch==true && move!=0)
			//	ViewTriggerCollider.transform.localScale=new Vector3(0.1f,0.1f,0.1f);	
		//	if(crouch==false && move!=0)
			//	ViewTriggerCollider.transform.localScale=new Vector3(0.2f,0.2f,0.2f);	
			}
		}
		if(TruePlayer==false)
		{
			// If crouching, check to see if the character can stand up
			if (!crouch && m_Anim.GetBool("Crouch"))
			{
				// If the character has a ceiling preventing them from standing up, keep them crouching
				if (Physics2D.OverlapCircle(m_CeilingCheck.position, k_CeilingRadius, m_WhatIsGround))
				{
					crouch = true;
				}
			}

			// Set whether or not the character is crouching in the animator
			m_Anim.SetBool("Crouch", crouch);

			//only control the player if grounded or airControl is turned on
			if (m_Grounded || m_AirControl)
			{
				// Reduce the speed if crouching by the crouchSpeed multiplier
				move = (crouch ? move*m_CrouchSpeed : move);

				// The Speed animator parameter is set to the absolute value of the horizontal input.
				m_Anim.SetFloat("Speed", Mathf.Abs(move));

				// Move the character
				m_Rigidbody2D.velocity = new Vector2(move*m_MaxSpeed
					, m_Rigidbody2D.velocity.y);
				if(ClimbTrue==false)
				{
					// If the input is moving the player right and the player is facing left...
					if (move > 0 && !m_FacingRight)
					{
						// ... flip the player.
						Flip();
					}
					// Otherwise if the input is moving the player left and the player is facing right...
					else if (move < 0 && m_FacingRight)
					{
						// ... flip the player.
						Flip();
					}
				}
			}
			// If the player should jump...
			if (m_Grounded && jump && m_Anim.GetBool("Ground"))
			{
				// Add a vertical force to the player.
				m_Grounded = false;
				m_Anim.SetBool("Ground", false);
				m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
			}
	

					//			if(move==0||crouch==true||m_Grounded==false||canBeSilenced==true)
//			{
//				RunCircleCollider.transform.localScale=new Vector3(0.01f,0.01f,0.01f);	
//
//			}
//			else
//			{
//				RunCircleCollider.transform.localScale=new Vector3(1,1,1);		
//			}
			//	if(move==0)
			//ViewTriggerCollider.transform.localScale=new Vector3(0.05f,0.05f,0.05f);	
			//if(crouch==true && move!=0)
			//	ViewTriggerCollider.transform.localScale=new Vector3(0.1f,0.1f,0.1f);	
			//	if(crouch==false && move!=0)
			//	ViewTriggerCollider.transform.localScale=new Vector3(0.2f,0.2f,0.2f);	

		}

	
        }

		void OnTriggerEnter2D(Collider2D col)
		{
		print (col.name);
		if (col.tag == "Ladder")
		{
			ClimbTrue = true;
			ActualLadder = col.gameObject;
		}
		
		if (col.tag == "Proj")
			Death ();

		if (col.tag == "oeillere")
			ActualOeillere = col.gameObject;

		if (col.tag == "Ombre")
			inShadow = true;
		
		}
//
	void OnTriggerExit2D(Collider2D col)
	{
		if (col.tag == "Ladder")
			ClimbTrue = false;
		
		if (col.tag == "oeillere")
		{
			actualOeillereSPriteRenderer.enabled = false;
			ActualOeillere = null;
		}
		if (col.tag == "Ombre")
			inShadow = false;
		
			
	
	}
	//

	IEnumerator ChangeLadderCol()
	{
		ActualLadder.GetComponent<Collider2D> ().enabled = false;
		yield return new WaitForSeconds (1f);
		ActualLadder.GetComponent<Collider2D> ().enabled = true;

	}

        private void Flip()
        {
            // Switch the way the player is labelled as facing.
            m_FacingRight = !m_FacingRight;

            // Multiply the player's x local scale by -1.
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }

