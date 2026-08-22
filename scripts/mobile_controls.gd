extends Node

var movement := Vector2.ZERO
var look := Vector2.ZERO


func set_movement(value: Vector2):
    movement = value


func set_look(value: Vector2):
    look = value


func fire():
    print("Mobile fire")


func reload():
    print("Mobile reload")


func jump():
    print("Mobile jump")