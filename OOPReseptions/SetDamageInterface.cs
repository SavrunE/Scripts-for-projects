private void OnTriggerEnter(Collider collider) {
  IHittable hitObject = collider.gameObject.GetComponent<MonoBihaviour>() as IHittable;
  //В версиях unity от 5.х можно передавать в метод GetComponent любой тип Т:
  IHittable hitObject = collider.gameObject.GetComponent<IHittable>();
 }
 // фишка в том, что получатель урона, содержет разные реализации взаимодействия
 
 public class Wall : MonoBehaviour, IHittable {

 public WallType wallType = WallType.Glass;
 public int prochnost = 100;

 public void HitObject(Vector2 hitDirection, float damage) {
  if (this.wallType == WallType.Glass) this.prochnost -= damage;
  else if (this.wallType == WallType.Brick) this.prochnost -= damage / 2f;
  else if (this.wallType == WallType.Metall) this.prochnost -= damage / 3f;
 }
 public enum WallType {
  Brick,
  Metal,
  Glass
 }
}

public class Box : MonoBehaviour, IHittable {
 
 public Rigidbody body = null;

 private void Start() {
  this.body = this.GetComponent<Rigidbody>() ?? this.gameObject.AddComponent<Rigidbody>();
 }
 public void HitObject(Vector2 hitDirection, float damage) {
  Vector2 force = hitDirection * damage;
  this.body.AddForce(force);
 }
}
public class Enemy : MonoBehaviour, IHittable {
 public float health;
 public void HitObject(Vector2 hitDirection, float damage) {
  this.health -= damage;
 }
}
