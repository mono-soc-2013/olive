﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Activities;

namespace Tests.System.Activities {
	// Argument cant be inherited on .NET by users
	[TestFixture]
	class ArgumentTest {
		
		#region Static Fields
		[Test]
		public void ResultValue ()
		{
			Assert.AreEqual ("Result", Argument.ResultValue);
		}

		[Test]
		public void UnspecifiedEvaluationOrder ()
		{
			Assert.AreEqual (0, Argument.UnspecifiedEvaluationOrder);
		}

		#endregion

		#region Static Methods
		[Test]
		public void Create ()
		{
			throw new NotImplementedException ();
		}

		[Test]
		public void CreateReference ()
		{
			throw new NotImplementedException ();
		}
		
		#endregion
		
	}
	
}