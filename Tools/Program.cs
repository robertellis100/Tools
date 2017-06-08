using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Tools
{
	class Program
	{
		static void Main(string[] args)
		{
			ToolBox toolbox1 = new ToolBox();
			toolbox1.ToolBoxList = new List<object>();

			Tool slottedScrewdriver = new Tool();
			slottedScrewdriver.Name = "Slotted Screwdriver";
			slottedScrewdriver.Type = "Screwdriver";
			toolbox1.AddTool(slottedScrewdriver, toolbox1);

			Tool phillipsScrewdriver = new Tool();
			phillipsScrewdriver.Name = "Phillips Screwdriver";
			phillipsScrewdriver.Type = "Screwdriver";
			toolbox1.AddTool(phillipsScrewdriver, toolbox1);

			Tool inchNutDriver = new Tool();
			inchNutDriver.Name = "Inch Nut Driver";
			inchNutDriver.Type = "Screwdriver";
			toolbox1.AddTool(inchNutDriver, toolbox1);

			Tool pozidriv = new Tool();
			pozidriv.Name = "Pozidriv";
			pozidriv.Type = "Power Bit";
			toolbox1.AddTool(pozidriv, toolbox1);

			Tool securityTorx = new Tool();
			securityTorx.Name = "Security Torx";
			securityTorx.Type = "Power Bit";
			toolbox1.AddTool(securityTorx, toolbox1);

			Tool hexInch = new Tool();
			hexInch.Name = "Hex Inch";
			hexInch.Type = "Power Bit";
			toolbox1.AddTool(hexInch, toolbox1);

			Tool openEndWrench = new Tool();
			openEndWrench.Name = "Open End Wrench";
			openEndWrench.Type = "Wrench";
			toolbox1.AddTool(openEndWrench, toolbox1);

			Tool combinationWrench = new Tool();
			combinationWrench.Name = "Combination Wrench";
			combinationWrench.Type = "Wrench";
			toolbox1.AddTool(combinationWrench, toolbox1);

			Tool boxEndWrench = new Tool();
			boxEndWrench.Name = "Box End Wrench";
			boxEndWrench.Type = "Wrench";
			toolbox1.AddTool(boxEndWrench, toolbox1);

			toolbox1.List();
			Console.ReadLine();
		}
	}

	class Tool
	{
		//why not use a constructor :/
		private string _name = "";
		private string _type = "";
		public string Name {
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}
		public string Type
		{
			get
			{
				return _type;
			}
			set
			{
				_type = value;
			}
		}
		//public string Type { get; set; }

		public void List()
		{
			Console.WriteLine(this.Name);
		}

	}

	class ToolBox
	{
		public List<object> ToolBoxList { get; set; }

		public void AddTool(Tool tool, ToolBox toolBox)
		{
			//if (toolbox == null)
			//{
			//	Console.WriteLine("Warning: " + tool.Name + " is null");
			//}
			//else
			//{

				//List<object> list = new ToolBox List<object>;
				toolBox.ToolBoxList.Add(tool);
			//}
			//why is the object coming back null?
        }
		public void List()
		{
			foreach(Tool tool in ToolBoxList)
			{
				tool.List();
			}
		}

		public void RemoveFromToolBox(Tool tool, ToolBox toolBox)
		{
			toolBox.ToolBoxList.Remove(tool);
		}
	}
}
