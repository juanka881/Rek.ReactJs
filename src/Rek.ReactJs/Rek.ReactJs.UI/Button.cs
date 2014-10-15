using Rek.ReactJs.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rek.ReactJs.UI
{
	public class Button : ReactComponent
	{
		public static ReactClass<Button> New = null;

		public override object Render()
		{
			return React.DOM.button(null, "hello!");
		}
	}
}