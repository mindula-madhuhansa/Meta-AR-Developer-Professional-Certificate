var PositionRotate=pc.createScript("positionRotate");PositionRotate.prototype.initialize=function(){this.entity.setPosition(0,2,2)},PositionRotate.prototype.update=function(t){this.entity.rotateLocal(1,1,1)};var InputDetection=pc.createScript("inputDetection");InputDetection.prototype.initialize=function(){this.app.keyboard.on(pc.EVENT_KEYDOWN,this.onKeyDown,this)},InputDetection.prototype.onKeyDown=function(t){t.key==pc.KEY_1&&this.app.fire("changePositionCenter"),t.key==pc.KEY_2&&this.app.fire("changePositionUp"),t.key==pc.KEY_3&&this.app.fire("changeRotation")};var PositionRotationWithEvents=pc.createScript("positionRotationWithEvents");PositionRotationWithEvents.prototype.initialize=function(){this.app.on("changePositionCenter",(()=>{this.entity.setPosition(0,0,0)}),this),this.app.on("changePositionUp",(()=>{this.entity.setPosition(0,2,0)}),this),this.app.on("changeRotation",(()=>{this.entity.rotateLocal(10,10,10)}),this)};