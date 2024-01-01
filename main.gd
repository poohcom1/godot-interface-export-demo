@tool
extends Node

@export var holding_hammer = false:
	set(value):
		holding_hammer = value
		notify_property_list_changed()
var hammer_type

func _get_property_list():
	var properties = []
	properties.append({
		"name": "hammer_type",
		"type": TYPE_OBJECT,
		"usage": PROPERTY_USAGE_DEFAULT, # See above assignment.
		"hint": PROPERTY_HINT_INTERFACE,
		"hint_string": "TestNamespace.InterfaceA"
	})

	return properties
