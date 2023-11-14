# UnitySpaceGame
Space Shooter in Unity (editor ver 2022.3.4f1)

About

Space Shooter is a classic arcade-style shooting game where players control a spaceship and shoot down sets of enemy ships. 

Done

Background movement effect.
Player control.
Sets of enemies following the waypoint path are generated. 
Firing and damage.
SOund effects and background music.


Developer's Guide

Folder Scripts>

class BackgroundController : MonoBehaviour
 	Background Movement. 
	Creates endless background effect.
	Bound to GameObject Background. 
	
class CameraWidthCorrection: MonoBehaviour
	Correction of Camera width to fixed size in pixels.
	Bounds to GameObject Main Camera. 

class CameraEffect : MonoBehaviour
	Play camera effect to enlarge explosion effect.
	Bounds to GameObject Main Camera. 

class ShipController : MonoBehaviour
	Control Player.
	Allows user to control the Player Ship. Uses Input System. 
	Bounds to Prefab PlayerShip.

class GenerateRandomTime : MonoBehaviour
	Generate random value with params.
	Bounds to GameObject RandomGenerator.

class DestroyInvisibleObject : MonoBehaviour
	Destroy gameObject which have left a visible area.
	Bounds to Prefabs LazerEnamy*, LazerPlayer.

class AudioController : MonoBehaviour
	Play sounds effects.
	Bounds to GameObject AudioController.

Folder Scripts>Enemy>

class EnemySetObject : ScriptableObject
	Discribes a set of enemies, collects them in the List<GameObject> enemyPrefabs.
	Objects of this class are used in class GenerateEnemies.

class  FollowWay: MonoBehaviour
	Enemy Movement.
	Moves the parent GameObject along the points specified by the List<Transform> wayElements.  
	Bounds to each Prefab EnemyShip.

class GenerateEnemies : MonoBehaviour
	Enemy Generator.
	Using the execution of a coroutine class instantiates sets of enemies discribed by the List<EnemySetObject>.
	Bounds to GameObject GenerateEnemies. 

Folder Scripts>Damage>

class DamageMaker : MonoBehaviour
	Makes damage.
	Bounds to each Prefab that makes a damage.

class LifeCounter : MonoBehaviour
	Controls life count and destroys objects when life is over.
	Bounds to each Prefab that has a life.

class Firing : MonoBehaviour
	Generates laser bullets.
	Using the execution of a coroutine class instantiates sets of lazer bullets.
	Bounds to Prefabs EnemyShip* and PlayerShip.
	
class AutoFiring : MonoBehaviour
	Control firing process for enemies.
	Bounds to Prefabs EnemyShip*

class ExplosionEffect : MonoBehaviour
	Play explosion effect by instantiating particle system (Prefab Explosion).
	Bounds to Prefabs PlayerShip.


Particle Systems>

Stars GameObject - Movement of stars.
	Parent object - Background.
	Contains a Particle System to simulate the movement of stars.

Explosion Prefab - Explosion effect.
	Instantiates in ExplosionEffect class.
	Contains a Particle System to simulate an explosion using material Mat_explosion.

Sources:
https://opengameart.org/ - background music.
https://kenney.nl/ - sounds and sprites.

