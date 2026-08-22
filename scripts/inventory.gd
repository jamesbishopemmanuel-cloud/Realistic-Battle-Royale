extends Node

@export var max_slots := 10

var items: Array[String] = []


func add_item(item: String) -> bool:

    if items.size() >= max_slots:
        print("Inventory full")
        return false

    items.append(item)

    print("Picked up: ", item)

    return true


func remove_item(item: String):

    items.erase(item)


func has_item(item: String) -> bool:

    return items.has(item)


func get_items():

    return items