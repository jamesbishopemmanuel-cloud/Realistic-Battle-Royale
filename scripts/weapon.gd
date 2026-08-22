extends Node

@export var weapon_name := "Assault Rifle"
@export var damage := 30.0
@export var magazine_size := 30
@export var reserve_ammo := 120
@export var fire_rate := 0.12

var ammo := 30
var can_fire := true


func _ready():

    ammo = magazine_size


func fire():

    if not can_fire:
        return

    if ammo <= 0:

        reload()

        return

    ammo -= 1

    can_fire = false

    print(
        weapon_name,
        " fired | Ammo: ",
        ammo
    )

    await get_tree().create_timer(
        fire_rate
    ).timeout

    can_fire = true


func reload():

    if ammo >= magazine_size:
        return

    if reserve_ammo <= 0:
        print("No reserve ammo")
        return

    var needed := magazine_size - ammo
    var amount := min(
        needed,
        reserve_ammo
    )

    ammo += amount
    reserve_ammo -= amount

    print(
        "Reloaded | Ammo: ",
        ammo
    )