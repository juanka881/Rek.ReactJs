using System;
using System.Collections.Generic;
using System.Linq;

namespace Rek.ReactJs.Bindings
{
	public class ReactComponentMixin
	{
		public virtual void ComponentWillMount()
		{

		}

		public virtual void ComponentWillUnmount()
		{

		}

		public virtual void ComponentDidMount()
		{

		}

		public virtual void ComponentWillReceiveProps(object nextProps)
		{

		}

		public virtual bool ShouldComponentUpdate(object nextProps, object nextState)
		{
			return true;
		}

		public virtual void ComponentWillUpdate(object nextProps, object nextState)
		{

		}

		public virtual void ComponentDidUpdate(object prevProps, object prevState)
		{

		}
	}
}