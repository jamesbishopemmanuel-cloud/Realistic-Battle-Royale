extends Node

@export var max_players := 100
@export var zone_radius := 1000.0
@export var zone_damage := 5.0

var players: Array[Node] = []
var match_started := false


func start_match():
    match_started = true
    print("Battle Royale started")


func add_player(player: Node):
    if players.size() < max_players:
        players.append(player)


func remove_player(player: Node):
    players.erase(player)


func get_alive_players() -> int:
    var alive := 0

    for player in players:
        if is_instance_valid(player):
            alive += 1

    return alive


func shrink_zone():
    zone_radius *= 0.9
    print("Zone radius: ", zone_radius)