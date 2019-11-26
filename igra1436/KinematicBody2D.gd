extends KinematicBody2D

var muy = Vector2() 
var speed = 10000 #скорость движения
var grav = 50 #сила гравитации
var jamp =1000 #сила прыжка
const vitop = Vector2(0,-1) #от этого зависят прыжки 

func _physics_process(delta):  #всякие процессы
	if Input. is_action_pressed('ui_left'):
		muy.x = -1	 #движение в лево
	elif Input. is_action_pressed('ui_right'):
		muy.x = 1 #движение в право
	else:
		muy.x = 0 #если ничего не жать то ничего не будет
	muy.y += grav; #гравитация
	
	
	if is_on_floor() && Input. is_action_just_pressed('ui_up'):
		muy.y = -jamp #прыжок
	
	

	if muy.x:
		muy.x *= speed*delta  #умножение на дельта для плавности перемещения
		#speed скорость движенияп по X-кординатам(горизонтали)
	muy = move_and_slide(muy,vitop)	
	
	animate()
func animate():
	var anim = 'idle'
	if muy.y and not $RayCast2D.is_colliding():
		anim = 'jump'
	elif muy.y < 0 and not $RayCast2D.is_colliding():
		anim = 'fall'
	else:
		if muy.x != 0:
			anim = 'run'
			if muy.x > 0:
				$Sprite.flip_h = false
			else:
				$Sprite.flip_h = true
	if $Sprite.animation != anim:
		$Sprite.play(anim)		