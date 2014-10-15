using System;
using System.Collections.Generic;
using System.Html;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Rek.ReactJs.Bindings
{
	public abstract class ReactComponent
	{
		public abstract object Render();

		[IntrinsicProperty]
		public string DisplayName { get; set; }

		[InlineCode("{this}.state[{name}]")]
		public T GetState<T>(string name)
		{
			return default(T);
		}

		[InlineCode("{this}.state[{name}] || {def}")]
		public T GetState<T>(string name, T def)
		{
			return default(T);
		}

		[InlineCode("{this}.props[{name}]")]
		public T GetProp<T>(string name)
		{
			return default(T);
		}

		[InlineCode("{this}.props[{name}] || {def}")]
		public T GetProp<T>(string name, T def)
		{
			return default(T);
		}

		public dynamic DProps
		{
			[InlineCode("{this}.props")]
			get
			{
				return null;
			}
		}

		public dynamic DState
		{
			[InlineCode("{this}.state")]
			get
			{
				return null;
			}
		}

		[InlineCode("{this}.getDOMNode()")]
		public Element GetDOMNode()
		{
			return null;
		}

		[InlineCode("{this}.setProps({props})")]
		public void SetProps<T>(T props) where T : ReactProps
		{

		}

		[InlineCode("{this}.replaceProps({nextProps})")]
		public void ReplaceProps<T>(T nextProps) where T : ReactProps
		{

		}

		[InlineCode("{this}.transferPropsTo({targetComponent})")]
		public T TransferPropsTo<T>(T targetComponent) where T : ReactComponent
		{
			return null;
		}

		[InlineCode("{this}.setState({state})")]
		public void SetState<T>(T state) where T : ReactState
		{

		}

		[InlineCode("{this}.setState({state}, {fn})")]
		public void SetState<T>(T state, Action fn) where T : ReactState
		{

		}

		[InlineCode("{this}.replaceState({nextState})")]
		public void ReplaceState<T>(T nextState) where T : ReactState
		{

		}

		[InlineCode("{this}.replaceState({nextState}, {fn})")]
		public void ReplaceState<T>(T nextState, Action fn) where T : ReactState
		{

		}

		[InlineCode("{this}.forceUpdate({fn})")]
		public void ForceUpdate(Action fn)
		{

		}

		[InlineCode("{this}.forceUpdate()")]
		public void ForceUpdate()
		{

		}

		public bool IsMounted
		{
			[InlineCode("{this}.isMounted()")]
			get
			{
				return false;
			}
		}

		[InlineCode("{this}.setProps({props})")]
		public void SetPropsUnsafe(object props)
		{

		}

		[InlineCode("{this}.replaceProps({nextProps})")]
		public void ReplacePropsUnsafe(object nextProps)
		{

		}

		[InlineCode("{this}.replaceProps({nextProps}, {fn})")]
		public void ReplacePropsUnsafe(object nextProps, Action fn)
		{

		}

		[InlineCode("{this}.setState({state})")]
		public void SetStateUnsafe(object state)
		{

		}

		[InlineCode("{this}.setState({state}, {fn})")]
		public void SetStateUnsafe(object state, Action fn)
		{

		}

		[InlineCode("{obj}.key || {obj}.$key")]
		public object GetKey(object obj)
		{
			return null;
		}

		public virtual object GetInitialState()
		{
			return null;
		}

		public virtual object GetDefaultProps()
		{
			return null;
		}

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

		[InlineCode("{s}")]
		public static implicit operator ReactComponent(string s)
		{
			return null;
		}

		[InlineCode("{s}")]
		public static implicit operator ReactComponent(int s)
		{
			return null;
		}

		[InlineCode("{s}")]
		public static implicit operator ReactComponent(double s)
		{
			return null;
		}

		[InlineCode("{s}")]
		public static implicit operator ReactComponent(List<ReactComponent> s)
		{
			return null;
		}

		[InlineCode("{s}")]
		public static implicit operator ReactComponent(ReactComponent[] s)
		{
			return null;
		}
	}

	public abstract class ReactComponent<P, S> : ReactComponent
		where P : ReactProps
		where S : ReactState
	{
		public P Props
		{
			[InlineCode("{this}.props")]
			get
			{
				return null;
			}
		}

		public S State
		{
			[InlineCode("{this}.state")]
			get
			{
				return null;
			}
		}
	}

	public abstract class ReactComponent<P> : ReactComponent<P, ReactState>
		where P : ReactProps
	{

	}
}