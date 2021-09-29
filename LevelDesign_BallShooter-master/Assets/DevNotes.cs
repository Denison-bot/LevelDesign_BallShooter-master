

// What happens when you shot your last ball and you havent won the level?
// 
// + more control over power of shot
// + score indicator
// + on screen instructions


//Extras
// + Background Music
// + SFX slots
// Title Screen
// Help Screens
// General Screen flow
// better visual for aiming guide
// Boost platforms

// DONE
// Fix aim guide rotation by destroying the object on shoot, the reinstantiating on aim mode
// + block out controls while ball is rolling
// + triggerm volume for end game level
// + return control when velocity goes below a certain threshold
// + Level Manager
// + start position for every level
// + add Singleton Pattern to carry GameManager between levels
// + add slowdown when velocity goes below a certain threshold
// + add trigger volume below level to catch stray balls


/* Ways to slow down the ball.

Other than changing the drag, there are still other ways to do this. You just have to experiment to see which one works best.


* * * * * * * * * * * * * * * 

METHOD #1 Change the drag
 
myRigidBody.drag = 20f;

* * * * * * * * * * * * * * * 



METHOD #2 Add force to the opposite velocity.

public Rigidbody myRigidBody;
void FixedUpdate()
{
    Vector3 oppositeVelocity = -myRigidBody.velocity;
    myRigidBody.AddRelativeForce(oppositeVelocity);
}


* * * * * * * * * * * * * * * 
https://stackoverflow.com/questions/44484508/slow-down-rigidbody

METHOD #3 Decrement or Lerp the current velocity back to the normal force.

public Rigidbody myRigidBody;
Vector3 normalForce;

void Start()
{
    normalForce = new Vector3(50, 0, 0);

    //Add force  
    myRigidBody.velocity = new Vector3(500f, 0f, 0f);
    //OR
    //myRigidBody.AddForce(new Vector3(500f, 0f, 0f));
}

void FixedUpdate()
{
    //Go back to normal force within 2 seconds
    slowDown(myRigidBody, normalForce, 2);
    Debug.Log(myRigidBody.velocity);
}

bool isMoving = false;

void slowDown(Rigidbody rgBody, Vector3 normalForce, float duration)
{
    if (!isMoving)
    {
        isMoving = true;
        StartCoroutine(_slowDown(rgBody, normalForce, duration));
    }
}

IEnumerator _slowDown(Rigidbody rgBody, Vector3 normalForce, float duration)
{
    float counter = 0;
    //Get the current position of the object to be moved
    Vector3 currentForce = rgBody.velocity;

    while (counter < duration)
    {
        counter += Time.deltaTime;
        rgBody.velocity = Vector3.Lerp(currentForce, normalForce, counter / duration);
        yield return null;
    }

    isMoving = false;
}


* * * * * * * * * * * * * * * 


METHOD #4 Change the dynamic friction of the Physics Material.
You can't use this method because it requires collider which you don't have.

//Get the PhysicMaterial then change its dynamicFriction
PhysicMaterial pMat = myRigidBody.GetComponent<Collider>().material;
pMat.dynamicFriction = 10;


* * * * * * * * * * * * * * * 

It's really up to you to experiment and decide which one works best for you. They are useful depending on what type of game you are making. 
For example, #4 is mostly used when rolling a ball because it uses physics material which requires frequent collision to actually work.

The method used in #3 gives you control over how long the transition should happen. If you need to control that then that's the choice.

*/








