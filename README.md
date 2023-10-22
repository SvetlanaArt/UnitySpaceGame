# UnitySpaceGame
Space Shooter in Unity (editor ver 2022.3.4f1)

About
Space Shooter is a classic arcade-style shooting game where players control a spaceship and shoot down sets of enemy ships. 

Done
Background movement effect.
Player control.
Sets of enemies following the waypoint path are generated. 


Developer's Guide

class BackgroundController : MonoBehaviour
 	Background Movement. 
	Creates endless background effect.
	Bound to GameObject Background. 
	
class CameraWidthCorrection: MonoBehaviour
	Correction of Camera width to fixed size in pixels.
	Bound to GameObject Main Camera. 

class EnemySetObject : ScriptableObject
	Discribes a set of enemies, collects them in the List<GameObject> enemyPrefabs.
	Objects of this class are used in class GenerateEnemies.

class  FollowWay: MonoBehaviour
	Enemy Movement.
	Moves the parent GameObject along the points specified by the List<Transform> wayElements.  
	Bound to each Prefab EnemyShip.

class GenerateEnemies : MonoBehaviour
	Enemy Generator.
	Using the execution of a coroutine this class instantiates sets of enemies discribed by the List<EnemySetObject>.
	Bound to GameObject GenerateEnemies. 

class ShipMovement : MonoBehaviour
	Control Player.
	Allows user to control the Player Ship. Uses Input System. 
	Bound to Prefab PlayerShip.


	
Stars GameObject - Movement of stars.
	Parent object - Background.
	Contains a Particle System to simulate the movement of stars.