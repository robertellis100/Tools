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

			Tool slotted_screwdriver = new Tool();
			slotted_screwdriver.Name = "Slotted Screwdriver";
			slotted_screwdriver.Type = "Screwdriver";
			toolbox1.AddTool(slotted_screwdriver,toolbox1);

			Tool phillips_screwdriver = new Tool();
			phillips_screwdriver.Name = "Phillips Screwdriver";
			phillips_screwdriver.Type = "Screwdriver";
			toolbox1.AddTool(phillips_screwdriver, toolbox1);

			Tool inch_nut_driver = new Tool();
			inch_nut_driver.Name = "Inch Nut Driver";
			inch_nut_driver.Type = "Screwdriver";
			toolbox1.AddTool(inch_nut_driver, toolbox1);

			Tool pozidriv = new Tool();
			pozidriv.Name = "Pozidriv";
			pozidriv.Type = "Power Bit";
			toolbox1.AddTool(pozidriv, toolbox1);

			Tool security_torx = new Tool();
			security_torx.Name = "Security Torx";
			security_torx.Type = "Power Bit";
			toolbox1.AddTool(security_torx, toolbox1);

			Tool hex_inch = new Tool();
			hex_inch.Name = "Hex Inch";
			hex_inch.Type = "Power Bit";
			toolbox1.AddTool(hex_inch, toolbox1);

			Tool open_end_wrench = new Tool();
			open_end_wrench.Name = "Open End Wrench";
			open_end_wrench.Type = "Wrench";
			toolbox1.AddTool(open_end_wrench, toolbox1);

			Tool combination_wrench = new Tool();
			combination_wrench.Name = "Combination Wrench";
			combination_wrench.Type = "Wrench";
			toolbox1.AddTool(combination_wrench, toolbox1);

			Tool box_end_wrench = new Tool();
			box_end_wrench.Name = "Box End Wrench";
			box_end_wrench.Type = "Wrench";
			toolbox1.AddTool(box_end_wrench, toolbox1);

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

		public void AddTool(Tool tool, ToolBox toolbox)
		{
			//if (toolbox == null)
			//{
			//	Console.WriteLine("Warning: " + tool.Name + " is null");
			//}
			//else
			//{

				//List<object> list = new ToolBox List<object>;
				toolbox.ToolBoxList.Add(tool);
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
	}
}
