using System;
using System.Collections;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using System.Text;

namespace Rek.ReactJs.Bindings
{
	[Imported]
	[ScriptNamespace("")]
	public class React
	{
		public static void InitializeTouchEvents(bool shouldUseTouch)
		{
			
		}

		public static ReactDOMInstance DOM;

		public static ReactClass CreateClass(JsDictionary componentSpec)
		{
			return null;
		}

		public static ReactComponent RenderComponent(ReactComponent reactComponent, Element mountNode)
		{
			return null;
		}

		public static ReactComponent RenderComponent(ReactComponent reactComponent, Element mountNode, Action fn)
		{
			return null;
		}

		public static bool UnmountComponentAtNode(Element mountNode)
		{
			return false;
		}

		public static string RenderComponentToString(ReactComponent reactComponent)
		{
			return null;
		}

		public static string RenderComponentToStaticMarkup(ReactComponent reactComponent)
		{
			return null;
		}
	}
}
