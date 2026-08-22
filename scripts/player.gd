extends CharacterBody3D

@export var walk_speed := 5.0
@export var sprint_speed := 8.0
@export var jump_velocity := 5.0
@export var health := 100.0
@export var armor := 100.0

func _physics_process(delta):
    if not is_on_floor():
        velocity.y -= 9.8 * delta

    var input_vector = Input.get_vector(
        "move_left",
        "move_right",
        "move_forward",
        "move_back"
    )

    var direction = Vector3(
        input_vector.x,
        0,
        input_vector.y
    )

    var speed = walk_speed

    if Input.is_action_pressed("sprint"):
        speed = sprint_speed

    velocity.x = direction.x * speed
    velocity.z = direction.z * speed

    if Input.is_action_just_pressed("jump") and is_on_floor():
        velocity.y = jump_velocity

    move_and_slide()


func take_damage(amount: float):
    if armor > 0:
        var absorbed = min(armor, amount * 0.5)
        armor -= absorbed
        amount -= absorbed

    health -= amount

    if health <= 0:
        die()


func die():
    print("Player eliminated")
    queue_free()