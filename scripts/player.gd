extends CharacterBody3D

@export var walk_speed := 5.0
@export var sprint_speed := 8.0
@export var jump_velocity := 5.0

@export var max_health := 100.0
@export var max_armor := 100.0

var health := 100.0
var armor := 0.0

var gravity := 9.8


func _ready():
    health = max_health
    armor = 0.0


func _physics_process(delta):

    if not is_on_floor():
        velocity.y -= gravity * delta

    var input_vector := Vector2(
        Input.get_axis("move_left", "move_right"),
        Input.get_axis("move_forward", "move_back")
    )

    var direction := Vector3(
        input_vector.x,
        0,
        input_vector.y
    )

    if direction.length() > 1.0:
        direction = direction.normalized()

    var speed := walk_speed

    if Input.is_action_pressed("sprint"):
        speed = sprint_speed

    velocity.x = direction.x * speed
    velocity.z = direction.z * speed

    if Input.is_action_just_pressed("jump") and is_on_floor():
        velocity.y = jump_velocity

    move_and_slide()


func take_damage(amount: float):

    if armor > 0:
        var absorbed := min(armor, amount * 0.5)

        armor -= absorbed
        amount -= absorbed

    health -= amount

    print("Health: ", health)

    if health <= 0:
        die()


func heal(amount: float):

    health = min(
        max_health,
        health + amount
    )


func add_armor(amount: float):

    armor = min(
        max_armor,
        armor + amount
    )


func die():

    print("PLAYER ELIMINATED")

    set_physics_process(false)

    velocity = Vector3.ZERO