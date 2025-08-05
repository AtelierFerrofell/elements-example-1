@tool
extends Control


@export var card: Card:
	set(new_card):
		if card != null:
			card.changed.disconnect(_on_card_changed)
		card = new_card
		if card != null:
			card.changed.connect(_on_card_changed)
			_on_card_changed()
		else:
			$ColorRect.color = Color.WHITE
			$Label.text = ""


func _on_card_changed():
	# Add guardrails here later
	$ColorRect.color = card.Info.Element.Info.Color
	$Label.text = card.Info.Element.Info.Name


# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	pass
