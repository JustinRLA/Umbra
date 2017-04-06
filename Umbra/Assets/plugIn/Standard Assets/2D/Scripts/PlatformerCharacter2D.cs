using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

    public class PlatformerCharacter2D : MonoBehaviour
    {
	public bool canJump;
	public bool hidden;
	SpriteRenderer mySpriteRenderer;
	public int numberofDeath;
	public GameObject AssassinTrigger;
		//Voici un commentaire test
	[SerializeField] public float m_MaxSpeed = 10f;                    // The fastest the player can travel in the x axis.
        [SerializeField] private float m_JumpForce = 400f;                  // Amount of force added when the player jumps.
        [Range(0, 1)] [SerializeField] private float m_CrouchSpeed = .36f;  // Amount of maxSpeed applied to crouching movement. 1 = 100%
        [SerializeField] private bool m_AirControl = false;                 // Whether or not a player can steer while jumping;
        [SerializeField] private LayerMask m_WhatIsGround;                  // A mask determining what is ground to the character
	public bool inShadow;
	public bool ClimbTrue;
	public bool canHide;
	public bool canhideTwo;
	public Transform TeleportPointDeath;
	public bool canhideThree;
	bool canstopHidden;
		public GameObject RunTrigger;
		CircleCollider2D RunCircleCollider;
	public bool canRune;
	public bool canChangeRune;
		public GameObject ViewTrigger;
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
	public GameObject CheckPointManager;
	public GameObject RealCheckPointManager;
	bool canBeSilenced;
	public GameObject MyRuneMan;
	public bool dead;

	RuneManagerScript myRuneManScript;

	void Start()
	{
		TeleportPointDeath = GameObject.Find ("teleportpointDeath").transform;
		numberofDeath = PlayerPrefs.GetInt ("Death");
		if(TruePlayer==true)
		actualOeillereSPriteRenderer = OeillereFeedback.GetComponent<SpriteRenderer> ();
		mySpriteRenderer = GetComponent<SpriteRenderer> ();
	}


        private void Awake()
        {
		MyRuneMan = GameObject.Find ("RuneManager");

		if(TruePlayer==true)
		myRuneManScript = MyRuneMan.GetComponent<RuneManagerScript> ();
			RunCircleCollider = RunTrigger.GetComponent<CircleCollider2D> ();
			m_GroundCheck = transform.Find("GroundCheck");
			m_CeilingCheck = transform.Find("CeilingCheck");
			m_Anim = GetComponent<Animator>();
			m_Rigidbody2D = GetComponent<Rigidbody2D>();
	

        }
	public void Death()
	{
		//AkSoundEngine.PostEvent ("PC_Action_Respawn", gameObject);
		dead = true;
		Time.timeScale = 1;
		inShadow = false;
		ClimbTrue = false;
		actualOeillereSPriteRenderer.enabled = false;
		ActualOeillere = null;
		numberofDeath++;
		PlayerPrefs.SetInt("Death",numberofDeath);
		StartCoroutine (DeathEvent ());

	}
	IEnumerator DeathEvent()
	{
		transform.position = TeleportPointDeath.position;
		yield return new WaitForSeconds (2f);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);

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
		//StartCoroutine(ChangeLadderCol());
		AkSoundEngine.PostEvent ("PC_Foot_Jump", gameObject);

		GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeRotation;
		//ThePlayer.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 10));
		GetComponent<Rigidbody2D>().velocity=new Vector2(0f, 15);
		GetComponent<Animator>().SetBool ("Climb", false);
		ClimbTrue = false;

	ReturnToNormal ();

	}


	public void ReturnToNormal()
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
		if (canHide == true && canhideTwo==true && canhideThree==true && Input.GetKeyDown (KeyCode.E) && dead==false)
		{
			hidden =! hidden;
		}
		if (hidden == true) {
			RunTrigger.layer = 26;
			ViewTrigger.layer = 26;
			m_MaxSpeed = 0;
			mySpriteRenderer.sortingOrder = -1;
			ViewTrigger.layer = 26;

			gameObject.layer = 26;
		}
			else
		{
			RunTrigger.layer = 13;
			ViewTrigger.layer = 13;

			m_MaxSpeed = 10;
			mySpriteRenderer.sortingOrder = 1;
			ViewTrigger.layer = 13;

				gameObject.layer = 13;
		}

		if (canHide == false)
			hidden = false;


			
		if (ActualLadder == null)
		{
			ReturnToNormal ();
			m_JumpForce = 650;
		}

		if(ActualLadder != null)
		{
			if (ClimbTrue == true && dead==false) 
		{
				
			m_JumpForce = 0;
			GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeAll;
			if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.Space)==false && transform.position.y < ActualLadder.GetComponent<maxHauteurLadder>().MaxHauteur.position.y)
				transform.Translate (Vector2.up * 2*Time.deltaTime);
			if (Input.GetKey (KeyCode.S) && transform.position.y > ActualLadder.GetComponent<maxHauteurLadder>().MinHauteur.position.y)
				transform.Translate (Vector2.down * 2*Time.deltaTime);
				if (Input.GetKey (KeyCode.Space) && canJump==true)
				{
					canJump = false;
				JumpFromLader ();		
				}
			GetComponent<Animator>().SetBool ("Climb", true);

			if (Input.GetKey (KeyCode.E))
				ReturnToNormal ();
		}
		else
		{
				m_JumpForce = 650;
				m_Rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
			GetComponent<Animator>().SetBool ("Climb", false);

		}
		}
		if(TruePlayer==true)
		{	
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
			canhideTwo = true;
			canRune = true;
			canChangeRune = true;
		}
		else
		{
			canhideTwo = false;

			canRune = false;
			canChangeRune = false;
		}		

		if(MyRuneMan != null && myRuneManScript!= null)
		{
			if(myRuneManScript.RuneModeEnabled==false && TruePlayer==true  && hidden==false)
		{
			// If crouching, check to see if the character can stand up
				if (!crouch && m_Anim.GetBool("Crouch") && dead==false)
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
					if(dead==false)
						{
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
			}
			// If the player should jump...
				if (m_Grounded && jump && m_Anim.GetBool("Ground") && dead==false)
			{
				// Add a vertical force to the player.
				m_Grounded = false;
				m_Anim.SetBool("Ground", false);
				m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
					AkSoundEngine.PostEvent ("PC_Foot_Jump", gameObject);
					canJump = false;
			}
				if (Input.GetKeyUp (KeyCode.Space))
					canJump = true;

		if(move==0||crouch==true||m_Grounded==false||canBeSilenced==true)
			{
				RunCircleCollider.transform.localScale=new Vector3(0.01f,0.01f,0.01f);	

			}
			else
			{
				RunCircleCollider.transform.localScale=new Vector3(1,1,1);		
			}
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
				canJump = false;
				// Add a vertical force to the player.
				m_Grounded = false;
				m_Anim.SetBool("Ground", false);
				m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
				AkSoundEngine.PostEvent ("PC_FOOT_JUMP", gameObject);
			}
			if (Input.GetKeyUp (KeyCode.Space))
				canJump = true;
			


		}

	
        }

		void OnTriggerEnter2D(Collider2D col)
		{
		if (col.tag == "Cachette")
			canHide = true;
		if (col.tag == "Ladder")
		{
			ClimbTrue = true;
			ActualLadder = col.gameObject;
		}
		
		if (col.tag == "Proj")
			Death ();

		if (col.tag == "oeillere" && TruePlayer==true)
			ActualOeillere = col.gameObject;

		if (col.tag == "Ombre")
			inShadow = true;
		
		}
//
	void OnTriggerExit2D(Collider2D col)
	{
		if (col.tag == "Cachette")
			canHide = false;
		
		if (col.tag == "Ladder")
			ClimbTrue = false;
		
		if (col.tag == "oeillere" && TruePlayer==true)
		{
			actualOeillereSPriteRenderer.enabled = false;
			ActualOeillere = null;
		}
		if (col.tag == "Ombre")
			inShadow = false;
		
			
	
	}
	//

//	IEnumerator ChangeLadderCol()
//	{
//		ActualLadder.GetComponent<Collider2D> ().enabled = false;
//		yield return new WaitForSeconds (1f);
//		ActualLadder.GetComponent<Collider2D> ().enabled = true;
//
//	}

        private void Flip()
        {
            // Switch the way the player is labelled as facing.
            m_FacingRight = !m_FacingRight;

            // Multiply the player's x local scale by -1.
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
	public void FootStepPlay()
	{
		AkSoundEngine.PostEvent ("PC_Foot_Run", gameObject);
	}

	void OnColliderEnter2D(Collision2D col)
	{
		if(col.gameObject.tag=="bloc" && m_Grounded==true)
			AkSoundEngine.PostEvent("")
			
	}
    }

