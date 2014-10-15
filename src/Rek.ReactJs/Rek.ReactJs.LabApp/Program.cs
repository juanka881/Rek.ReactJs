using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rek.ReactJs.Bindings;
using Rek.ReactJs.UI;

namespace Rek.ReactJs.LabApp
{
	public class Program
	{
		static void Main()
		{
			ReactHelper.RegisterAllComponents();

			var button = Button.New;
			var mainDiv = System.Html.Window.Document.GetElementById("main");

			React.RenderComponent(button(null, "hello!"), mainDiv);

			Console.WriteLine("render done!");
		}
	}
}
