﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Activities;
using System.IO;
using System.Collections.ObjectModel;

namespace MonoTests.System.Activities {
	[TestFixture]
	public class RuntimeArgumentTest {
		[Test]
		public void Ctor_name_argumentType_direction ()
		{
			var arg = new RuntimeArgument ("Hello\nWorld", typeof (string), ArgumentDirection.In);
			Assert.AreEqual ("Hello\nWorld", arg.Name);
			Assert.AreEqual (typeof (string), arg.Type);
			Assert.AreEqual (ArgumentDirection.In, arg.Direction);
			Assert.IsFalse (arg.IsRequired);
			Assert.AreEqual (0, arg.OverloadGroupNames.Count);
		}
		[Test]
		public void Ctor_name_argumentType_direction_isRequired ()
		{
			var arg = new RuntimeArgument ("Hello\nWorld", typeof (int), ArgumentDirection.InOut, true);
			Assert.AreEqual ("Hello\nWorld", arg.Name);
			Assert.AreEqual (typeof (int), arg.Type);
			Assert.AreEqual (ArgumentDirection.InOut, arg.Direction);
			Assert.IsTrue (arg.IsRequired);
			Assert.AreEqual (0, arg.OverloadGroupNames.Count);
		}
		[Test]
		public void Ctor_name_argumentType_direction_overloadGroupNames ()
		{
			var list = new List<string> () { "str1" };
			var arg = new RuntimeArgument ("Hello\nWorld", typeof (int), ArgumentDirection.InOut, list);
			Assert.AreEqual ("Hello\nWorld", arg.Name);
			Assert.AreEqual (typeof (int), arg.Type);
			Assert.AreEqual (ArgumentDirection.InOut, arg.Direction);
			Assert.IsFalse (arg.IsRequired);
			Assert.AreEqual (1, arg.OverloadGroupNames.Count);
			Assert.AreEqual ("str1", arg.OverloadGroupNames [0]);

			var nullNamesArg = new RuntimeArgument ("Hello\nWorld", typeof (int), ArgumentDirection.InOut, null);
			Assert.IsNotNull (nullNamesArg.OverloadGroupNames);
			Assert.AreEqual (0, nullNamesArg.OverloadGroupNames.Count);
		}
		[Test]
		public void Ctor_name_argumentType_direction_isRequired_overloadGroupNames () // FIXME: test on .NET
		{
			var list = new List<string> () { "str1" };
			var arg = new RuntimeArgument ("Hello\nWorld", typeof (int), ArgumentDirection.InOut, true, list);
			Assert.AreEqual ("Hello\nWorld", arg.Name);
			Assert.AreEqual (typeof (int), arg.Type);
			Assert.AreEqual (ArgumentDirection.InOut, arg.Direction);
			Assert.IsTrue (arg.IsRequired);
			Assert.AreEqual (1, arg.OverloadGroupNames.Count);
			Assert.AreEqual ("str1", arg.OverloadGroupNames [0]);

			var nullNamesArg = new RuntimeArgument ("Hello\nWorld", typeof (int), ArgumentDirection.InOut, true, null);
			Assert.IsNotNull (nullNamesArg.OverloadGroupNames);
			Assert.AreEqual (0, nullNamesArg.OverloadGroupNames.Count);
		}
		[Test, ExpectedException (typeof (ArgumentException))]
		public void Ctor_Name_Null_Ex ()
		{	
			// only testing the ctor currently at the end of all chains
			var arg = new RuntimeArgument (null, typeof (int), ArgumentDirection.InOut, true, null);
		}
		[Test, ExpectedException (typeof (ArgumentException))]
		public void Ctor_Name_Empty_Ex ()
		{	
			// only testing the ctor currently at the end of all chains
			var arg = new RuntimeArgument (String.Empty, typeof (int), ArgumentDirection.InOut, true, null);
		}
		[Test, ExpectedException (typeof (ArgumentNullException))]
		public void Ctor_Type_Null_Ex ()
		{	
			// only testing the ctor currently at the end of all chains
			var arg = new RuntimeArgument ("name", null, ArgumentDirection.InOut, true, null);
		}
		/*tested in ctors
			public void Direction ()
			public void IsRequired ()
			public void OverloadGroupNames () 
			public void NameCore ()
			public void TypeCore ()
		*/
		[Test]
		public void Get_GetT_Set_GetLocation ()
		{
			//FIXME: no parameter tests
			var inString1 = new InArgument<string> ();
			var runtimeArg = new RuntimeArgument ("inString1", typeof (string), ArgumentDirection.In);

			Action<CodeActivityMetadata> cacheMetadata = (metadata) => {
				metadata.AddArgument (runtimeArg);
				metadata.Bind (inString1, runtimeArg);
			};
			Action<CodeActivityContext> execute = (context) => {
				runtimeArg.Set (context, "SetByRA");
				Assert.AreEqual ("SetByRA", inString1.Get (context)); // test runtimeArg Set
				Assert.AreEqual ("SetByRA", runtimeArg.Get (context)); // test runtimeArg Get	
				Assert.AreEqual ("SetByRA", runtimeArg.Get<string> (context)); // test runtimeArg Get<T>	
				var loc = runtimeArg.GetLocation (context);
				Assert.AreEqual ("SetByRA", loc.Value);
				Assert.AreEqual (typeof (string), loc.LocationType);
			};
			var wf = new CodeActivityRunner (cacheMetadata, execute);
			WorkflowInvoker.Invoke (wf);
		}
	}
}