extends Node

@export var damage := 30.0
@export var magazine_size := 30
@export var ammo := 30
@export var fire_rate := 0.12

var can_fire := true


func fire():
    if ammo <= 0:
        reload()
        return

    if not can_fire:
        return

    ammo -= 1
    can_fire = false

    print("Weapon fired")

    await get_tree().create_timer(fire_rate).timeout
    can_fire = true


func reload():
    ammo = magazine_size
    print("Reloaded")