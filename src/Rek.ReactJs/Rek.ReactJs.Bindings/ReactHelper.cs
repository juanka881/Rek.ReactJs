using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Rek.ReactJs.Bindings
{
	public class ReactHelper
	{
		public static void RegisterAllComponents()
		{
			var componentType = typeof(ReactComponent);

			var types = from asm in AppDomain.CurrentDomain.GetAssemblies()
						from type in asm.GetTypes()
						where type.IsSubclassOf(componentType) && type != componentType
						select type;

			foreach (var type in types)
			{
				var componentClass = CreateComponentClass(type);
				SetComponentTypeNewField(type, componentClass);
			}
		}

		public static JsDictionary CreateComponentSpec(Type type)
		{
			var componentSpec = new JsDictionary();
			var typePrototype = type.Prototype;

			foreach(var key in typePrototype.Keys)
			{
				if(key != "constructor" && HasOwnProperty(typePrototype, key))
				{
					componentSpec[key] = typePrototype[key];
				}
			}

			componentSpec["displayName"] = type.Name.Replace("Component", string.Empty);
			return componentSpec;
		}

		public static ReactClass CreateComponentClass(Type type)
		{
			var componentSpec = CreateComponentSpec(type);
			var componentClass = React.CreateClass(componentSpec);
			return componentClass;
		}

		[InlineCode("{obj}.hasOwnProperty(key)")]
		private static bool HasOwnProperty(object obj, string key)
		{
			return false;
		}

		[InlineCode("{type}.new$1 = {componentClass}")]
		private static void SetComponentTypeNewField(Type type, ReactClass componentClass)
		{

		}
	}
}