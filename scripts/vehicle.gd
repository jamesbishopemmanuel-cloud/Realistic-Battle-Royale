extends CharacterBody3D

@export var speed := 20.0
@export var health := 1000.0


func _physics_process(_delta):
    var forward = Input.get_axis(
        "move_back",
        "move_forward"
    )

    velocity = -transform.basis.z * forward * speed
    move_and_slide()


func take_damage(amount: float):
    health -= amount

    if health <= 0:
        destroy_vehicle()


func destroy_vehicle():
    print("Vehicle destroyed")
    queue_free()