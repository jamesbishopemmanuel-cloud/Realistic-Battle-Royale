extends Node

@export var max_players := 100

@export var starting_zone_radius := 1000.0
@export var minimum_zone_radius := 20.0

@export var zone_shrink_time := 60.0
@export var zone_damage := 5.0

var players: Array[Node] = []

var zone_radius := 1000.0
var match_started := false
var elapsed := 0.0


func start_match():

    match_started = true
    zone_radius = starting_zone_radius

    print("================================")
    print("BATTLE ROYALE STARTED")
    print("Players: ", max_players)
    print("Zone: ", zone_radius)
    print("================================")


func _process(delta):

    if not match_started:
        return

    elapsed += delta

    if elapsed >= zone_shrink_time:

        elapsed = 0

        shrink_zone()


func shrink_zone():

    zone_radius = max(
        minimum_zone_radius,
        zone_radius * 0.85
    )

    print(
        "ZONE SHRINKING: ",
        zone_radius
    )


func add_player(player: Node):

    if players.size() >= max_players:
        return

    players.append(player)


func remove_player(player: Node):

    players.erase(player)


func alive_players() -> int:

    var count := 0

    for player in players:

        if is_instance_valid(player):
            count += 1

    return count