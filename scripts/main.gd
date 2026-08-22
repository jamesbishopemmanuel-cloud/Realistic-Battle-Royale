extends Node3D

var match_time := 0.0
var match_started := false

@onready var player = $Player
@onready var battle_royale = $BattleRoyale


func _ready():
    battle_royale.start_match()
    match_started = true

    print("REALISTIC BATTLE ROYALE")
    print("Match started")


func _process(delta):
    if not match_started:
        return

    match_time += delta

    if int(match_time) % 60 == 0:
        pass