extends CharacterBody3D

@export var speed := 3.0
@export var attack_distance := 20.0

var target: Node3D


func _physics_process(_delta):
    if not is_instance_valid(target):
        return

    var distance = global_position.distance_to(
        target.global_position
    )

    if distance > attack_distance:
        var direction = (
            target.global_position -
            global_position
        ).normalized()

        velocity = direction * speed
        move_and_slide()
    else:
        attack()


func attack():
    print("Bot attacking player")