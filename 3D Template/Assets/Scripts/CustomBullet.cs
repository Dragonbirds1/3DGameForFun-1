using UnityEngine;

public class CustomBullet : MonoBehaviour
{
    // Assignables
    public Rigidbody rb;
    public GameObject explosion;
    public LayerMask whatIsEnemies;

    // Stats
    [Range(0f, 1f)]
    public float bounciness;
    public bool useGravity;

    // Damage
    public int explosionDamage;
    public float explosionRange;

    // Lifetime
    public int maxCollisions;
    public float maxLifetime;
    public bool explodeOnTouch = true;

    int collisions;
    PhysicsMaterial physics_mat;

    private void Start()
    {
        Setup();
    }

    private void Update()
    {
        // When to explode
        if (collisions > maxCollisions) Explode();

        // Count down lifetime
        maxLifetime -= Time.deltaTime;
        if (maxLifetime <= 0) Explode();
    }

    private void Explode()
    {
        // Instantiate explosion
        if (explosion != null) Instantiate(explosion, transform.position, Quaternion.identity);

        // Check for enemies
        Collider[] enemies = Physics.OverlapSphere(transform.position, explosionRange, whatIsEnemies);
        for (int i = 0; i < enemies.Length; i++)
        {
            // Get component of enemy and call Take Damage

            // Just an example!
            /// enemies[i].GetComponent<ShootingAi>().TakeDamage(explosionDamage);
        }

        /// Add a little delay, just to make sure everything works fine
        Invoke("Delay", 0.05f);
    }

    private void Delay()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Don't count collisions with other bullets
        if (collision.collider.CompareTag("Bullet")) return;

        // Count up collisions
        collisions++;

        // Explode if bullet hits an enemy directly and explodeOnTouch is activated
        if (collision.collider.CompareTag("Enemt") && explodeOnTouch) Explode();
    }

    private void Setup()
    {
        // Create a new Physic material
        physics_mat = new PhysicsMaterial();
        physics_mat.bounciness = bounciness;
        physics_mat.frictionCombine = PhysicsMaterialCombine.Minimum;
        physics_mat.bounceCombine = PhysicsMaterialCombine.Maximum;
        // Assign material to collider
        GetComponent<SphereCollider>().material = physics_mat;

        // Set gravity
        rb.useGravity = useGravity;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRange);
    }
}
