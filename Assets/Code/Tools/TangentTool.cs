using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangentTool : Tool {

	IEntity l0;

	protected override void OnMouseDown(Vector3 pos, ICADObject sko) {
		var entity = sko as IEntity;
		if(entity == null) return;
		if(entity.TangentAt(0.0) == null) return;

		if(l0 != null) {
			editor.PushUndo();
			new Tangent(DetailEditor.instance.currentSketch.GetSketch(), l0, entity);
			l0 = null;
		} else {
			l0 = entity;
		}
	}

	protected override void OnDeactivate() {
		l0 = null;
	}

	protected override string OnGetDescription() {
		return "hover and click two different lines.";
	}

}
