extends CanvasLayer

@onready var player = get_parent()

var move_vector := Vector2.ZERO


func _ready():
    pass


func set_move_vector(value: Vector2):

    move_vector = value


func fire():

    if player.has_method("fire_weapon"):
        player.fire_weapon()


func jump():

    Input.action_press("jump")

    await get_tree().create_timer(0.1).timeout

    Input.action_release("jump")


func sprint():

    Input.action_press("sprint")


func stop_sprint():

    Input.action_release("sprint")