using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float speed;
    private Animator _anim;


	void Start ()
	{
	  _anim= GetComponent<Animator>();

      _anim.SetInteger("State", 0); //return to idle  
    }
	
	
	void Update ()
	{
	    MovePlayer(speed);

	   if (Input.GetKeyDown(KeyCode.LeftArrow))
	    {
            _anim.SetInteger("State", 2); //running  
	        speed = -speedX;
	    }

	    if (Input.GetKeyUp(KeyCode.LeftArrow))
	    {
            _anim.SetInteger("State", 3); // return to idle
	        speed = 0.0f;

	    }

	    if (Input.GetKeyDown(KeyCode.RightArrow))
	    {
	        _anim.SetInteger("State", 1); //walking  
	    }

	    if (Input.GetKeyUp(KeyCode.RightArrow))
	    {
	        _anim.SetInteger("State", 0); //return to idle
	    }
    }
    void MovePlayer(float playerSpeed)();

}
