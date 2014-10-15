using System;
using System.Collections.Generic;
using System.Linq;

namespace Rek.ReactJs.Bindings
{
	public delegate T ReactClass<out T>(object props = null, object children = null) where T : ReactComponent;

	public delegate ReactComponent ReactClass(object props = null, object children = null);
}